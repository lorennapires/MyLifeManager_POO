using MySql.Data.MySqlClient;
using MyLifeManager.Data;
using MyLifeManager.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyLifeManager.Services
{
    public class TarefaService
    {
        public List<Tarefa> GetAllTarefas()
        {
            var tarefas = new List<Tarefa>();
            var conn = Connection.GetConnection();

            try
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT id, titulo, descricao, data_inicio, data_fim, concluida FROM tarefa", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var tarefa = new Tarefa
                    {
                        Id = reader.GetInt32("id"),
                        Titulo = reader.GetString("titulo"),
                        Descricao = reader.IsDBNull(reader.GetOrdinal("descricao")) ? null : reader.GetString("descricao"),
                        Data_inicio = reader.IsDBNull(reader.GetOrdinal("data_inicio")) ? (DateTime?)null : reader.GetDateTime("data_inicio"),
                        Data_fim = reader.IsDBNull(reader.GetOrdinal("data_fim")) ? (DateTime?)null : reader.GetDateTime("data_fim"),
                        Concluida = reader.GetBoolean("concluida")
                    };
                    tarefas.Add(tarefa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar tarefas: {ex.Message}");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return tarefas;
        }

        public void InsertTarefaComCategorias(Tarefa tarefa, List<int> categoriaIds)
        {
            var conn = Connection.GetConnection();
            MySqlTransaction transaction = null;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                var cmdTarefa = new MySqlCommand("INSERT INTO tarefa (titulo, descricao, data_inicio, data_fim, concluida) VALUES (@titulo, @descricao, @data_inicio, @data_fim, @concluida); SELECT LAST_INSERT_ID();", conn, transaction);

                cmdTarefa.Parameters.AddWithValue("@titulo", tarefa.Titulo);
                cmdTarefa.Parameters.AddWithValue("@descricao", tarefa.Descricao);
                cmdTarefa.Parameters.AddWithValue("@data_inicio", tarefa.Data_inicio.HasValue ? (object)tarefa.Data_inicio.Value : DBNull.Value);
                cmdTarefa.Parameters.AddWithValue("@data_fim", tarefa.Data_fim.HasValue ? (object)tarefa.Data_fim.Value : DBNull.Value);
                cmdTarefa.Parameters.AddWithValue("@concluida", tarefa.Concluida);

                long tarefaId = Convert.ToInt64(cmdTarefa.ExecuteScalar());

                if (categoriaIds != null && categoriaIds.Count > 0)
                {
                    foreach (int categoriaId in categoriaIds)
                    {
                        var cmdCategoria = new MySqlCommand("INSERT INTO tarefas_categorias (tarefa_id, categoria_id) VALUES (@tarefa_id, @categoria_id)", conn, transaction);
                        cmdCategoria.Parameters.AddWithValue("@tarefa_id", tarefaId);
                        cmdCategoria.Parameters.AddWithValue("@categoria_id", categoriaId);
                        cmdCategoria.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction?.Rollback();
                }
                catch { }
                MessageBox.Show($"Erro ao inserir tarefa com categorias: {ex.Message}");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}