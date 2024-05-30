namespace QLCHWF.Views.Employee
{
    partial class frmViewSalary
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            lblTitle = new Label();
            btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            pnlBody = new Guna.UI2.WinForms.Guna2Panel();
            pnlGridView = new Guna.UI2.WinForms.Guna2Panel();
            dgvSalary = new Guna.UI2.WinForms.Guna2DataGridView();
            employeeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalWorkedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            finalSalaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryTableBindingSource = new BindingSource(components);
            pnlControl = new Guna.UI2.WinForms.Guna2Panel();
            btnExportFile = new Guna.UI2.WinForms.Guna2GradientButton();
            btnCalculate = new Guna.UI2.WinForms.Guna2GradientButton();
            dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salaryTableBindingSource).BeginInit();
            pnlControl.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(38, 191, 166);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.CustomizableEdges = customizableEdges3;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlHeader.Size = new Size(929, 54);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(104, 23);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "Bảng lương";
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
            btnClose.Location = new Point(873, 11);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(44, 33);
            btnClose.TabIndex = 13;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(pnlGridView);
            pnlBody.Controls.Add(pnlControl);
            pnlBody.CustomizableEdges = customizableEdges17;
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(3, 57);
            pnlBody.Name = "pnlBody";
            pnlBody.ShadowDecoration.CustomizableEdges = customizableEdges18;
            pnlBody.Size = new Size(929, 473);
            pnlBody.TabIndex = 1;
            // 
            // pnlGridView
            // 
            pnlGridView.Controls.Add(dgvSalary);
            pnlGridView.CustomizableEdges = customizableEdges5;
            pnlGridView.Dock = DockStyle.Fill;
            pnlGridView.Location = new Point(0, 91);
            pnlGridView.Name = "pnlGridView";
            pnlGridView.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlGridView.Size = new Size(929, 382);
            pnlGridView.TabIndex = 1;
            // 
            // dgvSalary
            // 
            dgvSalary.AllowUserToAddRows = false;
            dgvSalary.AllowUserToDeleteRows = false;
            dgvSalary.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvSalary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSalary.AutoGenerateColumns = false;
            dgvSalary.BackgroundColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSalary.ColumnHeadersHeight = 40;
            dgvSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSalary.Columns.AddRange(new DataGridViewColumn[] { employeeIDDataGridViewTextBoxColumn, employeeNameDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn, totalWorkedDataGridViewTextBoxColumn, finalSalaryDataGridViewTextBoxColumn });
            dgvSalary.DataSource = salaryTableBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSalary.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSalary.Dock = DockStyle.Fill;
            dgvSalary.GridColor = Color.FromArgb(231, 229, 255);
            dgvSalary.Location = new Point(0, 0);
            dgvSalary.Name = "dgvSalary";
            dgvSalary.ReadOnly = true;
            dgvSalary.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvSalary.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSalary.RowHeadersVisible = false;
            dgvSalary.RowHeadersWidth = 51;
            dgvSalary.RowTemplate.Height = 30;
            dgvSalary.Size = new Size(929, 382);
            dgvSalary.TabIndex = 0;
            dgvSalary.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvSalary.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvSalary.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvSalary.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvSalary.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvSalary.ThemeStyle.BackColor = Color.FromArgb(128, 255, 255);
            dgvSalary.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvSalary.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvSalary.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSalary.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvSalary.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvSalary.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSalary.ThemeStyle.HeaderStyle.Height = 40;
            dgvSalary.ThemeStyle.ReadOnly = true;
            dgvSalary.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvSalary.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSalary.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvSalary.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvSalary.ThemeStyle.RowsStyle.Height = 30;
            dgvSalary.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvSalary.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            employeeIDDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            employeeNameDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            employeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            salaryDataGridViewTextBoxColumn.HeaderText = "Lương cơ bản";
            salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalWorkedDataGridViewTextBoxColumn
            // 
            totalWorkedDataGridViewTextBoxColumn.DataPropertyName = "TotalWorked";
            totalWorkedDataGridViewTextBoxColumn.HeaderText = "Số đơn đã làm";
            totalWorkedDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalWorkedDataGridViewTextBoxColumn.Name = "totalWorkedDataGridViewTextBoxColumn";
            totalWorkedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalSalaryDataGridViewTextBoxColumn
            // 
            finalSalaryDataGridViewTextBoxColumn.DataPropertyName = "FinalSalary";
            finalSalaryDataGridViewTextBoxColumn.HeaderText = "Lương cứng";
            finalSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            finalSalaryDataGridViewTextBoxColumn.Name = "finalSalaryDataGridViewTextBoxColumn";
            finalSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryTableBindingSource
            // 
            salaryTableBindingSource.DataSource = typeof(Models.SalaryTable);
            // 
            // pnlControl
            // 
            pnlControl.BackColor = Color.White;
            pnlControl.Controls.Add(btnExportFile);
            pnlControl.Controls.Add(btnCalculate);
            pnlControl.Controls.Add(dtpEnd);
            pnlControl.Controls.Add(dtpStart);
            pnlControl.CustomizableEdges = customizableEdges15;
            pnlControl.Dock = DockStyle.Top;
            pnlControl.Location = new Point(0, 0);
            pnlControl.Name = "pnlControl";
            pnlControl.ShadowDecoration.CustomizableEdges = customizableEdges16;
            pnlControl.Size = new Size(929, 91);
            pnlControl.TabIndex = 0;
            // 
            // btnExportFile
            // 
            btnExportFile.BorderRadius = 5;
            btnExportFile.CustomizableEdges = customizableEdges7;
            btnExportFile.DisabledState.BorderColor = Color.DarkGray;
            btnExportFile.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExportFile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExportFile.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnExportFile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExportFile.FillColor = Color.FromArgb(17, 153, 142);
            btnExportFile.FillColor2 = Color.FromArgb(56, 239, 125);
            btnExportFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportFile.ForeColor = Color.White;
            btnExportFile.Location = new Point(492, 19);
            btnExportFile.Name = "btnExportFile";
            btnExportFile.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnExportFile.Size = new Size(166, 47);
            btnExportFile.TabIndex = 22;
            btnExportFile.Text = "Xuất file";
            btnExportFile.Click += btnExportFile_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BorderRadius = 5;
            btnCalculate.CustomizableEdges = customizableEdges9;
            btnCalculate.DisabledState.BorderColor = Color.DarkGray;
            btnCalculate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCalculate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCalculate.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnCalculate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCalculate.FillColor = Color.FromArgb(17, 153, 142);
            btnCalculate.FillColor2 = Color.FromArgb(56, 239, 125);
            btnCalculate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(308, 19);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCalculate.Size = new Size(166, 47);
            btnCalculate.TabIndex = 22;
            btnCalculate.Text = "Tính Lương";
            btnCalculate.Click += btnCaculate_Click;
            // 
            // dtpEnd
            // 
            dtpEnd.Animated = true;
            dtpEnd.BorderRadius = 5;
            dtpEnd.Checked = true;
            dtpEnd.CustomFormat = "dd-MM-yyyy";
            dtpEnd.CustomizableEdges = customizableEdges11;
            dtpEnd.FillColor = Color.Cyan;
            dtpEnd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(159, 19);
            dtpEnd.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpEnd.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.ShadowDecoration.CustomizableEdges = customizableEdges12;
            dtpEnd.Size = new Size(129, 47);
            dtpEnd.TabIndex = 9;
            dtpEnd.Value = new DateTime(2023, 11, 25, 22, 33, 5, 877);
            // 
            // dtpStart
            // 
            dtpStart.Animated = true;
            dtpStart.BorderRadius = 5;
            dtpStart.Checked = true;
            dtpStart.CustomFormat = "dd-MM-yyyy";
            dtpStart.CustomizableEdges = customizableEdges13;
            dtpStart.FillColor = Color.Cyan;
            dtpStart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(25, 19);
            dtpStart.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpStart.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpStart.Name = "dtpStart";
            dtpStart.ShadowDecoration.CustomizableEdges = customizableEdges14;
            dtpStart.Size = new Size(128, 47);
            dtpStart.TabIndex = 8;
            dtpStart.Value = new DateTime(2023, 11, 25, 22, 33, 5, 877);
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = pnlHeader;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmViewSalary
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 191, 166);
            ClientSize = new Size(935, 533);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmViewSalary";
            Padding = new Padding(3);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmSalary";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)salaryTableBindingSource).EndInit();
            pnlControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlBody;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlGridView;
        private Guna.UI2.WinForms.Guna2Panel pnlControl;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSalary;

        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalWorkedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finalSalaryDataGridViewTextBoxColumn;
        private BindingSource salaryTableBindingSource;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientButton btnExportFile;
        private Guna.UI2.WinForms.Guna2GradientButton btnCalculate;
    }
}