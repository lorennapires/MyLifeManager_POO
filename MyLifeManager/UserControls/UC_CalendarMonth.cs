using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MyLifeManager.UserControls
{
    public partial class UC_CalendarMonth : UserControl
    {
        private int ano = 2025;
        private int mes = 7;

        public UC_CalendarMonth()
        {
            InitializeComponent();

            this.Load += UC_CalendarMonth_Load;
            btnAnterior.Click += btnAnterior_Click;
            btnProximo.Click += btnProximo_Click;
        }

        private void UC_CalendarMonth_Load(object sender, EventArgs e)
        {
            CriarDiasSemana();
            AtualizarCalendario();
        }

        private void CriarDiasSemana()
        {
            string[] nomesDias = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb" };
            int larguraLabel = panelDias.Width / 7;
            int alturaLabel = 20;

            Panel painelDiasSemana = new Panel
            {
                Height = alturaLabel,
                Width = panelDias.Width,
                Location = new Point(panelDias.Location.X, panelDias.Location.Y - alturaLabel + 1),
                BackColor = Color.Transparent
            };

            for (int i = 0; i < 7; i++)
            {
                Label lblDia = new Label
                {
                    Text = nomesDias[i],
                    Width = larguraLabel,
                    Height = alturaLabel,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(i * larguraLabel, 0),
                    Font = new Font("Segoe UI", 8, FontStyle.Regular), // Fonte menor
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black
                };
                painelDiasSemana.Controls.Add(lblDia);
            }

            this.Controls.Add(painelDiasSemana);
            painelDiasSemana.BringToFront();
        }

        private void AtualizarCalendario()
        {
            lblMes.Text = new DateTime(ano, mes, 1)
                .ToString("MMMM yyyy", new CultureInfo("pt-BR"))
                .ToUpper();

            GerarDias();
        }

        private void GerarDias()
        {
            panelDias.Controls.Clear();

            DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
            int diasNoMes = DateTime.DaysInMonth(ano, mes);

            DateTime mesAnterior = primeiroDiaMes.AddMonths(-1);
            int diasMesAnterior = DateTime.DaysInMonth(mesAnterior.Year, mesAnterior.Month);

            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;
            int totalDias = 42;

            for (int i = 0; i < totalDias; i++)
            {
                UC_Day day = new UC_Day();

                if (i < diaSemanaInicio)
                {
                    int diaAnt = diasMesAnterior - diaSemanaInicio + 1 + i;
                    day.DiaNumero = diaAnt;
                    day.BackColor = Color.LightGray;
                    day.ForeColor = Color.DarkGray;
                }
                else if (i < diaSemanaInicio + diasNoMes)
                {
                    int diaAtual = i - diaSemanaInicio + 1;
                    day.DiaNumero = diaAtual;
                    day.BackColor = Color.White;
                    day.ForeColor = Color.Black;
                }
                else
                {
                    int diaProx = i - (diaSemanaInicio + diasNoMes) + 1;
                    day.DiaNumero = diaProx;
                    day.BackColor = Color.LightGray;
                    day.ForeColor = Color.DarkGray;
                }

                day.Margin = new Padding(2);
                panelDias.Controls.Add(day);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            mes++;
            if (mes > 12)
            {
                mes = 1;
                ano++;
            }
            AtualizarCalendario();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            mes--;
            if (mes < 1)
            {
                mes = 12;
                ano--;
            }
            AtualizarCalendario();
        }

        private void LblMes_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Você clicou no mês: {lblMes.Text}");
        }
    }
}
