using QLCHWF.CustomMessageBox;
using QLCHWF.Presenters;

namespace QLCHWF.Views.SalesOrder
{
    public partial class frmViewSalesOrder : Form, IViewSalesOrder
    {
        public frmViewSalesOrder()
        {
            InitializeComponent();
        }

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

        public DateTime DateStart
        {
            get
            {
                switch (cboDateCreated.SelectedIndex)
                {
                    case 1:
                        return DateTime.Today;
                    case 2:
                        return DateTime.Today.AddDays(-1);
                    case 3:
                        return DateTime.Now.AddDays(-14);
                    case 4:
                        return DateTime.Today.AddDays(-7);
                    case 5:
                        return DateTime.Today.AddMonths(-1);
                    case 6:
                        return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
                    case 7:
                        return dtpStart.Value;
                    default:
                        return DateTime.MinValue;
                }
            }
        }

        public DateTime DateEnd
        {
            get
            {
                switch (cboDateCreated.SelectedIndex)
                {
                    case 2:
                        return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0).AddSeconds(-1);
                    case 7:
                        return dtpEnd.Value;
                    default:
                        return DateTime.Now;
                }
            }
        }

        public BindingSource OrderBindingSource
        {
            get { return salesOrderBindingSource; }
        }
        public event EventHandler? LoadSalesOrder;
        public event EventHandler? RemoveSalesOrder;
        public event EventHandler? SearchSalesOrder;
        public event EventHandler? ShowAdd;
        public event EventHandler? ShowReport;
        public event EventHandler ShowDetail;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAdd?.Invoke(sender, e);
        }

        private void cboDateCreated_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDateCreated.SelectedIndex == 7)
            {
                dtpStart.Visible = true;
                dtpEnd.Visible = true;
            }
            else
            {
                dtpStart.Visible = false;
                dtpEnd.Visible = false;
                SearchSalesOrder?.Invoke(sender,e);
            }
        }

        private void frmViewSalesOrder_Load(object sender, EventArgs e)
        {
            LoadSalesOrder?.Invoke(sender, e);
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            if (AuthPresenter.User != null)
            {
                if (AuthPresenter.User.UserRole.Permission.CanExportSalesOrder == false)
                {
                    MyMessageBox.Show(@"Bạn không có quyền này");
                    return;
                }
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save an Excel File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dgvSalesOrder.ExportToExcel(saveFileDialog.FileName);
                    MyMessageBox.Show(@"Xuất thành công!");
                }
                catch (Exception exception)
                {
                    MyMessageBox.Show($"Lỗi: {exception.Message}");
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadSalesOrder?.Invoke(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchSalesOrder?.Invoke(sender, e);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowReport?.Invoke(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var dialogResult = MyMessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            RemoveSalesOrder?.Invoke(sender,e);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            ShowDetail?.Invoke(sender,e);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
