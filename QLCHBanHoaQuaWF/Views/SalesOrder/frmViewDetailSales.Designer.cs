namespace QLCHWF.Views.SalesOrder
{
    partial class frmViewDetailSales
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
            dgvDetailSales = new Guna.UI2.WinForms.Guna2DataGridView();
            orderIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salesOrderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailSalesOrderBindingSource = new BindingSource(components);
            dragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailSalesOrderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(38, 191, 166);
            pnlHeader.BorderColor = Color.DimGray;
            pnlHeader.Controls.Add(label4);
            pnlHeader.Controls.Add(btnMinimize);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.CustomizableEdges = customizableEdges5;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlHeader.Size = new Size(1087, 55);
            pnlHeader.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 16);
            label4.Name = "label4";
            label4.Size = new Size(186, 23);
            label4.TabIndex = 24;
            label4.Text = "Chi tiết đơn hàng bán";
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
            btnMinimize.Location = new Point(991, 11);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMinimize.Size = new Size(43, 33);
            btnMinimize.TabIndex = 20;
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
            btnClose.Location = new Point(1040, 11);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(44, 33);
            btnClose.TabIndex = 19;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(dgvDetailSales);
            pnlBody.CustomizableEdges = customizableEdges7;
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(3, 58);
            pnlBody.Name = "pnlBody";
            pnlBody.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnlBody.Size = new Size(1087, 451);
            pnlBody.TabIndex = 1;
            // 
            // dgvDetailSales
            // 
            dgvDetailSales.AllowUserToAddRows = false;
            dgvDetailSales.AllowUserToDeleteRows = false;
            dgvDetailSales.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvDetailSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetailSales.AutoGenerateColumns = false;
            dgvDetailSales.BackgroundColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDetailSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetailSales.ColumnHeadersHeight = 42;
            dgvDetailSales.Columns.AddRange(new DataGridViewColumn[] { orderIDDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn, productDataGridViewTextBoxColumn, salesOrderDataGridViewTextBoxColumn });
            dgvDetailSales.DataSource = detailSalesOrderBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDetailSales.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDetailSales.Dock = DockStyle.Fill;
            dgvDetailSales.GridColor = Color.FromArgb(231, 229, 255);
            dgvDetailSales.Location = new Point(0, 0);
            dgvDetailSales.Name = "dgvDetailSales";
            dgvDetailSales.ReadOnly = true;
            dgvDetailSales.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDetailSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDetailSales.RowHeadersVisible = false;
            dgvDetailSales.RowHeadersWidth = 51;
            dgvDetailSales.RowTemplate.Height = 30;
            dgvDetailSales.Size = new Size(1087, 451);
            dgvDetailSales.TabIndex = 0;
            dgvDetailSales.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDetailSales.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDetailSales.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDetailSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDetailSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDetailSales.ThemeStyle.BackColor = Color.FromArgb(128, 255, 255);
            dgvDetailSales.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvDetailSales.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDetailSales.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDetailSales.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDetailSales.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDetailSales.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetailSales.ThemeStyle.HeaderStyle.Height = 42;
            dgvDetailSales.ThemeStyle.ReadOnly = true;
            dgvDetailSales.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDetailSales.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetailSales.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvDetailSales.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDetailSales.ThemeStyle.RowsStyle.Height = 30;
            dgvDetailSales.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvDetailSales.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            // salesOrderDataGridViewTextBoxColumn
            // 
            salesOrderDataGridViewTextBoxColumn.DataPropertyName = "SalesOrder";
            salesOrderDataGridViewTextBoxColumn.HeaderText = "SalesOrder";
            salesOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            salesOrderDataGridViewTextBoxColumn.Name = "salesOrderDataGridViewTextBoxColumn";
            salesOrderDataGridViewTextBoxColumn.ReadOnly = true;
            salesOrderDataGridViewTextBoxColumn.Visible = false;
            // 
            // detailSalesOrderBindingSource
            // 
            detailSalesOrderBindingSource.DataSource = typeof(Models.DetailSalesOrder);
            // 
            // dragControl
            // 
            dragControl.DockIndicatorTransparencyValue = 0.6D;
            dragControl.TargetControl = pnlHeader;
            dragControl.UseTransparentDrag = true;
            // 
            // frmViewDetailSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 191, 166);
            ClientSize = new Size(1093, 512);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmViewDetailSales";
            Padding = new Padding(3);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmViewDetailSales";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetailSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailSalesOrderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetailSales;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private BindingSource detailSalesOrderBindingSource;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salesOrderDataGridViewTextBoxColumn;
    }
}