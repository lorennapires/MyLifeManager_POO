using MyLifeManager.Models;
using MyLifeManager.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyLifeManager.UserControls
{
    public partial class UC_Categorias : UserControl
    {
        private readonly CategoriaService _categoriaService;
        private Color _corSelecionada;

        public UC_Categorias()
        {
            InitializeComponent();
            _categoriaService = new CategoriaService();
            _corSelecionada = Color.White;
            panelCor.BackColor = _corSelecionada;
        }

        private void UC_Categorias_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {
            var categorias = _categoriaService.GetAllCategorias();
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = categorias;
            ConfigurarGrade();
        }
      

        private void ConfigurarGrade()
        {
            if (dgvCategorias.Columns.Contains("Id"))
                dgvCategorias.Columns["Id"].Visible = false;

            if (dgvCategorias.Columns.Contains("Tarefas"))
                dgvCategorias.Columns["Tarefas"].Visible = false;

            if (dgvCategorias.Columns.Contains("Nome"))
                dgvCategorias.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dgvCategorias.Columns.Contains("Cor"))
                dgvCategorias.Columns["Cor"].Width = 100;
        }

        private void btnEscolherCor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _corSelecionada = colorDialog.Color;
                    panelCor.BackColor = _corSelecionada;
                }
            }
        }

        private void btnSalvarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeCategoria.Text))
            {
                MessageBox.Show("O nome da categoria não pode ser vazio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var novaCategoria = new Categoria
            {
                Nome = txtNomeCategoria.Text,
                Cor = ColorTranslator.ToHtml(_corSelecionada)
            };

            _categoriaService.InsertCategoria(novaCategoria);

            MessageBox.Show("Categoria salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
            CarregarCategorias();
        }

        private void LimparCampos()
        {
            txtNomeCategoria.Clear();
            _corSelecionada = Color.White;
            panelCor.BackColor = _corSelecionada;
        }

        private void dgvCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCategorias.Columns[e.ColumnIndex].Name == "Cor")
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
                            e.CellStyle.ForeColor = cor;
                            e.CellStyle.SelectionBackColor = cor;
                            e.CellStyle.SelectionForeColor = cor;
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }
    }
}