using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MyLifeManager.Models;
using MyLifeManager.Services;

namespace MyLifeManager.UserControls
{
    public partial class UC_CalendarMonth : UserControl
    {
        private readonly TarefaService _tarefaService;
        private int ano;
        private int mes;

        public UC_CalendarMonth()
        {
            InitializeComponent();
            _tarefaService = new TarefaService();
            this.Load += UC_CalendarMonth_Load;
            btnAnterior.Click += btnAnterior_Click;
            btnProximo.Click += btnProximo_Click;
        }

        private void UC_CalendarMonth_Load(object sender, EventArgs e)
        {
            ano = DateTime.Now.Year;
            mes = DateTime.Now.Month;
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
                    Font = new Font("Segoe UI", 8, FontStyle.Regular),
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
            DesenharTarefas();
        }

        private void GerarDias()
        {
            panelDias.Controls.Clear();
            DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
            int diasNoMes = DateTime.DaysInMonth(ano, mes);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;
            int totalDias = 42;

            for (int i = 0; i < totalDias; i++)
            {
                UC_Day day = new UC_Day();
                int diaAtual;
                DateTime dataCorrente;

                if (i < diaSemanaInicio)
                {
                    dataCorrente = primeiroDiaMes.AddDays(i - diaSemanaInicio);
                    diaAtual = dataCorrente.Day;
                    day.BackColor = Color.LightGray;
                }
                else if (i < diaSemanaInicio + diasNoMes)
                {
                    dataCorrente = primeiroDiaMes.AddDays(i - diaSemanaInicio);
                    diaAtual = dataCorrente.Day;
                    day.BackColor = Color.White;
                }
                else
                {
                    dataCorrente = primeiroDiaMes.AddDays(i - diaSemanaInicio);
                    diaAtual = dataCorrente.Day;
                    day.BackColor = Color.LightGray;
                }

                day.DiaNumero = diaAtual;
                day.Tag = dataCorrente;
                day.Margin = new Padding(2);
                panelDias.Controls.Add(day);
            }
        }

        private void DesenharTarefas()
        {
            List<Tarefa> tarefas = _tarefaService.GetAllTarefas();

            DateTime primeiroDiaVisivel = (DateTime)panelDias.Controls[0].Tag;
            DateTime ultimoDiaVisivel = (DateTime)panelDias.Controls[panelDias.Controls.Count - 1].Tag;

            var tarefasDoPeriodo = tarefas.Where(t => t.Data_inicio.HasValue &&
                                                    t.Data_inicio.Value.Date >= primeiroDiaVisivel.Date &&
                                                    t.Data_inicio.Value.Date <= ultimoDiaVisivel.Date).ToList();

            foreach (Control diaControl in panelDias.Controls)
            {
                if (diaControl is UC_Day ucDay)
                {
                    var labelsParaRemover = ucDay.Controls.OfType<Label>().Where(l => l.Name.StartsWith("tarefaLabel")).ToList();
                    foreach (var label in labelsParaRemover)
                    {
                        ucDay.Controls.Remove(label);
                    }

                    DateTime dataDoDia = (DateTime)ucDay.Tag;
                    var tarefasDoDia = tarefasDoPeriodo.Where(t => t.Data_inicio.Value.Date == dataDoDia.Date).ToList();

                    FlowLayoutPanel flowPanel = new FlowLayoutPanel
                    {
                        Dock = DockStyle.Fill,
                        FlowDirection = FlowDirection.TopDown,
                        Padding = new Padding(0),
                        Margin = new Padding(0)
                    };
                    ucDay.Controls.Add(flowPanel);

                    foreach (var tarefa in tarefasDoDia)
                    {
                        Label tarefaLabel = new Label();
                        tarefaLabel.Name = $"tarefaLabel_{tarefa.Id}";
                        tarefaLabel.Text = tarefa.Titulo;
                        tarefaLabel.Font = new Font("Segoe UI", 6, FontStyle.Regular);
                        tarefaLabel.ForeColor = Color.White;
                        tarefaLabel.BackColor = string.IsNullOrEmpty(tarefa.CorDaCategoria) ? Color.Gray : ColorTranslator.FromHtml(tarefa.CorDaCategoria);
                        tarefaLabel.TextAlign = ContentAlignment.MiddleLeft;
                        tarefaLabel.Margin = new Padding(1, 0, 1, 1);
                        tarefaLabel.Height = 14;
                        tarefaLabel.Width = ucDay.Width - 4;

                        flowPanel.Controls.Add(tarefaLabel);
                    }
                }
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