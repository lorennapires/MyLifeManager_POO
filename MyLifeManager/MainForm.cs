using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using MyLifeManager.UserControls;



namespace MyLifeManager

{

    public partial class MainForm : Form

    {

        private List<Control> panelMainOriginalControls = new List<Control>();



        public MainForm()

        {

            InitializeComponent();

            foreach (Control c in panelMain.Controls)

            {

                panelMainOriginalControls.Add(c);

            }

        }



        private void MainForm_Load(object sender, EventArgs e)

        {

            button1_Click(sender, e);

        }



        private void panel1_Paint(object sender, PaintEventArgs e)

        {



        }



        private void button1_Click(object sender, EventArgs e)

        {

            // Limpa o painel

            panelMain.Controls.Clear();



            // Adiciona de volta os controles originais

            foreach (Control c in panelMainOriginalControls)

            {

                panelMain.Controls.Add(c);

            }

        }



        private void btnHabitos_Click(object sender, EventArgs e)

        {



        }



        private void textBox1_TextChanged(object sender, EventArgs e)

        {



        }



        private void panelMain_Paint(object sender, PaintEventArgs e)

        {



        }



        private void uC_CalendarMonth1_Load(object sender, EventArgs e)

        {



        }



        private void label1_Click(object sender, EventArgs e)

        {



        }



        private void uC_CalendarMonth1_Load_1(object sender, EventArgs e)

        {



        }



        private void uC_CalendarMonth1_Load_2(object sender, EventArgs e)

        {



        }



        private void btnCategorias_Click(object sender, EventArgs e)

        {

            panelMain.Controls.Clear();

            UC_Categorias uc = new UC_Categorias();

            uc.Dock = DockStyle.Fill;

            panelMain.Controls.Add(uc);

        }



        private void btnTarefas_Click(object sender, EventArgs e)

        {

            panelMain.Controls.Clear();

            UC_Tarefas uc = new UC_Tarefas();

            uc.Dock = DockStyle.Fill;

            panelMain.Controls.Add(uc);

        }

    }

}