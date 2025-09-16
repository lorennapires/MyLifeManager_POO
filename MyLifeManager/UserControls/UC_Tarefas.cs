using MyLifeManager.Models;
using MyLifeManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            this.Load += UC_Tarefas_Load;
        }

        private void UC_Tarefas_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {
            var categorias = _categoriaService.GetAllCategorias();
            clbCategorias.DataSource = categorias;
            clbCategorias.DisplayMember = "Nome";
            clbCategorias.ValueMember = "Id";
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
                Data_fim = dtpDataFim.Value
            };

            var idsCategoriasSelecionadas = clbCategorias.CheckedItems.OfType<Categoria>().Select(c => c.Id).ToList();
            _tarefaService.InsertTarefaComCategorias(novaTarefa, idsCategoriasSelecionadas);
            MessageBox.Show("Tarefa salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
        }

        private void LimparCampos()
        {
            txtTituloTarefa.Clear();
            txtDescricaoTarefa.Clear();
            dtpDataInicio.Value = DateTime.Now;
            dtpDataFim.Value = DateTime.Now;
            for (int i = 0; i < clbCategorias.Items.Count; i++)
            {
                clbCategorias.SetItemChecked(i, false);
            }
        }
    }
}
