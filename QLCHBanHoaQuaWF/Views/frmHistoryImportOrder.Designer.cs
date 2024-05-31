namespace QLCHWF.Views
{
    partial class frmHistoryImportOrder
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
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            orderIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            providerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            providerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailImportOrdersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            importOrderBindingSource = new BindingSource(components);
            dragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)importOrderBindingSource).BeginInit();
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
            pnlHeader.Size = new Size(979, 50);
            pnlHeader.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 14);
            label4.Name = "label4";
            label4.Size = new Size(190, 23);
            label4.TabIndex = 26;
            label4.Text = "Các đơn hàng đã nhập";
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BorderRadius = 10;
            btnMinimize.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            btnMinimize.CustomizableEdges = customizableEdges1;
            btnMinimize.FillColor = Color.FromArgb(38, 191, 166);
            btnMinimize.HoverState.FillColor = Color.FromArgb(9, 133, 205);
            btnMinimize.IconColor = Color.White;
            btnMinimize.Location = new Point(865, 9);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMinimize.Size = new Size(43, 33);
            btnMinimize.TabIndex = 25;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BorderRadius = 10;
            btnClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            btnClose.CustomizableEdges = customizableEdges3;
            btnClose.FillColor = Color.FromArgb(38, 191, 166);
            btnClose.HoverState.FillColor = Color.Red;
            btnClose.IconColor = Color.White;
            btnClose.Location = new Point(914, 9);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(44, 33);
            btnClose.TabIndex = 24;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(guna2DataGridView1);
            pnlBody.CustomizableEdges = customizableEdges7;
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(3, 53);
            pnlBody.Name = "pnlBody";
            pnlBody.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnlBody.Size = new Size(979, 499);
            pnlBody.TabIndex = 1;
            pnlBody.Paint += guna2Panel1_Paint;
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
            guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.AutoGenerateColumns = false;
            guna2DataGridView1.BackgroundColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 40;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderIDDataGridViewTextBoxColumn, orderDateDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn, employeeDataGridViewTextBoxColumn, providerIDDataGridViewTextBoxColumn, providerDataGridViewTextBoxColumn, detailImportOrdersDataGridViewTextBoxColumn });
            guna2DataGridView1.DataSource = importOrderBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.Dock = DockStyle.Fill;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(0, 0);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 30;
            guna2DataGridView1.Size = new Size(979, 499);
            guna2DataGridView1.TabIndex = 0;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(128, 255, 128);
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(128, 128, 255);
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            guna2DataGridView1.ThemeStyle.BackColor = Color.FromArgb(128, 255, 255);
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            guna2DataGridView1.ThemeStyle.ReadOnly = true;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(128, 255, 128);
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 30;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(128, 128, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            orderIDDataGridViewTextBoxColumn.HeaderText = "Mã đơn hàng";
            orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            orderDateDataGridViewTextBoxColumn.HeaderText = "Ngày đặt";
            orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            employeeDataGridViewTextBoxColumn.HeaderText = "Nhân viên";
            employeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            employeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providerIDDataGridViewTextBoxColumn
            // 
            providerIDDataGridViewTextBoxColumn.DataPropertyName = "ProviderID";
            providerIDDataGridViewTextBoxColumn.HeaderText = "Mã nhà cung cấp";
            providerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            providerIDDataGridViewTextBoxColumn.Name = "providerIDDataGridViewTextBoxColumn";
            providerIDDataGridViewTextBoxColumn.ReadOnly = true;
            providerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // providerDataGridViewTextBoxColumn
            // 
            providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            providerDataGridViewTextBoxColumn.HeaderText = "Nhà cung cấp";
            providerDataGridViewTextBoxColumn.MinimumWidth = 6;
            providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            providerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailImportOrdersDataGridViewTextBoxColumn
            // 
            detailImportOrdersDataGridViewTextBoxColumn.DataPropertyName = "DetailImportOrders";
            detailImportOrdersDataGridViewTextBoxColumn.HeaderText = "DetailImportOrders";
            detailImportOrdersDataGridViewTextBoxColumn.MinimumWidth = 6;
            detailImportOrdersDataGridViewTextBoxColumn.Name = "detailImportOrdersDataGridViewTextBoxColumn";
            detailImportOrdersDataGridViewTextBoxColumn.ReadOnly = true;
            detailImportOrdersDataGridViewTextBoxColumn.Visible = false;
            // 
            // importOrderBindingSource
            // 
            importOrderBindingSource.DataSource = typeof(Models.ImportOrder);
            // 
            // dragControl
            // 
            dragControl.DockIndicatorTransparencyValue = 0.6D;
            dragControl.TargetControl = pnlHeader;
            dragControl.UseTransparentDrag = true;
            // 
            // frmHistoryImportOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 191, 166);
            ClientSize = new Size(985, 555);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistoryImportOrder";
            Padding = new Padding(3);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmHistoryImportOrder";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)importOrderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn providerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn detailImportOrdersDataGridViewTextBoxColumn;
        private BindingSource importOrderBindingSource;
    }
}