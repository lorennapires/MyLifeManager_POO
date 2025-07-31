namespace MyLifeManager.UserControls
{
    partial class UC_CalendarMonth
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

        #region Código gerado pelo Designer

        private void InitializeComponent()
        {
            this.lblMes = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.panelDias = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTopo = new System.Windows.Forms.Panel();
            this.panelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMes.Location = new System.Drawing.Point(160, 8);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(200, 24);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Julho 2025";
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnProximo.Location = new System.Drawing.Point(450, 8);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(43, 23);
            this.btnProximo.TabIndex = 1;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAnterior.Location = new System.Drawing.Point(25, 8);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(43, 23);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // panelDias
            // 
            this.panelDias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDias.Location = new System.Drawing.Point(0, 80);
            this.panelDias.Name = "panelDias";
            this.panelDias.Size = new System.Drawing.Size(520, 360);
            this.panelDias.TabIndex = 3;
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTopo.Controls.Add(this.btnAnterior);
            this.panelTopo.Controls.Add(this.lblMes);
            this.panelTopo.Controls.Add(this.btnProximo);
            this.panelTopo.Location = new System.Drawing.Point(0, 3);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(520, 40);
            this.panelTopo.TabIndex = 4;
            // 
            // UC_CalendarMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTopo);
            this.Controls.Add(this.panelDias);
            this.Name = "UC_CalendarMonth";
            this.Size = new System.Drawing.Size(520, 443);
            this.panelTopo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.FlowLayoutPanel panelDias;
        private System.Windows.Forms.Panel panelTopo;
    }
}
