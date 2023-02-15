namespace app.report.model01.View
{
    partial class frmReporte
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
            this.crvInforme = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvInforme
            // 
            this.crvInforme.ActiveViewIndex = -1;
            this.crvInforme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInforme.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInforme.Location = new System.Drawing.Point(0, 0);
            this.crvInforme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crvInforme.Name = "crvInforme";
            this.crvInforme.Size = new System.Drawing.Size(869, 615);
            this.crvInforme.TabIndex = 0;
            this.crvInforme.ToolPanelWidth = 267;
            this.crvInforme.Load += new System.EventHandler(this.crvInforme_Load);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 615);
            this.Controls.Add(this.crvInforme);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporte";
            this.Text = "REPORTES";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInforme;
    }
}