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
            var tarefas = _tarefaService.GetAllTarefas();
            dgvTarefas.DataSource = null;
            dgvTarefas.DataSource = tarefas;
            ConfigurarGrade();
        }

        private void ConfigurarGrade()
        {
            dgvTarefas.Columns["Id"].Visible = false;
            dgvTarefas.Columns["CorDaCategoria"].Visible = false;

            dgvTarefas.Columns["Titulo"].HeaderText = "Título";
            dgvTarefas.Columns["Titulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvTarefas.Columns["Descricao"].HeaderText = "Descrição";
            dgvTarefas.Columns["Descricao"].Visible = true;
            dgvTarefas.Columns["Descricao"].Width = 200;

            dgvTarefas.Columns["CategoriasNomes"].HeaderText = "Categorias";
            dgvTarefas.Columns["CategoriasNomes"].Width = 150;

            dgvTarefas.Columns["Data_inicio"].HeaderText = "Início";
            dgvTarefas.Columns["Data_inicio"].Width = 120;

            dgvTarefas.Columns["Data_fim"].HeaderText = "Fim";
            dgvTarefas.Columns["Data_fim"].Width = 120;

            dgvTarefas.Columns["Concluida"].HeaderText = "OK?";
            dgvTarefas.Columns["Concluida"].Width = 40;
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
            if (e.RowIndex < 0 || e.ColumnIndex != dgvTarefas.Columns["Concluida"].Index)
            {
                return;
            }

            int tarefaId = (int)dgvTarefas.Rows[e.RowIndex].Cells["Id"].Value;
            bool novoStatus = (bool)dgvTarefas.Rows[e.RowIndex].Cells["Concluida"].Value;
            _tarefaService.UpdateStatusTarefa(tarefaId, novoStatus);
        }
    }
}