namespace MyLifeManager.UserControls
{
    partial class UC_Categorias
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
            this.LabelNomeCategoria = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.LabelNomeCor = new System.Windows.Forms.Label();
            this.panelCor = new System.Windows.Forms.Panel();
            this.btnEscolherCor = new System.Windows.Forms.Button();
            this.btnSalvarCategoria = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNomeCategoria
            // 
            this.LabelNomeCategoria.AutoSize = true;
            this.LabelNomeCategoria.Location = new System.Drawing.Point(15, 15);
            this.LabelNomeCategoria.Name = "LabelNomeCategoria";
            this.LabelNomeCategoria.Size = new System.Drawing.Size(101, 13);
            this.LabelNomeCategoria.TabIndex = 0;
            this.LabelNomeCategoria.Text = "Nome da Categoria:";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(120, 12);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(200, 20);
            this.txtNomeCategoria.TabIndex = 1;
            // 
            // LabelNomeCor
            // 
            this.LabelNomeCor.AutoSize = true;
            this.LabelNomeCor.Location = new System.Drawing.Point(88, 48);
            this.LabelNomeCor.Name = "LabelNomeCor";
            this.LabelNomeCor.Size = new System.Drawing.Size(26, 13);
            this.LabelNomeCor.TabIndex = 2;
            this.LabelNomeCor.Text = "Cor:";
            // 
            // panelCor
            // 
            this.panelCor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCor.Location = new System.Drawing.Point(120, 42);
            this.panelCor.Name = "panelCor";
            this.panelCor.Size = new System.Drawing.Size(25, 25);
            this.panelCor.TabIndex = 3;
            // 
            // btnEscolherCor
            // 
            this.btnEscolherCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btnEscolherCor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEscolherCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolherCor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEscolherCor.Location = new System.Drawing.Point(150, 42);
            this.btnEscolherCor.Name = "btnEscolherCor";
            this.btnEscolherCor.Size = new System.Drawing.Size(75, 25);
            this.btnEscolherCor.TabIndex = 4;
            this.btnEscolherCor.Text = "Escolher...";
            this.btnEscolherCor.UseVisualStyleBackColor = false;
            this.btnEscolherCor.Click += new System.EventHandler(this.btnEscolherCor_Click);
            // 
            // btnSalvarCategoria
            // 
            this.btnSalvarCategoria.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSalvarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarCategoria.Location = new System.Drawing.Point(18, 80);
            this.btnSalvarCategoria.Name = "btnSalvarCategoria";
            this.btnSalvarCategoria.Size = new System.Drawing.Size(302, 30);
            this.btnSalvarCategoria.TabIndex = 5;
            this.btnSalvarCategoria.Text = "Salvar Nova Categoria";
            this.btnSalvarCategoria.UseVisualStyleBackColor = false;
            this.btnSalvarCategoria.Click += new System.EventHandler(this.btnSalvarCategoria_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(18, 125);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.Size = new System.Drawing.Size(395, 250);
            this.dgvCategorias.TabIndex = 6;
            this.dgvCategorias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCategorias_CellFormatting);
            // 
            // UC_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnSalvarCategoria);
            this.Controls.Add(this.btnEscolherCor);
            this.Controls.Add(this.panelCor);
            this.Controls.Add(this.LabelNomeCor);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.LabelNomeCategoria);
            this.Name = "UC_Categorias";
            this.Size = new System.Drawing.Size(453, 400);
            this.Load += new System.EventHandler(this.UC_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LabelNomeCategoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label LabelNomeCor;
        private System.Windows.Forms.Panel panelCor;
        private System.Windows.Forms.Button btnEscolherCor;
        private System.Windows.Forms.Button btnSalvarCategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}