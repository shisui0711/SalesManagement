namespace QLCHWF.Views.UserRole
{
    partial class frmViewUserRole
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlControl = new Guna.UI2.WinForms.Guna2Panel();
            btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            btnReload = new Guna.UI2.WinForms.Guna2GradientButton();
            btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            pnlGridView = new Guna.UI2.WinForms.Guna2Panel();
            dgvUserRole = new Guna.UI2.WinForms.Guna2DataGridView();
            roleIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateCreatedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            permissionIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            permissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            btnUpdate = new ToolStripMenuItem();
            btnRemove = new ToolStripMenuItem();
            userRoleBindingSource = new BindingSource(components);
            pnlControl.SuspendLayout();
            pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserRole).BeginInit();
            contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userRoleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnlControl
            // 
            pnlControl.Controls.Add(btnAdd);
            pnlControl.Controls.Add(btnReload);
            pnlControl.Controls.Add(btnSearch);
            pnlControl.Controls.Add(txtSearch);
            pnlControl.CustomizableEdges = customizableEdges9;
            pnlControl.Dock = DockStyle.Top;
            pnlControl.Location = new Point(0, 0);
            pnlControl.Name = "pnlControl";
            pnlControl.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlControl.Size = new Size(1301, 72);
            pnlControl.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Animated = true;
            btnAdd.BorderRadius = 5;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.CustomizableEdges = customizableEdges1;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(46, 49, 146);
            btnAdd.FillColor2 = Color.FromArgb(27, 255, 255);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1118, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Size = new Size(171, 35);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReload
            // 
            btnReload.Animated = true;
            btnReload.BorderRadius = 5;
            btnReload.Cursor = Cursors.Hand;
            btnReload.CustomizableEdges = customizableEdges3;
            btnReload.DisabledState.BorderColor = Color.DarkGray;
            btnReload.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReload.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReload.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnReload.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReload.FillColor = Color.FromArgb(46, 49, 146);
            btnReload.FillColor2 = Color.FromArgb(27, 255, 255);
            btnReload.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReload.ForeColor = Color.White;
            btnReload.Image = Properties.Resources.reload;
            btnReload.Location = new Point(351, 19);
            btnReload.Name = "btnReload";
            btnReload.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnReload.Size = new Size(41, 35);
            btnReload.TabIndex = 19;
            btnReload.Click += btnReload_Click;
            // 
            // btnSearch
            // 
            btnSearch.Animated = true;
            btnSearch.BorderRadius = 5;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.CustomizableEdges = customizableEdges5;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.FromArgb(46, 49, 146);
            btnSearch.FillColor2 = Color.FromArgb(27, 255, 255);
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Properties.Resources._3d_magnifier;
            btnSearch.Location = new Point(304, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSearch.Size = new Size(41, 35);
            btnSearch.TabIndex = 20;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Animated = true;
            txtSearch.BorderRadius = 5;
            txtSearch.CustomizableEdges = customizableEdges7;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(12, 19);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Tìm kiếm theo tên";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSearch.Size = new Size(286, 35);
            txtSearch.TabIndex = 14;
            // 
            // pnlGridView
            // 
            pnlGridView.Controls.Add(dgvUserRole);
            pnlGridView.CustomizableEdges = customizableEdges11;
            pnlGridView.Dock = DockStyle.Fill;
            pnlGridView.Location = new Point(0, 72);
            pnlGridView.Name = "pnlGridView";
            pnlGridView.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pnlGridView.Size = new Size(1301, 672);
            pnlGridView.TabIndex = 1;
            // 
            // dgvUserRole
            // 
            dgvUserRole.AllowUserToAddRows = false;
            dgvUserRole.AllowUserToDeleteRows = false;
            dgvUserRole.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvUserRole.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUserRole.AutoGenerateColumns = false;
            dgvUserRole.BackgroundColor = Color.Aqua;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUserRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUserRole.ColumnHeadersHeight = 40;
            dgvUserRole.Columns.AddRange(new DataGridViewColumn[] { roleIDDataGridViewTextBoxColumn, roleNameDataGridViewTextBoxColumn, dateCreatedDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, permissionIDDataGridViewTextBoxColumn, permissionDataGridViewTextBoxColumn });
            dgvUserRole.ContextMenuStrip = contextMenuStrip;
            dgvUserRole.DataSource = userRoleBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUserRole.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUserRole.Dock = DockStyle.Fill;
            dgvUserRole.GridColor = Color.FromArgb(231, 229, 255);
            dgvUserRole.Location = new Point(0, 0);
            dgvUserRole.Name = "dgvUserRole";
            dgvUserRole.ReadOnly = true;
            dgvUserRole.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUserRole.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUserRole.RowHeadersVisible = false;
            dgvUserRole.RowHeadersWidth = 51;
            dgvUserRole.RowTemplate.Height = 30;
            dgvUserRole.Size = new Size(1301, 672);
            dgvUserRole.TabIndex = 0;
            dgvUserRole.ThemeStyle.AlternatingRowsStyle.BackColor = Color.Lime;
            dgvUserRole.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvUserRole.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            dgvUserRole.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvUserRole.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            dgvUserRole.ThemeStyle.BackColor = Color.Aqua;
            dgvUserRole.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvUserRole.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvUserRole.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUserRole.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dgvUserRole.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUserRole.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUserRole.ThemeStyle.HeaderStyle.Height = 40;
            dgvUserRole.ThemeStyle.ReadOnly = true;
            dgvUserRole.ThemeStyle.RowsStyle.BackColor = Color.Lime;
            dgvUserRole.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUserRole.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvUserRole.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvUserRole.ThemeStyle.RowsStyle.Height = 30;
            dgvUserRole.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvUserRole.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // roleIDDataGridViewTextBoxColumn
            // 
            roleIDDataGridViewTextBoxColumn.DataPropertyName = "RoleID";
            roleIDDataGridViewTextBoxColumn.HeaderText = "Mã vai trò";
            roleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
            roleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            roleNameDataGridViewTextBoxColumn.HeaderText = "Tên vai trò";
            roleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            roleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            dateCreatedDataGridViewTextBoxColumn.HeaderText = "Ngày tạo";
            dateCreatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permissionIDDataGridViewTextBoxColumn
            // 
            permissionIDDataGridViewTextBoxColumn.DataPropertyName = "PermissionID";
            permissionIDDataGridViewTextBoxColumn.HeaderText = "PermissionID";
            permissionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            permissionIDDataGridViewTextBoxColumn.Name = "permissionIDDataGridViewTextBoxColumn";
            permissionIDDataGridViewTextBoxColumn.ReadOnly = true;
            permissionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // permissionDataGridViewTextBoxColumn
            // 
            permissionDataGridViewTextBoxColumn.DataPropertyName = "Permission";
            permissionDataGridViewTextBoxColumn.HeaderText = "Permission";
            permissionDataGridViewTextBoxColumn.MinimumWidth = 6;
            permissionDataGridViewTextBoxColumn.Name = "permissionDataGridViewTextBoxColumn";
            permissionDataGridViewTextBoxColumn.ReadOnly = true;
            permissionDataGridViewTextBoxColumn.Visible = false;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { btnUpdate, btnRemove });
            contextMenuStrip.Name = "guna2ContextMenuStrip1";
            contextMenuStrip.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            contextMenuStrip.RenderStyle.BorderColor = Color.Gainsboro;
            contextMenuStrip.RenderStyle.ColorTable = null;
            contextMenuStrip.RenderStyle.RoundedEdges = true;
            contextMenuStrip.RenderStyle.SelectionArrowColor = Color.White;
            contextMenuStrip.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            contextMenuStrip.RenderStyle.SelectionForeColor = Color.White;
            contextMenuStrip.RenderStyle.SeparatorColor = Color.Gainsboro;
            contextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            contextMenuStrip.Size = new Size(109, 56);
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.pencil;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 26);
            btnUpdate.Text = "Sửa";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Image = Properties.Resources.remove;
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(108, 26);
            btnRemove.Text = "Xóa";
            btnRemove.Click += btnRemove_Click;
            // 
            // userRoleBindingSource
            // 
            userRoleBindingSource.DataSource = typeof(Models.UserRole);
            // 
            // frmViewUserRole
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 744);
            Controls.Add(pnlGridView);
            Controls.Add(pnlControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmViewUserRole";
            Text = "frmViewUserRole";
            Load += frmViewUserRole_Load;
            pnlControl.ResumeLayout(false);
            pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserRole).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userRoleBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlControl;
        private Guna.UI2.WinForms.Guna2Panel pnlGridView;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUserRole;
        private DataGridViewTextBoxColumn roleIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn permissionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn permissionDataGridViewTextBoxColumn;
        private BindingSource userRoleBindingSource;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem btnUpdate;
        private ToolStripMenuItem btnRemove;
        private Guna.UI2.WinForms.Guna2GradientButton btnReload;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
    }
}