namespace QLCHWF.Views
{
    partial class frmOptionExport
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlBody = new Guna.UI2.WinForms.Guna2Panel();
            userRoleBindingSource = new BindingSource(components);
            btnExport = new Guna.UI2.WinForms.Guna2GradientButton();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            lblTitile = new Label();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            cboAll = new Guna.UI2.WinForms.Guna2RadioButton();
            cboThisPage = new Guna.UI2.WinForms.Guna2RadioButton();
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userRoleBindingSource).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.White;
            pnlBody.Controls.Add(cboThisPage);
            pnlBody.Controls.Add(cboAll);
            pnlBody.Controls.Add(btnExport);
            pnlBody.Controls.Add(btnExit);
            pnlBody.CustomizableEdges = customizableEdges5;
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 48);
            pnlBody.Name = "pnlBody";
            pnlBody.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlBody.Size = new Size(584, 169);
            pnlBody.TabIndex = 5;
            // 
            // userRoleBindingSource
            // 
            userRoleBindingSource.DataSource = typeof(Models.UserRole);
            // 
            // btnExport
            // 
            btnExport.BorderRadius = 5;
            btnExport.CustomizableEdges = customizableEdges1;
            btnExport.DisabledState.BorderColor = Color.DarkGray;
            btnExport.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExport.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExport.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnExport.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExport.FillColor = Color.FromArgb(17, 153, 142);
            btnExport.FillColor2 = Color.FromArgb(56, 239, 125);
            btnExport.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(381, 18);
            btnExport.Name = "btnExport";
            btnExport.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExport.Size = new Size(166, 47);
            btnExport.TabIndex = 0;
            btnExport.Text = "Xuất file";
            // 
            // btnExit
            // 
            btnExit.Animated = true;
            btnExit.BorderColor = Color.FromArgb(38, 191, 166);
            btnExit.BorderRadius = 5;
            btnExit.BorderThickness = 3;
            btnExit.CustomizableEdges = customizableEdges3;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.White;
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(38, 191, 166);
            btnExit.HoverState.BorderColor = Color.Red;
            btnExit.HoverState.FillColor = Color.Red;
            btnExit.HoverState.ForeColor = Color.White;
            btnExit.Location = new Point(381, 89);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExit.Size = new Size(166, 47);
            btnExit.TabIndex = 1;
            btnExit.Text = "Đóng";
            btnExit.Click += btnExit_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(38, 191, 166);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(lblTitile);
            pnlHeader.CustomizableEdges = customizableEdges9;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlHeader.Size = new Size(584, 48);
            pnlHeader.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BorderRadius = 10;
            btnClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            btnClose.CustomizableEdges = customizableEdges7;
            btnClose.FillColor = Color.Transparent;
            btnClose.HoverState.FillColor = Color.Red;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(537, 9);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnClose.Size = new Size(44, 33);
            btnClose.TabIndex = 23;
            // 
            // lblTitile
            // 
            lblTitile.AutoSize = true;
            lblTitile.BackColor = Color.Transparent;
            lblTitile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitile.ForeColor = Color.White;
            lblTitile.Location = new Point(11, 12);
            lblTitile.Name = "lblTitile";
            lblTitile.Size = new Size(78, 23);
            lblTitile.TabIndex = 22;
            lblTitile.Text = "Xuất file";
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = pnlHeader;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // cboAll
            // 
            cboAll.AutoSize = true;
            cboAll.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboAll.CheckedState.BorderThickness = 0;
            cboAll.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cboAll.CheckedState.InnerColor = Color.White;
            cboAll.CheckedState.InnerOffset = -4;
            cboAll.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboAll.Location = new Point(48, 38);
            cboAll.Name = "cboAll";
            cboAll.Size = new Size(145, 27);
            cboAll.TabIndex = 41;
            cboAll.Text = "Tất cả các mục";
            cboAll.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cboAll.UncheckedState.BorderThickness = 2;
            cboAll.UncheckedState.FillColor = Color.Transparent;
            cboAll.UncheckedState.InnerColor = Color.Transparent;
            // 
            // cboThisPage
            // 
            cboThisPage.AutoSize = true;
            cboThisPage.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboThisPage.CheckedState.BorderThickness = 0;
            cboThisPage.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cboThisPage.CheckedState.InnerColor = Color.White;
            cboThisPage.CheckedState.InnerOffset = -4;
            cboThisPage.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboThisPage.Location = new Point(48, 89);
            cboThisPage.Name = "cboThisPage";
            cboThisPage.Size = new Size(231, 27);
            cboThisPage.TabIndex = 41;
            cboThisPage.Text = "Chỉ các mục được hiển thị";
            cboThisPage.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cboThisPage.UncheckedState.BorderThickness = 2;
            cboThisPage.UncheckedState.FillColor = Color.Transparent;
            cboThisPage.UncheckedState.InnerColor = Color.Transparent;
            // 
            // frmOptionExport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 217);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOptionExport";
            StartPosition = FormStartPosition.CenterParent;
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userRoleBindingSource).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private Guna.UI2.WinForms.Guna2RadioButton cboAll;
        private BindingSource userRoleBindingSource;
        private Guna.UI2.WinForms.Guna2GradientButton btnExport;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Label lblTitile;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2RadioButton cboThisPage;
    }
}