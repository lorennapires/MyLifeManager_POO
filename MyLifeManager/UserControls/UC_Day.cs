using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyLifeManager.UserControls
{
    public partial class UC_Day : UserControl
    {
        public UC_Day()
        {
            InitializeComponent();
            this.Size = new Size(65, 60);
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private int diaNumero = 1;
        public int DiaNumero
        {
            get => diaNumero;
            set
            {
                diaNumero = value;
                lblDia.Text = diaNumero.ToString();
            }
        }
     
        public Label LabelDia => lblDia;

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            lblDia.BackColor = this.BackColor;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            lblDia.ForeColor = this.ForeColor;
        }
    }
}

