namespace QLCHBanHoaQuaWF.Views.ImportOrder
{
    partial class frmReportImportOrder
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitile = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlReport = new Guna.UI2.WinForms.Guna2Panel();
            this.rpvImportOrder = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitile);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.CustomizableEdges = customizableEdges3;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.pnlHeader.Size = new System.Drawing.Size(898, 54);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitile
            // 
            this.lblTitile.AutoSize = true;
            this.lblTitile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.lblTitile.Location = new System.Drawing.Point(8, 14);
            this.lblTitile.Name = "lblTitile";
            this.lblTitile.Size = new System.Drawing.Size(169, 23);
            this.lblTitile.TabIndex = 20;
            this.lblTitile.Text = "Hóa đơn nhập hàng";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 10;
            this.btnClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.btnClose.CustomizableEdges = customizableEdges1;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(145)))), ((int)(((byte)(250)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(847, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnClose.Size = new System.Drawing.Size(44, 33);
            this.btnClose.TabIndex = 19;
            // 
            // pnlReport
            // 
            this.pnlReport.Controls.Add(this.rpvImportOrder);
            this.pnlReport.CustomizableEdges = customizableEdges5;
            this.pnlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReport.Location = new System.Drawing.Point(0, 54);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.pnlReport.Size = new System.Drawing.Size(898, 647);
            this.pnlReport.TabIndex = 1;
            // 
            // rpvImportOrder
            // 
            this.rpvImportOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvImportOrder.Location = new System.Drawing.Point(0, 0);
            this.rpvImportOrder.Name = "ReportViewer";
            this.rpvImportOrder.ServerReport.BearerToken = null;
            this.rpvImportOrder.Size = new System.Drawing.Size(898, 647);
            this.rpvImportOrder.TabIndex = 0;
            // 
            // dragControl
            // 
            this.dragControl.DockIndicatorTransparencyValue = 0.6D;
            this.dragControl.TargetControl = this.pnlHeader;
            this.dragControl.UseTransparentDrag = true;
            // 
            // frmReportImportOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 701);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportImportOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReportImportOrder";
            this.Load += new System.EventHandler(this.frmReportImportOrder_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlReport;
        private Label lblTitile;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Microsoft.Reporting.WinForms.ReportViewer rpvImportOrder;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
    }
}