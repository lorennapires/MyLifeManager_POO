namespace MyLifeManager.Forms
{
    partial class FrmDetalheTarefa1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.TextBox txtDataInicio;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.TextBox txtDataFim;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.TextBox txtCategorias;
        private System.Windows.Forms.Panel panelCor;
        private System.Windows.Forms.CheckBox chkConcluida;
        private System.Windows.Forms.Button btnFechar;

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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.TextBox();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.txtDataFim = new System.Windows.Forms.TextBox();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.txtCategorias = new System.Windows.Forms.TextBox();
            this.panelCor = new System.Windows.Forms.Panel();
            this.chkConcluida = new System.Windows.Forms.CheckBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(12, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.Snow;
            this.txtTitulo.Location = new System.Drawing.Point(90, 12);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(250, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescricao.Location = new System.Drawing.Point(12, 45);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.Snow;
            this.txtDescricao.Location = new System.Drawing.Point(90, 42);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(250, 60);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDataInicio.Location = new System.Drawing.Point(12, 115);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(63, 13);
            this.lblDataInicio.TabIndex = 4;
            this.lblDataInicio.Text = "Data Início:";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.BackColor = System.Drawing.Color.Snow;
            this.txtDataInicio.Location = new System.Drawing.Point(90, 112);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.ReadOnly = true;
            this.txtDataInicio.Size = new System.Drawing.Size(250, 20);
            this.txtDataInicio.TabIndex = 5;
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDataFim.Location = new System.Drawing.Point(12, 145);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(52, 13);
            this.lblDataFim.TabIndex = 6;
            this.lblDataFim.Text = "Data Fim:";
            // 
            // txtDataFim
            // 
            this.txtDataFim.BackColor = System.Drawing.Color.Snow;
            this.txtDataFim.Location = new System.Drawing.Point(90, 142);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.ReadOnly = true;
            this.txtDataFim.Size = new System.Drawing.Size(250, 20);
            this.txtDataFim.TabIndex = 7;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategorias.Location = new System.Drawing.Point(12, 175);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(60, 13);
            this.lblCategorias.TabIndex = 8;
            this.lblCategorias.Text = "Categorias:";
            // 
            // txtCategorias
            // 
            this.txtCategorias.BackColor = System.Drawing.Color.Snow;
            this.txtCategorias.Location = new System.Drawing.Point(90, 172);
            this.txtCategorias.Name = "txtCategorias";
            this.txtCategorias.ReadOnly = true;
            this.txtCategorias.Size = new System.Drawing.Size(250, 20);
            this.txtCategorias.TabIndex = 9;
            // 
            // panelCor
            // 
            this.panelCor.BackColor = System.Drawing.Color.MistyRose;
            this.panelCor.Location = new System.Drawing.Point(346, 12);
            this.panelCor.Name = "panelCor";
            this.panelCor.Size = new System.Drawing.Size(30, 20);
            this.panelCor.TabIndex = 10;
            // 
            // chkConcluida
            // 
            this.chkConcluida.AutoSize = true;
            this.chkConcluida.Location = new System.Drawing.Point(90, 205);
            this.chkConcluida.Name = "chkConcluida";
            this.chkConcluida.Size = new System.Drawing.Size(75, 17);
            this.chkConcluida.TabIndex = 11;
            this.chkConcluida.Text = "Concluída";
            this.chkConcluida.UseVisualStyleBackColor = true;
            this.chkConcluida.CheckedChanged += new System.EventHandler(this.chkConcluida_CheckedChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(172)))), ((int)(((byte)(189)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Location = new System.Drawing.Point(90, 240);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(250, 30);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmDetalheTarefa
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(98)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(400, 290);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.chkConcluida);
            this.Controls.Add(this.panelCor);
            this.Controls.Add(this.txtCategorias);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.txtDataFim);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmDetalheTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhe da Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
