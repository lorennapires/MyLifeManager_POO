namespace MyLifeManager.UserControls
{
    partial class UC_Tarefas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTituloTarefa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricaoTarefa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.btnSalvarTarefa = new System.Windows.Forms.Button();
            this.labelCategorias = new System.Windows.Forms.Label();
            this.clbCategorias = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título da Tarefa:";
            // 
            // txtTituloTarefa
            // 
            this.txtTituloTarefa.Location = new System.Drawing.Point(146, 40);
            this.txtTituloTarefa.Name = "txtTituloTarefa";
            this.txtTituloTarefa.Size = new System.Drawing.Size(200, 20);
            this.txtTituloTarefa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // txtDescricaoTarefa
            // 
            this.txtDescricaoTarefa.Location = new System.Drawing.Point(146, 70);
            this.txtDescricaoTarefa.Multiline = true;
            this.txtDescricaoTarefa.Name = "txtDescricaoTarefa";
            this.txtDescricaoTarefa.Size = new System.Drawing.Size(200, 60);
            this.txtDescricaoTarefa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Início:";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInicio.Location = new System.Drawing.Point(146, 143);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.ShowUpDown = true;
            this.dtpDataInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpDataInicio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Fim:";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFim.Location = new System.Drawing.Point(146, 169);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.ShowUpDown = true;
            this.dtpDataFim.Size = new System.Drawing.Size(200, 20);
            this.dtpDataFim.TabIndex = 7;
            // 
            // btnSalvarTarefa
            // 
            this.btnSalvarTarefa.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSalvarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTarefa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarTarefa.Location = new System.Drawing.Point(146, 332);
            this.btnSalvarTarefa.Name = "btnSalvarTarefa";
            this.btnSalvarTarefa.Size = new System.Drawing.Size(200, 30);
            this.btnSalvarTarefa.TabIndex = 11;
            this.btnSalvarTarefa.Text = "Salvar Nova Tarefa";
            this.btnSalvarTarefa.UseVisualStyleBackColor = false;
            this.btnSalvarTarefa.Click += new System.EventHandler(this.btnSalvarTarefa_Click);
            // 
            // labelCategorias
            // 
            this.labelCategorias.AutoSize = true;
            this.labelCategorias.Location = new System.Drawing.Point(80, 203);
            this.labelCategorias.Name = "labelCategorias";
            this.labelCategorias.Size = new System.Drawing.Size(60, 13);
            this.labelCategorias.TabIndex = 8;
            this.labelCategorias.Text = "Categorias:";
            // 
            // clbCategorias
            // 
            this.clbCategorias.CheckOnClick = true;
            this.clbCategorias.FormattingEnabled = true;
            this.clbCategorias.Location = new System.Drawing.Point(146, 203);
            this.clbCategorias.Name = "clbCategorias";
            this.clbCategorias.Size = new System.Drawing.Size(200, 109);
            this.clbCategorias.TabIndex = 9;
            // 
            // UC_Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.btnSalvarTarefa);
            this.Controls.Add(this.clbCategorias);
            this.Controls.Add(this.labelCategorias);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricaoTarefa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTituloTarefa);
            this.Controls.Add(this.label1);
            this.Name = "UC_Tarefas";
            this.Size = new System.Drawing.Size(455, 400);
            this.Load += new System.EventHandler(this.UC_Tarefas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTituloTarefa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricaoTarefa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.Button btnSalvarTarefa;
        private System.Windows.Forms.Label labelCategorias;
        private System.Windows.Forms.CheckedListBox clbCategorias;
    }
}