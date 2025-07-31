namespace MyLifeManager.UserControls
{
    partial class UC_Day
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDia;

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
            this.lblDia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDia.Location = new System.Drawing.Point(0, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(60, 20);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "1";
            this.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UC_Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDia);
            this.Name = "UC_Day";
            this.Size = new System.Drawing.Size(60, 60);
            this.ResumeLayout(false);

        }
    }
}
