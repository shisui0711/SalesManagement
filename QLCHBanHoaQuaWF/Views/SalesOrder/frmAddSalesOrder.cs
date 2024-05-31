using System.Globalization;
using Guna.UI2.WinForms;
using QLCHWF.CustomMessageBox;
using QLCHWF.Presenters;
using System.Text.RegularExpressions;

namespace QLCHWF.Views.SalesOrder
{
    public partial class frmAddSalesOrder : Form, IAddSalesOrder
    {
        private int _quantityBackup;
        public frmAddSalesOrder()
        {
            InitializeComponent();
        }

        private void frmAddSalesOrder_Resize(object sender, EventArgs e)
        {
            pnlBodyLeft.Width = this.Width * 2 / 5;
        }

        public string CustomerSearchText
        {
            get { return txtCustomerSearch.Text; }
            set { txtCustomerSearch.Text = value; }
        }
        public string ProductSearchText
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public decimal PurchasePrice
        {
            get
            {
                decimal.TryParse(txtPurchasePrice.Text,out var purchasePrice);
                return purchasePrice;
            }
            set { txtPurchasePrice.Text = value.ToString(); }
        }
        public decimal ChangePrice
        {
            get { return decimal.Parse(lblChangePrice.Text,NumberStyles.Currency); }
            set { lblChangePrice.Text = value.ToString("C2"); }
        }

        public decimal TotalPrice
        {
            get { try
                {
                    return decimal.Parse(lblTotalPrice.Text,NumberStyles.Currency);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set { lblTotalPrice.Text = value.ToString("C2"); }
        }

        public int? EmployeeID
        {
            get
            {
                if (AuthPresenter.User != null && AuthPresenter.User.EmployeeID != 0) return AuthPresenter.User.EmployeeID;
                return null;
            }
        }
        public int? CustomerID
        {
            get { try
                {
                    return int.Parse(dgvCustomer.CurrentRow?.Cells[0].Value.ToString() ?? string.Empty);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public BindingSource CustomerBindingSource
        {
            get { return customerBindingSource; }
        }

        public DataGridView OrderedGridView
        {
            get { return dgvProductSelect; }
            set { dgvProductSelect = value as Guna2DataGridView; }
        }

        public event EventHandler<DataGridViewCellEventArgs>? RemoveProduct;

        public void AddControl(Control control)
        {
            pnlProduct.Controls.Add(control);
        }

        public void ClearControl()
        {
            pnlProduct.Controls.Clear();
        }

        public event EventHandler? LoadProduct;
        public event EventHandler? LoadCustomer;
        public event EventHandler? SearchCustomer;
        public event EventHandler? SearchProduct;
        public event EventHandler? AddSalesOrder;

        private void frmAddSalesOrder_Load(object sender, EventArgs e)
        {
            LoadCustomer?.Invoke(sender, e);
            LoadProduct?.Invoke(sender, e);
        }

        private void dgvProductSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductSelect.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvProductSelect.ColumnCount - 3)
                {
                    var cells = dgvProductSelect.Rows[e.RowIndex].Cells;
                    var quantity = int.Parse(cells["QuantityColumn"].Value.ToString()!);
                    if (quantity > 1)
                    {
                        cells["QuantityColumn"].Value = quantity - 1;
                        cells["TotalPriceColumn"].Value = decimal.Parse(cells["UnitPriceColumn"].Value.ToString()!) * (quantity - 1);
                    }
                }
                if (e.ColumnIndex == dgvProductSelect.ColumnCount - 2)
                {
                    var cells = dgvProductSelect.Rows[e.RowIndex].Cells;
                    cells["QuantityColumn"].Value = int.Parse(cells["QuantityColumn"].Value.ToString()!) + 1;
                    cells["TotalPriceColumn"].Value = decimal.Parse(cells["UnitPriceColumn"].Value.ToString()!) * int.Parse(cells["QuantityColumn"].Value.ToString()!);
                }



                if (e.ColumnIndex == dgvProductSelect.ColumnCount - 1)
                {
                    RemoveProduct?.Invoke(sender, e);
                }
            }
        }

        private void dgvProductSelect_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string? cellValue = dgvProductSelect.Rows[e.RowIndex].Cells["QuantityColumn"].Value.ToString();
            if (cellValue == null)
            {
                return;
            }
            if (!Regex.IsMatch(cellValue, @"\d+") || int.Parse(cellValue) < 1)
            {
                dgvProductSelect.Rows[e.RowIndex].Cells["QuantityColumn"].Value = _quantityBackup;
                MyMessageBox.Show("Số lượng không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var rowSeleted = dgvProductSelect.Rows[e.RowIndex];
            var unitPrice = decimal.Parse(rowSeleted.Cells["UnitPriceColumn"].Value.ToString()!);
            var quantity = decimal.Parse(rowSeleted.Cells["QuantityColumn"].Value.ToString()!);
            rowSeleted.Cells["TotalPriceColumn"].Value = unitPrice * quantity;
        }

        private void dgvProductSelect_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _quantityBackup = int.Parse(dgvProductSelect.Rows[e.RowIndex].Cells["QuantityColumn"].Value.ToString()!);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSalesOrder?.Invoke(sender, e);
        }

        private void dgvProductSelect_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductSelect.RowCount == 0)
            {
                return;
            }

            RecalculateTotalPrice();

        }
        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            CalculateChangePrice();
        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecimalPressed(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerSearch.Text = "";
            dgvCustomer.Rows.Clear();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            SearchCustomer?.Invoke(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProduct?.Invoke(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadProduct?.Invoke(sender, e);
        }

        private void dgvProductSelect_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RecalculateTotalPrice();
        }

        private void dgvProductSelect_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvProductSelect.RowCount == 0)
            {
                lblTotalPrice.Text = @"0";
                return;
            }
            RecalculateTotalPrice();
        }

        private void CalculateChangePrice()
        {
            decimal totalPrice = decimal.Parse(lblTotalPrice.Text,NumberStyles.Currency);
            decimal purchasePrice = 0;
            try
            {
                purchasePrice = decimal.Parse(txtPurchasePrice.Text);
            }
            catch
            {
                // ignored
            }

            decimal changePrice = purchasePrice - totalPrice;
            lblChangePrice.Text = (changePrice >= 0 ? changePrice : 0).ToString("C2");
        }
        private void RecalculateTotalPrice()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dgvProductSelect.Rows)
            {
                try
                {
                    sum += decimal.Parse(row.Cells["TotalPriceColumn"].Value.ToString()!);
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            lblTotalPrice.Text = sum.ToString("C2");
            txtPurchasePrice.Text = sum.ToString();
            CalculateChangePrice();
        }

        private void txtCustomerSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchCustomer.PerformClick();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }

        public int CurrentPage { get{
            try
            {
                return int.Parse(btnCurrentPage.Text);
            }
            catch (Exception)
            {
                return 0;
            }}
            set => btnCurrentPage.Text = value.ToString();
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
            NextPage?.Invoke(sender,e);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PreviousPage?.Invoke(sender,e);
        }
    }
}
