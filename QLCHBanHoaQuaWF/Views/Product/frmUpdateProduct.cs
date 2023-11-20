using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBanHoaQuaWF.Views.Product
{
    public partial class frmUpdateProduct : Form,IUpdateProduct
    {
        public frmUpdateProduct()
        {
            InitializeComponent();
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CalculationUnit { get; set; }

        public byte[] ImageData
        {
            get
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ptbUpload.Image.Save(ms,ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            set
            {
                using (MemoryStream ms = new MemoryStream(value))
                {
                    ptbUpload.Image = Image.FromStream(ms);
                }
            }
        }

        public decimal? ImportUnitPrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public string Description { get; set; }
        public event EventHandler? UpdateProduct;
        public string Message
        {
            get { return _message;}
            set { _message = value;
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
                if(textBox != null)
                    textBox.Focus();
            }
        }
    }
}
