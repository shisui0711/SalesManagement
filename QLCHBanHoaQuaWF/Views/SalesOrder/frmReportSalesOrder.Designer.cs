namespace QLCHWF.Views.SalesOrder
{
    partial class frmReportSalesOrder
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
            this.rpvSalesOrder = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            this.pnlHeader.Controls.Add(this.lblTitile);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.CustomizableEdges = customizableEdges3;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.pnlHeader.Size = new System.Drawing.Size(892, 49);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitile
            // 
            this.lblTitile.AutoSize = true;
            this.lblTitile.BackColor = System.Drawing.Color.Transparent;
            this.lblTitile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitile.ForeColor = System.Drawing.Color.White;
            this.lblTitile.Location = new System.Drawing.Point(12, 13);
            this.lblTitile.Name = "lblTitile";
            this.lblTitile.Size = new System.Drawing.Size(159, 23);
            this.lblTitile.TabIndex = 18;
            this.lblTitile.Text = "Hóa đơn bán hàng";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 10;
            this.btnClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.btnClose.CustomizableEdges = customizableEdges1;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(845, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnClose.Size = new System.Drawing.Size(44, 33);
            this.btnClose.TabIndex = 17;
            // 
            // pnlReport
            // 
            this.pnlReport.Controls.Add(this.rpvSalesOrder);
            this.pnlReport.CustomizableEdges = customizableEdges5;
            this.pnlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReport.Location = new System.Drawing.Point(3, 52);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.pnlReport.Size = new System.Drawing.Size(892, 646);
            this.pnlReport.TabIndex = 1;
            // 
            // rpvSalesOrder
            // 
            this.rpvSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvSalesOrder.Location = new System.Drawing.Point(0, 0);
            this.rpvSalesOrder.Name = "ReportViewer";
            this.rpvSalesOrder.ServerReport.BearerToken = null;
            this.rpvSalesOrder.Size = new System.Drawing.Size(892, 646);
            this.rpvSalesOrder.TabIndex = 0;
            // 
            // dragControl
            // 
            this.dragControl.DockIndicatorTransparencyValue = 0.6D;
            this.dragControl.TargetControl = this.pnlHeader;
            this.dragControl.UseTransparentDrag = true;
            // 
            // frmReportSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(191)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(898, 701);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportSalesOrder";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReportSalesOrder";
            this.Load += new System.EventHandler(this.frmReportSalesOrder_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlReport;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Label lblTitile;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Microsoft.Reporting.WinForms.ReportViewer rpvSalesOrder;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
    }
}