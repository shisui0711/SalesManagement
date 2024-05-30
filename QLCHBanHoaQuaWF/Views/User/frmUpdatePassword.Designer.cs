namespace QLCHWF.Views.User
{
    partial class frmUpdatePassword
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            lblTitile = new Label();
            btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlBody = new Guna.UI2.WinForms.Guna2Panel();
            lblEmail = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            lblPassword = new Label();
            txtRepassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(38, 191, 166);
            pnlHeader.Controls.Add(lblTitile);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.CustomizableEdges = customizableEdges13;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges14;
            pnlHeader.Size = new Size(578, 47);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitile
            // 
            lblTitile.AutoSize = true;
            lblTitile.BackColor = Color.Transparent;
            lblTitile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitile.ForeColor = Color.White;
            lblTitile.Location = new Point(18, 12);
            lblTitile.Name = "lblTitile";
            lblTitile.Size = new Size(119, 23);
            lblTitile.TabIndex = 20;
            lblTitile.Text = "Đổi mật khẩu";
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
            btnClose.Location = new Point(531, 8);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnClose.Size = new Size(44, 33);
            btnClose.TabIndex = 19;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = pnlHeader;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.White;
            pnlBody.Controls.Add(lblEmail);
            pnlBody.Controls.Add(btnAdd);
            pnlBody.Controls.Add(btnExit);
            pnlBody.Controls.Add(label1);
            pnlBody.Controls.Add(label2);
            pnlBody.Controls.Add(lblPassword);
            pnlBody.Controls.Add(txtRepassword);
            pnlBody.Controls.Add(txtPassword);
            pnlBody.CustomizableEdges = customizableEdges9;
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(3, 50);
            pnlBody.Name = "pnlBody";
            pnlBody.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlBody.Size = new Size(578, 251);
            pnlBody.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(250, 21);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 20);
            lblEmail.TabIndex = 29;
            lblEmail.Text = "label3";
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 5;
            btnAdd.CustomizableEdges = customizableEdges1;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(17, 153, 142);
            btnAdd.FillColor2 = Color.FromArgb(56, 239, 125);
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(84, 192);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Size = new Size(166, 47);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Đổi mật khẩu";
            btnAdd.Click += btnChange_Click;
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
            btnExit.Location = new Point(325, 192);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExit.Size = new Size(166, 47);
            btnExit.TabIndex = 3;
            btnExit.Text = "Đóng";
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 130);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 24;
            label1.Text = "Nhập lại mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(161, 14);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 22;
            label2.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(27, 77);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(199, 28);
            lblPassword.TabIndex = 22;
            lblPassword.Text = "Nhập mật khẩu mới:";
            // 
            // txtRepassword
            // 
            txtRepassword.Animated = true;
            txtRepassword.BorderRadius = 5;
            txtRepassword.BorderThickness = 2;
            txtRepassword.CustomizableEdges = customizableEdges5;
            txtRepassword.DefaultText = "";
            txtRepassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRepassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRepassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRepassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRepassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRepassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRepassword.Location = new Point(232, 124);
            txtRepassword.Margin = new Padding(3, 4, 3, 4);
            txtRepassword.Name = "txtRepassword";
            txtRepassword.PasswordChar = '•';
            txtRepassword.PlaceholderText = "";
            txtRepassword.SelectedText = "";
            txtRepassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtRepassword.Size = new Size(280, 40);
            txtRepassword.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Animated = true;
            txtPassword.BorderRadius = 5;
            txtPassword.BorderThickness = 2;
            txtPassword.CustomizableEdges = customizableEdges7;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(232, 71);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPassword.Size = new Size(280, 40);
            txtPassword.TabIndex = 0;
            // 
            // frmUpdatePassword
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 191, 166);
            ClientSize = new Size(584, 304);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUpdatePassword";
            Padding = new Padding(3);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmChangePassword";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Label lblTitile;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Label label1;
        private Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtRepassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Label lblEmail;
    }
}