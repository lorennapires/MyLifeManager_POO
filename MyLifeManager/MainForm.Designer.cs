namespace MyLifeManager
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Logo2 = new System.Windows.Forms.Label();
            this.Logo1 = new System.Windows.Forms.Label();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnResumo = new System.Windows.Forms.Button();
            this.btnMetas = new System.Windows.Forms.Button();
            this.btnHabitos = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.uC_CalendarMonth1 = new MyLifeManager.UserControls.UC_CalendarMonth();
            this.Logo3 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.panelMenu.Controls.Add(this.Logo2);
            this.panelMenu.Controls.Add(this.Logo1);
            this.panelMenu.Controls.Add(this.btnCategorias);
            this.panelMenu.Controls.Add(this.btnResumo);
            this.panelMenu.Controls.Add(this.btnMetas);
            this.panelMenu.Controls.Add(this.btnHabitos);
            this.panelMenu.Controls.Add(this.btnTarefas);
            this.panelMenu.Controls.Add(this.btnAgenda);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(148, 513);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Logo2
            // 
            this.Logo2.AutoSize = true;
            this.Logo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.Logo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo2.Location = new System.Drawing.Point(8, 40);
            this.Logo2.Name = "Logo2";
            this.Logo2.Size = new System.Drawing.Size(72, 20);
            this.Logo2.TabIndex = 1;
            this.Logo2.Text = "Manager";
            // 
            // Logo1
            // 
            this.Logo1.AutoSize = true;
            this.Logo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.Logo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo1.Location = new System.Drawing.Point(7, 15);
            this.Logo1.Name = "Logo1";
            this.Logo1.Size = new System.Drawing.Size(82, 25);
            this.Logo1.TabIndex = 1;
            this.Logo1.Text = "My Life";
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Location = new System.Drawing.Point(0, 245);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(148, 23);
            this.btnCategorias.TabIndex = 6;
            this.btnCategorias.Text = "Categorias\n\n";
            this.btnCategorias.UseVisualStyleBackColor = false;
            // 
            // btnResumo
            // 
            this.btnResumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btnResumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumo.Location = new System.Drawing.Point(0, 216);
            this.btnResumo.Name = "btnResumo";
            this.btnResumo.Size = new System.Drawing.Size(148, 23);
            this.btnResumo.TabIndex = 5;
            this.btnResumo.Text = "Resumo";
            this.btnResumo.UseVisualStyleBackColor = false;
            // 
            // btnMetas
            // 
            this.btnMetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btnMetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetas.Location = new System.Drawing.Point(0, 187);
            this.btnMetas.Name = "btnMetas";
            this.btnMetas.Size = new System.Drawing.Size(148, 23);
            this.btnMetas.TabIndex = 4;
            this.btnMetas.Text = "Metas";
            this.btnMetas.UseVisualStyleBackColor = false;
            // 
            // btnHabitos
            // 
            this.btnHabitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btnHabitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabitos.Location = new System.Drawing.Point(0, 158);
            this.btnHabitos.Name = "btnHabitos";
            this.btnHabitos.Size = new System.Drawing.Size(148, 23);
            this.btnHabitos.TabIndex = 3;
            this.btnHabitos.Text = "Hábitos";
            this.btnHabitos.UseVisualStyleBackColor = false;
            this.btnHabitos.Click += new System.EventHandler(this.btnHabitos_Click);
            // 
            // btnTarefas
            // 
            this.btnTarefas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btnTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarefas.Location = new System.Drawing.Point(0, 129);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(148, 23);
            this.btnTarefas.TabIndex = 2;
            this.btnTarefas.Text = "Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = false;
            // 
            // btnAgenda
            // 
            this.btnAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Location = new System.Drawing.Point(0, 100);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(148, 23);
            this.btnAgenda.TabIndex = 1;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.uC_CalendarMonth1);
            this.panelMain.Controls.Add(this.Logo3);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(148, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(616, 513);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // uC_CalendarMonth1
            // 
            this.uC_CalendarMonth1.Location = new System.Drawing.Point(48, 67);
            this.uC_CalendarMonth1.Name = "uC_CalendarMonth1";
            this.uC_CalendarMonth1.Size = new System.Drawing.Size(529, 443);
            this.uC_CalendarMonth1.TabIndex = 2;
            this.uC_CalendarMonth1.Load += new System.EventHandler(this.uC_CalendarMonth1_Load_2);
            // 
            // Logo3
            // 
            this.Logo3.AutoSize = true;
            this.Logo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo3.Location = new System.Drawing.Point(28, 22);
            this.Logo3.Name = "Logo3";
            this.Logo3.Size = new System.Drawing.Size(181, 26);
            this.Logo3.TabIndex = 1;
            this.Logo3.Text = "MyLife Manager";
            this.Logo3.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 513);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnHabitos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnResumo;
        private System.Windows.Forms.Button btnMetas;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label Logo2;
        private System.Windows.Forms.Label Logo1;
        private System.Windows.Forms.Label Logo3;
        private UserControls.UC_CalendarMonth uC_CalendarMonth1;
    }
}

