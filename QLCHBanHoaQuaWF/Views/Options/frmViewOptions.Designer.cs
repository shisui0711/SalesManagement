namespace QLCHWF.Views.Options
{
    partial class frmViewOptions
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAppInfo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnAppInfo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(992, 500);
            this.pnlMain.TabIndex = 0;
            // 
            // btnAppInfo
            // 
            this.btnAppInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.btnAppInfo.BorderThickness = 2;
            this.btnAppInfo.CustomizableEdges = customizableEdges1;
            this.btnAppInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAppInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAppInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAppInfo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAppInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAppInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.btnAppInfo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.btnAppInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAppInfo.ForeColor = System.Drawing.Color.Black;
            this.btnAppInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnAppInfo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnAppInfo.Image = global::QLCHWF.Properties.Resources.Shop;
            this.btnAppInfo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAppInfo.Location = new System.Drawing.Point(3, 3);
            this.btnAppInfo.Name = "btnAppInfo";
            this.btnAppInfo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnAppInfo.Size = new System.Drawing.Size(225, 100);
            this.btnAppInfo.TabIndex = 0;
            this.btnAppInfo.Text = "Thông tin cửa hàng";
            this.btnAppInfo.Click += new System.EventHandler(this.btnAppInfo_Click);
            // 
            // frmViewOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 500);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewOptions";
            this.Text = "frmViewOptions";
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel pnlMain;
        private Guna.UI2.WinForms.Guna2GradientButton btnAppInfo;
    }
}