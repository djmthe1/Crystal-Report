namespace Crystal_Report
{
    partial class PresentarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PFcrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.PFcrystalReportViewer1.ActiveViewIndex = -1;
            this.PFcrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PFcrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.PFcrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PFcrystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.PFcrystalReportViewer1.Name = "crystalReportViewer1";
            this.PFcrystalReportViewer1.Size = new System.Drawing.Size(284, 262);
            this.PFcrystalReportViewer1.TabIndex = 0;
            // 
            // PresentarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.PFcrystalReportViewer1);
            this.Name = "PresentarForm";
            this.Text = "Presentar";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer PFcrystalReportViewer1;
    }
}