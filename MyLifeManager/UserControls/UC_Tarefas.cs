using MyLifeManager.Models;
using MyLifeManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace MyLifeManager.UserControls
{
    public partial class UC_Tarefas : UserControl
    {
        private readonly TarefaService _tarefaService;
        private readonly CategoriaService _categoriaService;

        public UC_Tarefas()
        {
            InitializeComponent();
            _tarefaService = new TarefaService();
            _categoriaService = new CategoriaService();
            // Adiciona o evento de formatação de célula
            this.dgvTarefas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTarefas_CellFormatting);
        }

        private void UC_Tarefas_Load(object sender, EventArgs e)
        {
            CarregarTarefas();
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {
            var categorias = _categoriaService.GetAllCategorias();
            clbCategorias.DataSource = categorias;
            clbCategorias.DisplayMember = "Nome";
            clbCategorias.ValueMember = "Id";
        }

        private void CarregarTarefas()
        {
            dgvTarefas.DataSource = null;
            dgvTarefas.ReadOnly = false;
            ConfigurarGrade(); // Chama a nova configuração
            dgvTarefas.DataSource = _tarefaService.GetAllTarefas();
        }

        private void ConfigurarGrade()
        {
            dgvTarefas.AutoGenerateColumns = false;
            dgvTarefas.Columns.Clear();

            // Coluna TÍTULO
            dgvTarefas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Titulo",
                HeaderText = "Título",
                Name = "colTitulo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Coluna DESCRIÇÃO
            dgvTarefas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descricao",
                HeaderText = "Descrição",
                Name = "colDescricao",
                Width = 250
            });

            // Coluna NOMES DAS CATEGORIAS
            dgvTarefas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoriasNomes",
                HeaderText = "Categorias",
                Name = "colCategoriasNomes",
                Width = 150
            });

            // Coluna DATA DE INÍCIO
            dgvTarefas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data_inicio",
                HeaderText = "Início",
                Name = "colDataInicio",
                Width = 120
            });

            // Coluna DATA DE FIM
            dgvTarefas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data_fim",
                HeaderText = "Fim",
                Name = "colDataFim",
                Width = 120
            });

            // Coluna COR DA CATEGORIA (REORGANIZADA)
            dgvTarefas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CorDaCategoria",
                HeaderText = "Cor",
                Name = "colCor",
                Width = 50
            });

            // Coluna CONCLUÍDA (CHECKBOX)
            dgvTarefas.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Concluida",
                HeaderText = "OK?",
                Name = "colConcluida",
                Width = 40
            });
        }

        private void dgvTarefas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTarefas.Columns[e.ColumnIndex].Name == "colCor")
            {
                if (e.Value != null)
                {
                    string hexColor = e.Value.ToString();
                    if (!string.IsNullOrEmpty(hexColor))
                    {
                        try
                        {
                            Color cor = ColorTranslator.FromHtml(hexColor);
                            e.CellStyle.BackColor = cor;
                            e.CellStyle.ForeColor = cor; // Esconde o texto hexadecimal
                            e.CellStyle.SelectionBackColor = cor;
                            e.CellStyle.SelectionForeColor = cor;
                        }
                        catch { }
                    }
                }
            }
        }

        private void btnSalvarTarefa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTituloTarefa.Text))
            {
                MessageBox.Show("O título da tarefa não pode ser vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDataFim.Value < dtpDataInicio.Value)
            {
                MessageBox.Show("A data de fim não pode ser anterior à data de início.", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var novaTarefa = new Tarefa
            {
                Titulo = txtTituloTarefa.Text,
                Descricao = txtDescricaoTarefa.Text,
                Data_inicio = dtpDataInicio.Value,
                Data_fim = dtpDataFim.Value,
                Concluida = chkConcluida.Checked
            };

            var idsCategoriasSelecionadas = clbCategorias.CheckedItems.OfType<Categoria>().Select(c => c.Id).ToList();
            _tarefaService.InsertTarefaComCategorias(novaTarefa, idsCategoriasSelecionadas);
            MessageBox.Show("Tarefa salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
            CarregarTarefas();
        }

        private void LimparCampos()
        {
            txtTituloTarefa.Clear();
            txtDescricaoTarefa.Clear();
            dtpDataInicio.Value = DateTime.Now;
            dtpDataFim.Value = DateTime.Now;
            chkConcluida.Checked = false;
            for (int i = 0; i < clbCategorias.Items.Count; i++)
            {
                clbCategorias.SetItemChecked(i, false);
            }
        }

        private void dgvTarefas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvTarefas.Columns["colConcluida"] == null || e.ColumnIndex != dgvTarefas.Columns["colConcluida"].Index)
            {
                return;
            }

            // O DataGridView pode ter linhas que não estão ligadas a dados (como a linha de novo item)
            // Esta verificação garante que só trabalhamos com linhas que têm dados reais
            if (dgvTarefas.Rows[e.RowIndex].DataBoundItem is Tarefa tarefa)
            {
                bool novoStatus = (bool)dgvTarefas.Rows[e.RowIndex].Cells["colConcluida"].Value;
                _tarefaService.UpdateStatusTarefa(tarefa.Id, novoStatus);
            }
        }
    }
}