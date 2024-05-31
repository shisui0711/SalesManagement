using QLCHWF.CustomMessageBox;
using System.ComponentModel;
using System.Reflection;

namespace QLCHWF.Views.Customer
{
    public partial class frmViewCustomer : Form, IViewCustomer
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
        public BindingSource CustomerBindingSource
        {
            get { return bindingSourceCustomer; }
        }
        #nullable enable 
        public event EventHandler? LoadCustomer;
        #nullable enable
        public event EventHandler? RemoveCustomer;
#nullable enable
        public event EventHandler? SearchCustomer;
        public event EventHandler? ShowAddCustomer;
        public event EventHandler? ShowUpdateCustomer;
        public event EventHandler? ShowSalesHistory;

        public frmViewCustomer()
        {
            InitializeComponent();
            LoadCopy();
        }
        private void LoadCopy()
        {
            var properties = typeof(Models.Customer).GetProperties(BindingFlags.Public | BindingFlags.Instance)
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
                    Models.Customer? selected = CustomerBindingSource.Current as Models.Customer;
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
        private void frmViewCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomer?.Invoke(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddCustomer?.Invoke(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
            LoadCustomer?.Invoke(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCustomer?.Invoke(sender, e);
        }

        private void cboOptionSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowUpdateCustomer?.Invoke(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialogResult = MyMessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            RemoveCustomer?.Invoke(sender, e);
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
            ShowSalesHistory?.Invoke(sender,e);
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
