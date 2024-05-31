namespace QLCHWF.Views.Product
{
    partial class frmProduct
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlProduct = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ptbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            lblUnitPrice = new Label();
            lblProductName = new Label();
            lblInventory = new Label();
            lbl1 = new Label();
            lblMode = new Label();
            pnlProduct.SuspendLayout();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbProduct).BeginInit();
            SuspendLayout();
            // 
            // pnlProduct
            // 
            pnlProduct.BackColor = Color.White;
            pnlProduct.BorderColor = Color.FromArgb(10, 119, 232);
            pnlProduct.BorderRadius = 10;
            pnlProduct.BorderThickness = 3;
            pnlProduct.Controls.Add(guna2Panel1);
            pnlProduct.Controls.Add(lblUnitPrice);
            pnlProduct.Controls.Add(lblProductName);
            pnlProduct.Controls.Add(lblInventory);
            pnlProduct.Controls.Add(lbl1);
            pnlProduct.Controls.Add(lblMode);
            pnlProduct.CustomizableEdges = customizableEdges11;
            pnlProduct.Dock = DockStyle.Fill;
            pnlProduct.FillColor = Color.FromArgb(0, 146, 69);
            pnlProduct.FillColor2 = Color.FromArgb(252, 238, 33);
            pnlProduct.Location = new Point(0, 0);
            pnlProduct.Name = "pnlProduct";
            pnlProduct.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pnlProduct.Size = new Size(254, 248);
            pnlProduct.TabIndex = 0;
            pnlProduct.Click += pnlProduct_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(10, 119, 232);
            guna2Panel1.BorderColor = Color.FromArgb(10, 119, 232);
            guna2Panel1.BorderRadius = 10;
            guna2Panel1.BorderThickness = 3;
            guna2Panel1.Controls.Add(ptbProduct);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.Location = new Point(25, 26);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Padding = new Padding(3);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(205, 125);
            guna2Panel1.TabIndex = 12;
            // 
            // ptbProduct
            // 
            ptbProduct.BorderRadius = 5;
            ptbProduct.CustomizableEdges = customizableEdges7;
            ptbProduct.Dock = DockStyle.Fill;
            ptbProduct.ImageRotate = 0F;
            ptbProduct.Location = new Point(3, 3);
            ptbProduct.Name = "ptbProduct";
            ptbProduct.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ptbProduct.Size = new Size(199, 119);
            ptbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbProduct.TabIndex = 0;
            ptbProduct.TabStop = false;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.BackColor = Color.Transparent;
            lblUnitPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUnitPrice.ForeColor = Color.FromArgb(224, 79, 95);
            lblUnitPrice.Location = new Point(84, 195);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(17, 20);
            lblUnitPrice.TabIndex = 11;
            lblUnitPrice.Text = "0";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductName.ForeColor = Color.White;
            lblProductName.Location = new Point(21, 167);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(92, 17);
            lblProductName.TabIndex = 10;
            lblProductName.Text = "ProductName";
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.BackColor = Color.Transparent;
            lblInventory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInventory.ForeColor = Color.FromArgb(224, 79, 95);
            lblInventory.Location = new Point(96, 219);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(17, 20);
            lblInventory.TabIndex = 9;
            lblInventory.Text = "0";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.White;
            lbl1.Location = new Point(21, 219);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(69, 20);
            lbl1.TabIndex = 8;
            lbl1.Text = "Tồn kho:";
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.BackColor = Color.Transparent;
            lblMode.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblMode.ForeColor = Color.White;
            lblMode.Location = new Point(21, 198);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(57, 17);
            lblMode.TabIndex = 7;
            lblMode.Text = "Giá bán:";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(254, 248);
            Controls.Add(pnlProduct);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProduct";
            ShowInTaskbar = false;
            Text = "frmTest";
            pnlProduct.ResumeLayout(false);
            pnlProduct.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlProduct;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox ptbProduct;
        private Label lblUnitPrice;
        private Label lblProductName;
        private Label lblInventory;
        private Label lbl1;
        private Label lblMode;
    }
}