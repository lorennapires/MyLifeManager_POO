using MyLifeManager.Models;
using MyLifeManager.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyLifeManager.Forms
{
    public partial class FrmDetalheTarefa1 : Form
    {
        private readonly TarefaService _tarefaService;
        private readonly Tarefa _tarefa;

        public FrmDetalheTarefa1(Tarefa tarefa)
        {
            InitializeComponent();
            _tarefaService = new TarefaService();
            _tarefa = tarefa;
            this.Load += FrmDetalheTarefa1_Load;
        }

        private void FrmDetalheTarefa1_Load(object sender, EventArgs e)
        {
            txtTitulo.Text = _tarefa.Titulo;
            txtDescricao.Text = _tarefa.Descricao;
            txtDataInicio.Text = _tarefa.Data_inicio?.ToString("g");
            txtDataFim.Text = _tarefa.Data_fim?.ToString("g");
            txtCategorias.Text = string.Join(", ", _tarefa.CategoriasNomes);
            chkConcluida.Checked = _tarefa.Concluida;

            Color cor = string.IsNullOrEmpty(_tarefa.CorDaCategoria) ? Color.Gray : ColorTranslator.FromHtml(_tarefa.CorDaCategoria);
            panelCor.BackColor = cor;
            Color texto = (cor.GetBrightness() < 0.5) ? Color.White : Color.Black;
            txtTitulo.ForeColor = texto;
        }

        private void chkConcluida_CheckedChanged(object sender, EventArgs e)
        {
            _tarefa.Concluida = chkConcluida.Checked;
            _tarefaService.UpdateStatusTarefa(_tarefa.Id, _tarefa.Concluida);
            if (_tarefa.Concluida)
            {
                MessageBox.Show("Tarefa concluída!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
