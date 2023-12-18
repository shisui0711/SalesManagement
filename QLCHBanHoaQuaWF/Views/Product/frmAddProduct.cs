using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace QLCHBanHoaQuaWF.Views.Product
{
    public partial class frmAddProduct : Form, IAddProduct
    {
        private OpenFileDialog openFileDialog;
        public frmAddProduct()
        {
            InitializeComponent();
            InitOpenFileDialog();
        }

        private void InitOpenFileDialog()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "File png|*.png|File jpg|*.jpg|All files|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
        }
        private static bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif" || extension == ".bmp";
        }
        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                MessageBox.Show(_message, "Thông báo");
            }
        }
        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetField("txt" + name);
            if (textBoxField != null && textBoxField.GetType().IsAssignableTo(typeof(UserControl)))
            {
                var textBox = (UserControl)textBoxField.GetValue(this);
                textBox.Focus();
            }
        }

        public string ProductName
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }
        public string CalculationUnit
        {
            get { return txtCalculationUnit.Text; }
            set { txtCalculationUnit.Text = value; }
        }
        public byte[] ImageData { get; private set; }
        public decimal ImportUnitPrice
        {
            get { return decimal.Parse(txtImportUnitPrice.Text); }
            set { txtCalculationUnit.Text = value.ToString(); }
        }
        public decimal UnitPrice
        {
            get { return decimal.Parse(txtUnitPrice.Text); }
            set { txtUnitPrice.Text = value.ToString(); }
        }
        public string Description
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }

        public void Reset()
        {
            var fieldTypes = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(f => f.Name.StartsWith("txt"));
            foreach (var fieldType in fieldTypes)
            {
                UserControl control = (UserControl)fieldType.GetValue(this);
                control.Text = String.Empty;
            }
        }

        public event EventHandler? AddProduct;

        private void ptbUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var br = new BinaryReader(fs))
                    {
                        long numBytes = new FileInfo(openFileDialog.FileName).Length;
                        ImageData = br.ReadBytes((int)numBytes);
                        ptbUpload.Image = Image.FromStream(fs);
                    }
                }
            }
        }

        private void ptbUpload_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void ptbUpload_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                string imagePath = files[0];

                if (IsImageFile(imagePath))
                {
                    // Hiển thị ảnh trên PictureBox
                    ptbUpload.Image = Image.FromFile(imagePath);
                    using (var ms = new MemoryStream())
                    {
                        var extension = Path.GetExtension(imagePath);
                        if (extension == ".jpg" || extension == ".jpeg")
                        {
                            ptbUpload.Image.Save(ms, ImageFormat.Jpeg);
                        }
                        else
                        {
                            ptbUpload.Image.Save(ms, ImageFormat.Png);
                        }

                        ImageData = ms.ToArray();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct?.Invoke(sender, e);
        }
    }
}
