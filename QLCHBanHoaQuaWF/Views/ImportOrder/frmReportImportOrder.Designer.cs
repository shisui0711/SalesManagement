namespace QLCHWF.Views.ImportOrder
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            lblTitile = new Label();
            btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            pnlReport = new Guna.UI2.WinForms.Guna2Panel();
            rpvImportOrder = new Microsoft.Reporting.WinForms.ReportViewer();
            dragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlHeader.SuspendLayout();
            pnlReport.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(38, 191, 166);
            pnlHeader.Controls.Add(lblTitile);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.CustomizableEdges = customizableEdges3;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlHeader.Size = new Size(892, 54);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitile
            // 
            lblTitile.AutoSize = true;
            lblTitile.BackColor = Color.Transparent;
            lblTitile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitile.ForeColor = Color.White;
            lblTitile.Location = new Point(8, 14);
            lblTitile.Name = "lblTitile";
            lblTitile.Size = new Size(169, 23);
            lblTitile.TabIndex = 20;
            lblTitile.Text = "Hóa đơn nhập hàng";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BorderRadius = 10;
            btnClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.FillColor = Color.Transparent;
            btnClose.HoverState.FillColor = Color.Red;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(841, 11);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(44, 33);
            btnClose.TabIndex = 19;
            // 
            // pnlReport
            // 
            pnlReport.Controls.Add(rpvImportOrder);
            pnlReport.CustomizableEdges = customizableEdges5;
            pnlReport.Dock = DockStyle.Fill;
            pnlReport.Location = new Point(3, 57);
            pnlReport.Name = "pnlReport";
            pnlReport.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlReport.Size = new Size(892, 641);
            pnlReport.TabIndex = 1;
            // 
            // rpvImportOrder
            // 
            rpvImportOrder.Dock = DockStyle.Fill;
            rpvImportOrder.Location = new Point(0, 0);
            rpvImportOrder.Name = "ReportViewer";
            rpvImportOrder.ServerReport.BearerToken = null;
            rpvImportOrder.Size = new Size(892, 641);
            rpvImportOrder.TabIndex = 0;
            rpvImportOrder.Scroll += rpvImportOrder_Scroll;
            // 
            // dragControl
            // 
            dragControl.DockIndicatorTransparencyValue = 0.6D;
            dragControl.TargetControl = pnlHeader;
            dragControl.UseTransparentDrag = true;
            // 
            // frmReportImportOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 191, 166);
            ClientSize = new Size(898, 701);
            Controls.Add(pnlReport);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReportImportOrder";
            Padding = new Padding(3);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmReportImportOrder";
            FormClosing += frmReportImportOrder_FormClosing;
            Load += frmReportImportOrder_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlReport.ResumeLayout(false);
            ResumeLayout(false);
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