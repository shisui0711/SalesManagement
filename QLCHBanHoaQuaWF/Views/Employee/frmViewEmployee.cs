using QLCHWF.CustomMessageBox;

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
        public BindingSource EmployeeBindingSource { get { return employeeBindingSource; } }
        public event EventHandler? LoadEmployee;
        public event EventHandler? RemoveEmployee;
        public event EventHandler? SearchEmployee;
        public event EventHandler? ShowSalesHistory;
        public event EventHandler? ShowImportHistory;
        public event EventHandler ShowSalary;
        public event EventHandler? ShowAddEmployee;
        public event EventHandler? ShowUpdateEmployee;
        public frmViewEmployee()
        {
            InitializeComponent();
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
                catch (Exception e)
                {
                    return 0;
                }
            }
            set { btnCurrentPage.Text = value.ToString(); }
        }
        public event EventHandler PreviousPage;
        public event EventHandler NextPage;
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
