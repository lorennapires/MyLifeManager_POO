using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MyLifeManager.Models;
using MyLifeManager.Services;
using MyLifeManager.Forms;

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
            if (this.Controls.Find("painelDiasSemana", false).Any()) return;
            string[] nomesDias = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb" };
            int larguraLabel = panelDias.Width / 7;
            int alturaLabel = 20;
            Panel painelDiasSemana = new Panel
            {
                Name = "painelDiasSemana",
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
            lblMes.Text = new DateTime(ano, mes, 1).ToString("MMMM yyyy", new CultureInfo("pt-BR")).ToUpper();
            GerarDias();
            DesenharTarefas();
        }

        private void GerarDias()
        {
            panelDias.Controls.Clear();
            DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;
            int totalCaixas = 42;
            for (int i = 0; i < totalCaixas; i++)
            {
                DateTime dataCorrente = primeiroDiaMes.AddDays(i - diaSemanaInicio);
                UC_Day dayControl = new UC_Day
                {
                    DiaNumero = dataCorrente.Day,
                    Tag = dataCorrente,
                    BackColor = (dataCorrente.Month != mes) ? Color.LightGray : Color.White
                };
                panelDias.Controls.Add(dayControl);
            }
        }

        private void DesenharTarefas()
        {
            if (panelDias.Controls.Count == 0) return;
            List<Tarefa> tarefas = _tarefaService.GetAllTarefas();
            DateTime primeiroDiaVisivel = (DateTime)panelDias.Controls[0].Tag;
            DateTime ultimoDiaVisivel = (DateTime)panelDias.Controls[panelDias.Controls.Count - 1].Tag;
            var tarefasDoPeriodo = tarefas.Where(t => t.Data_inicio.HasValue &&
                                                    t.Data_inicio.Value.Date >= primeiroDiaVisivel.Date &&
                                                    t.Data_inicio.Value.Date <= ultimoDiaVisivel.Date &&
                                                    !t.Concluida).ToList();
            foreach (Control diaControl in panelDias.Controls)
            {
                if (diaControl is UC_Day ucDay)
                {
                    var flowPanelsParaRemover = ucDay.Controls.OfType<FlowLayoutPanel>().ToList();
                    foreach (var panel in flowPanelsParaRemover) ucDay.Controls.Remove(panel);

                    DateTime dataDoDia = (DateTime)ucDay.Tag;
                    var tarefasDoDia = tarefasDoPeriodo.Where(t => t.Data_inicio.Value.Date == dataDoDia.Date).ToList();
                    if (tarefasDoDia.Any())
                    {
                        FlowLayoutPanel flowPanel = new FlowLayoutPanel
                        {
                            Dock = DockStyle.Bottom,
                            FlowDirection = FlowDirection.TopDown,
                            AutoScroll = true,
                            WrapContents = false,
                            Height = ucDay.Height - 20,
                            BackColor = Color.Transparent
                        };
                        ucDay.Controls.Add(flowPanel);
                        flowPanel.BringToFront();
                        foreach (var tarefa in tarefasDoDia)
                        {
                            Color corDeFundo = string.IsNullOrEmpty(tarefa.CorDaCategoria) ? Color.Gray : ColorTranslator.FromHtml(tarefa.CorDaCategoria);
                            Color corDoTexto = (corDeFundo.GetBrightness() < 0.5) ? Color.White : Color.Black;
                            Label tarefaLabel = new Label
                            {
                                Name = $"tarefaLabel_{tarefa.Id}",
                                Text = tarefa.Titulo,
                                Font = new Font("Segoe UI", 7, FontStyle.Regular),
                                ForeColor = corDoTexto,
                                BackColor = corDeFundo,
                                TextAlign = ContentAlignment.MiddleLeft,
                                Margin = new Padding(1, 0, 1, 1),
                                Height = 16,
                                Width = ucDay.Width - 6,
                                AutoEllipsis = true
                            };
                            tarefaLabel.Click += (s, e) =>
                            {
                                FrmDetalheTarefa1 detalhe = new FrmDetalheTarefa1(tarefa);
                                detalhe.ShowDialog();
                                AtualizarCalendario();
                            };
                            flowPanel.Controls.Add(tarefaLabel);
                        }
                    }
                }
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            mes++;
            if (mes > 12) { mes = 1; ano++; }
            AtualizarCalendario();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            mes--;
            if (mes < 1) { mes = 12; ano--; }
            AtualizarCalendario();
        }
    }
}
