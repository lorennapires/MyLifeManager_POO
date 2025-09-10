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
            this.chkConcluida = new System.Windows.Forms.CheckBox();
            this.btnSalvarTarefa = new System.Windows.Forms.Button();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.labelCategorias = new System.Windows.Forms.Label();
            this.clbCategorias = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título da Tarefa:";
            // 
            // txtTituloTarefa
            // 
            this.txtTituloTarefa.Location = new System.Drawing.Point(99, 12);
            this.txtTituloTarefa.Name = "txtTituloTarefa";
            this.txtTituloTarefa.Size = new System.Drawing.Size(200, 20);
            this.txtTituloTarefa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // txtDescricaoTarefa
            // 
            this.txtDescricaoTarefa.Location = new System.Drawing.Point(99, 42);
            this.txtDescricaoTarefa.Multiline = true;
            this.txtDescricaoTarefa.Name = "txtDescricaoTarefa";
            this.txtDescricaoTarefa.Size = new System.Drawing.Size(200, 60);
            this.txtDescricaoTarefa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Início:";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInicio.Location = new System.Drawing.Point(99, 115);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.ShowUpDown = true;
            this.dtpDataInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpDataInicio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Fim:";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFim.Location = new System.Drawing.Point(99, 141);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.ShowUpDown = true;
            this.dtpDataFim.Size = new System.Drawing.Size(200, 20);
            this.dtpDataFim.TabIndex = 7;
            // 
            // chkConcluida
            // 
            this.chkConcluida.AutoSize = true;
            this.chkConcluida.Location = new System.Drawing.Point(99, 260);
            this.chkConcluida.Name = "chkConcluida";
            this.chkConcluida.Size = new System.Drawing.Size(75, 17);
            this.chkConcluida.TabIndex = 10;
            this.chkConcluida.Text = "Concluída";
            this.chkConcluida.UseVisualStyleBackColor = true;
            // 
            // btnSalvarTarefa
            // 
            this.btnSalvarTarefa.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSalvarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTarefa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarTarefa.Location = new System.Drawing.Point(99, 293);
            this.btnSalvarTarefa.Name = "btnSalvarTarefa";
            this.btnSalvarTarefa.Size = new System.Drawing.Size(200, 30);
            this.btnSalvarTarefa.TabIndex = 11;
            this.btnSalvarTarefa.Text = "Salvar Nova Tarefa";
            this.btnSalvarTarefa.UseVisualStyleBackColor = false;
            this.btnSalvarTarefa.Click += new System.EventHandler(this.btnSalvarTarefa_Click);
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.AllowUserToAddRows = false;
            this.dgvTarefas.AllowUserToDeleteRows = false;
            this.dgvTarefas.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Location = new System.Drawing.Point(326, 0);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.ReadOnly = true;
            this.dgvTarefas.Size = new System.Drawing.Size(341, 400);
            this.dgvTarefas.TabIndex = 12;
            // 
            // labelCategorias
            // 
            this.labelCategorias.AutoSize = true;
            this.labelCategorias.Location = new System.Drawing.Point(33, 175);
            this.labelCategorias.Name = "labelCategorias";
            this.labelCategorias.Size = new System.Drawing.Size(60, 13);
            this.labelCategorias.TabIndex = 8;
            this.labelCategorias.Text = "Categorias:";
            // 
            // clbCategorias
            // 
            this.clbCategorias.CheckOnClick = true;
            this.clbCategorias.FormattingEnabled = true;
            this.clbCategorias.Location = new System.Drawing.Point(99, 175);
            this.clbCategorias.Name = "clbCategorias";
            this.clbCategorias.Size = new System.Drawing.Size(200, 79);
            this.clbCategorias.TabIndex = 9;
            // 
            // UC_Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.dgvTarefas);
            this.Controls.Add(this.btnSalvarTarefa);
            this.Controls.Add(this.chkConcluida);
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
            this.Size = new System.Drawing.Size(668, 400);
            this.Load += new System.EventHandler(this.UC_Tarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
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
        private System.Windows.Forms.CheckBox chkConcluida;
        private System.Windows.Forms.Button btnSalvarTarefa;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.Label labelCategorias;
        private System.Windows.Forms.CheckedListBox clbCategorias;
    }
}