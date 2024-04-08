using System.Drawing.Imaging;
using System.IO;

namespace QLCHBanHoaQuaWF.Views.Product
{
    public partial class frmUpdateProduct : Form, IUpdateProduct
    {
        public frmUpdateProduct()
        {
            InitializeComponent();
        }

        public int ProductID
        {
            get { return int.Parse(txtID.Text);}
            set { txtID.Text = value.ToString(); }
        }
        public string ProductName
        {
            get { return txtProductName.Text;}
            set { txtProductName.Text = value; }
        }
        public string CalculationUnit
        {
            get { return txtCalculationUnit.Text;}
            set { txtCalculationUnit.Text = value; }
        }

        public byte[] ImageData
        {
            get
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ptbUpload.Image.Save(ms, ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            set
            {
                if (value == null)
                {
                    ptbUpload.Image = ptbUpload.ErrorImage;
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(value))
                    {
                        ptbUpload.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        public decimal? ImportUnitPrice
        {
            get { return decimal.Parse(txtImportUnitPrice.Text);}
            set { txtImportUnitPrice.Text = value.ToString(); }
        }
        public decimal? UnitPrice
        {
            get { return decimal.Parse(txtUnitPrice.Text);}
            set { txtUnitPrice.Text = value.ToString(); }
        }
        public string Description
        {
            get { return txtDescription.Text;}
            set { txtDescription.Text = value; }
        }
        public event EventHandler? UpdateProduct;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                MessageBox.Show(_message, "Thông báo");
            }
        }
        private string _message;

        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetField("txt" + name);
            if (textBoxField != null && textBoxField.GetType().IsAssignableTo(typeof(UserControl)))
            {
                var textBox = (UserControl)textBoxField.GetValue(this);
                if (textBox != null)
                    textBox.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateProduct?.Invoke(this,EventArgs.Empty);
        }

        private void txtImportUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecimalPressed(sender,e);
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecimalPressed(sender,e);
        }
    }
}
