namespace QLCHWF.Views.User
{
    partial class frmChangeUserRole
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlBody = new Guna.UI2.WinForms.Guna2Panel();
            cboVaitro = new Guna.UI2.WinForms.Guna2ComboBox();
            userRoleBindingSource = new BindingSource(components);
            btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            lblEmail = new Label();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            lblTitile = new Label();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userRoleBindingSource).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.White;
            pnlBody.Controls.Add(cboVaitro);
            pnlBody.Controls.Add(btnAdd);
            pnlBody.Controls.Add(txtEmail);
            pnlBody.Controls.Add(label2);
            pnlBody.Controls.Add(lblEmail);
            pnlBody.Controls.Add(btnExit);
            pnlBody.CustomizableEdges = customizableEdges9;
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 48);
            pnlBody.Name = "pnlBody";
            pnlBody.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlBody.Size = new Size(584, 246);
            pnlBody.TabIndex = 3;
            // 
            // cboVaitro
            // 
            cboVaitro.BackColor = Color.Transparent;
            cboVaitro.BorderRadius = 5;
            cboVaitro.BorderThickness = 2;
            cboVaitro.CustomizableEdges = customizableEdges1;
            cboVaitro.DataBindings.Add(new Binding("Tag", userRoleBindingSource, "RoleID", true));
            cboVaitro.DataSource = userRoleBindingSource;
            cboVaitro.DrawMode = DrawMode.OwnerDrawFixed;
            cboVaitro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVaitro.FocusedColor = Color.FromArgb(94, 148, 255);
            cboVaitro.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboVaitro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboVaitro.ForeColor = Color.FromArgb(68, 88, 112);
            cboVaitro.ItemHeight = 30;
            cboVaitro.Location = new Point(216, 92);
            cboVaitro.Name = "cboVaitro";
            cboVaitro.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cboVaitro.Size = new Size(280, 36);
            cboVaitro.TabIndex = 40;
            // 
            // userRoleBindingSource
            // 
            userRoleBindingSource.DataSource = typeof(Models.UserRole);
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 5;
            btnAdd.CustomizableEdges = customizableEdges3;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(17, 153, 142);
            btnAdd.FillColor2 = Color.FromArgb(56, 239, 125);
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(114, 166);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdd.Size = new Size(166, 47);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Đổi vai trò";
            btnAdd.Click += btnChange_Click;
            // 
            // txtEmail
            // 
            txtEmail.Animated = true;
            txtEmail.BorderRadius = 5;
            txtEmail.BorderThickness = 2;
            txtEmail.CustomizableEdges = customizableEdges5;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.Enabled = false;
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(216, 28);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtEmail.Size = new Size(280, 40);
            txtEmail.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(134, 92);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 36;
            label2.Text = "Vai trò:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(145, 40);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(65, 28);
            lblEmail.TabIndex = 34;
            lblEmail.Text = "Email:";
            // 
            // btnExit
            // 
            btnExit.Animated = true;
            btnExit.BorderColor = Color.FromArgb(38, 191, 166);
            btnExit.BorderRadius = 5;
            btnExit.BorderThickness = 3;
            btnExit.CustomizableEdges = customizableEdges7;
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
            btnExit.Location = new Point(354, 166);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges8;
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
            pnlHeader.CustomizableEdges = customizableEdges13;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges14;
            pnlHeader.Size = new Size(584, 48);
            pnlHeader.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BorderRadius = 10;
            btnClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            btnClose.CustomizableEdges = customizableEdges11;
            btnClose.FillColor = Color.Transparent;
            btnClose.HoverState.FillColor = Color.Red;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(537, 8);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges12;
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
            lblTitile.Size = new Size(95, 23);
            lblTitile.TabIndex = 22;
            lblTitile.Text = "Đổi vai trò";
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = pnlHeader;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmChangeUserRole
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 294);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmChangeUserRole";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmChangeUserRole";
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userRoleBindingSource).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Label label2;
        private Label lblEmail;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Label lblTitile;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private BindingSource userRoleBindingSource;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cboVaitro;
    }
}