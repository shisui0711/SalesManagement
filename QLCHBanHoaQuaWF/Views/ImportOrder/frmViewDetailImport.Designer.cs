namespace QLCHWF.Views.ImportOrder
{
    partial class frmViewDetailImport
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            label4 = new Label();
            btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            pnlBody = new Guna.UI2.WinForms.Guna2Panel();
            dgvDetailImport = new Guna.UI2.WinForms.Guna2DataGridView();
            orderIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            importOrderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailImportOrderBindingSource = new BindingSource(components);
            dragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailImport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailImportOrderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(38, 191, 166);
            pnlHeader.Controls.Add(label4);
            pnlHeader.Controls.Add(btnMinimize);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.CustomizableEdges = customizableEdges5;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlHeader.Size = new Size(956, 55);
            pnlHeader.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(196, 23);
            label4.TabIndex = 23;
            label4.Text = "Chi tiết đơn hàng nhập";
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BorderRadius = 10;
            btnMinimize.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            btnMinimize.CustomizableEdges = customizableEdges1;
            btnMinimize.FillColor = Color.Transparent;
            btnMinimize.HoverState.FillColor = Color.FromArgb(9, 133, 205);
            btnMinimize.IconColor = Color.White;
            btnMinimize.Location = new Point(857, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMinimize.Size = new Size(43, 33);
            btnMinimize.TabIndex = 22;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BorderRadius = 10;
            btnClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            btnClose.CustomizableEdges = customizableEdges3;
            btnClose.FillColor = Color.Transparent;
            btnClose.HoverState.FillColor = Color.Red;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(906, 12);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(44, 33);
            btnClose.TabIndex = 21;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(dgvDetailImport);
            pnlBody.CustomizableEdges = customizableEdges7;
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(3, 58);
            pnlBody.Name = "pnlBody";
            pnlBody.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnlBody.Size = new Size(956, 451);
            pnlBody.TabIndex = 1;
            // 
            // dgvDetailImport
            // 
            dgvDetailImport.AllowUserToAddRows = false;
            dgvDetailImport.AllowUserToDeleteRows = false;
            dgvDetailImport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvDetailImport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetailImport.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDetailImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetailImport.ColumnHeadersHeight = 40;
            dgvDetailImport.Columns.AddRange(new DataGridViewColumn[] { orderIDDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn, productDataGridViewTextBoxColumn, importOrderDataGridViewTextBoxColumn });
            dgvDetailImport.DataSource = detailImportOrderBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDetailImport.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDetailImport.Dock = DockStyle.Fill;
            dgvDetailImport.GridColor = Color.FromArgb(231, 229, 255);
            dgvDetailImport.Location = new Point(0, 0);
            dgvDetailImport.Name = "dgvDetailImport";
            dgvDetailImport.ReadOnly = true;
            dgvDetailImport.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDetailImport.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDetailImport.RowHeadersVisible = false;
            dgvDetailImport.RowHeadersWidth = 51;
            dgvDetailImport.RowTemplate.Height = 30;
            dgvDetailImport.Size = new Size(956, 451);
            dgvDetailImport.TabIndex = 0;
            dgvDetailImport.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDetailImport.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDetailImport.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDetailImport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDetailImport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDetailImport.ThemeStyle.BackColor = Color.White;
            dgvDetailImport.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvDetailImport.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDetailImport.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDetailImport.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDetailImport.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDetailImport.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetailImport.ThemeStyle.HeaderStyle.Height = 40;
            dgvDetailImport.ThemeStyle.ReadOnly = true;
            dgvDetailImport.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDetailImport.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetailImport.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDetailImport.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDetailImport.ThemeStyle.RowsStyle.Height = 30;
            dgvDetailImport.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvDetailImport.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            orderIDDataGridViewTextBoxColumn.HeaderText = "Mã đơn hàng";
            orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            productDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            productDataGridViewTextBoxColumn.MinimumWidth = 6;
            productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importOrderDataGridViewTextBoxColumn
            // 
            importOrderDataGridViewTextBoxColumn.DataPropertyName = "ImportOrder";
            importOrderDataGridViewTextBoxColumn.HeaderText = "ImportOrder";
            importOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            importOrderDataGridViewTextBoxColumn.Name = "importOrderDataGridViewTextBoxColumn";
            importOrderDataGridViewTextBoxColumn.ReadOnly = true;
            importOrderDataGridViewTextBoxColumn.Visible = false;
            // 
            // detailImportOrderBindingSource
            // 
            detailImportOrderBindingSource.DataSource = typeof(Models.DetailImportOrder);
            // 
            // dragControl
            // 
            dragControl.DockIndicatorTransparencyValue = 0.6D;
            dragControl.TargetControl = pnlHeader;
            dragControl.UseTransparentDrag = true;
            // 
            // frmViewDetailImport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 191, 166);
            ClientSize = new Size(962, 512);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmViewDetailImport";
            Padding = new Padding(3);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmViewDetailImport";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetailImport).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailImportOrderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetailImport;
        private BindingSource detailImportOrderBindingSource;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importOrderDataGridViewTextBoxColumn;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
    }
}