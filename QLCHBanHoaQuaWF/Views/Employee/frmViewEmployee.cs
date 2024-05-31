using QLCHWF.CustomMessageBox;
using System.ComponentModel;
using System.Reflection;

namespace QLCHWF.Views.Employee
{
    public partial class frmViewEmployee : Form, IViewEmployee
    {
        public string SearchText
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public int OptionIndex
        {
            get { return cboOptionSearch.SelectedIndex; }
            set { cboOptionSearch.SelectedIndex = value; }
        }

        public decimal SalaryStart
        {
            get { return txtSalaryStart.Value;}
            set { txtSalaryStart.Value = value; }
        }
        public decimal SalaryEnd
        {
            get { return txtSalaryEnd.Value;}
            set { txtSalaryEnd.Value = value; }
        }
        public BindingSource EmployeeBindingSource { get { return employeeBindingSource; } }
        public event EventHandler? LoadEmployee;
        public event EventHandler? RemoveEmployee;
        public event EventHandler? SearchEmployee;
        public event EventHandler? ShowSalesHistory;
        public event EventHandler? ShowImportHistory;
        public event EventHandler? ShowSalary;
        public event EventHandler? ShowAddEmployee;

        public event EventHandler? ShowUpdateEmployee;
        public frmViewEmployee()
        {
            InitializeComponent();
            LoadCopy();
        }
        private void LoadCopy()
        {
            var properties = typeof(Models.Employee).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.GetCustomAttribute(typeof(DisplayNameAttribute), true) != null);
            foreach (var propertyInfo in properties)
            {
                string? propertyName = (propertyInfo.GetCustomAttribute(typeof(DisplayNameAttribute)) as DisplayNameAttribute)?.DisplayName;
                if (propertyName == null)
                {
                    continue;
                }
                btnCopy.DropDownItems.Add(new ToolStripMenuItem(propertyName));
            }
            foreach (var toolStripMenuItem in btnCopy.DropDownItems.OfType<ToolStripMenuItem>())
            {
                toolStripMenuItem.Click += delegate
                {
                    Models.Employee? selected = employeeBindingSource.Current as Models.Employee;
                    if (selected == null)
                    {
                        return;
                    }
                    var property = selected.GetType().GetProperties().Where(x =>
                    {
                        var displayNameAtribute = x.GetCustomAttribute(typeof(DisplayNameAttribute)) as DisplayNameAttribute;
                        return displayNameAtribute?.DisplayName == toolStripMenuItem.Text;
                    }).FirstOrDefault();
                    if (property != null)
                    {
                        Clipboard.SetText(property.GetValue(selected)!.ToString()!);
                    }

                };
            }
        }
        private void frmViewEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployee?.Invoke(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadEmployee?.Invoke(sender, e);
            txtSearch.Text = String.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchEmployee?.Invoke(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddEmployee?.Invoke(sender, e);
        }

        private void cboOptionSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
            if (cboOptionSearch.SelectedIndex ==  2)
            {
                txtSalaryStart.Visible = true;
                txtSalaryEnd.Visible = true;
            }
            else
            {
                txtSalaryStart.Visible = false;
                txtSalaryEnd.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowUpdateEmployee?.Invoke(sender, e);
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
            ShowSalesHistory?.Invoke(sender, e);
        }

        private void btnImportHistory_Click(object sender, EventArgs e)
        {
            ShowImportHistory?.Invoke(sender, e);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            ShowSalary?.Invoke(sender,e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialogResult = MyMessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            RemoveEmployee?.Invoke(sender,e);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
        public int CurrentPage
        {
            get
            {
                try
                {
                    return int.Parse(btnCurrentPage.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set { btnCurrentPage.Text = value.ToString(); }
        }
        public event EventHandler? PreviousPage;
        public event EventHandler? NextPage;
        public void DisableNextPage()
        {
            btnNext.Enabled = false;
        }

        public void DisablePreviousPage()
        {
            btnPrevious.Enabled = false;
        }

        public void EnablePreviousPage()
        {
            btnPrevious.Enabled = true;
        }

        public void EnableNextPage()
        {
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextPage?.Invoke(sender, e);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PreviousPage?.Invoke(sender, e);
        }
    }
}
