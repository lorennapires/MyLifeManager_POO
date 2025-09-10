using MySql.Data.MySqlClient;
using MyLifeManager.Data;
using MyLifeManager.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyLifeManager.Services
{
    public class CategoriaService
    {
        public List<Categoria> GetAllCategorias()
        {
            var categorias = new List<Categoria>();
            var conn = Connection.GetConnection();

            try
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT id, nome, cor FROM categoria", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var categoria = new Categoria
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Cor = reader.IsDBNull(reader.GetOrdinal("cor")) ? null : reader.GetString("cor")
                    };
                    categorias.Add(categoria);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar categorias: {ex.Message}");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return categorias;
        }

        public void InsertCategoria(Categoria categoria)
        {
            var conn = Connection.GetConnection();
            try
            {
                conn.Open();
                var cmd = new MySqlCommand("INSERT INTO categoria (nome, cor) VALUES (@nome, @cor)", conn);
                cmd.Parameters.AddWithValue("@nome", categoria.Nome);
                cmd.Parameters.AddWithValue("@cor", categoria.Cor);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir categoria: {ex.Message}");
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