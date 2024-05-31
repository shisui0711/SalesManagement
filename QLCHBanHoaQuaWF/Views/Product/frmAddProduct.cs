using QLCHWF.CustomMessageBox;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace QLCHWF.Views.Product
{
    public partial class frmAddProduct : Form, IAddProduct
    {
        private OpenFileDialog _openFileDialog = null!;
        public frmAddProduct()
        {
            InitializeComponent();
            InitOpenFileDialog();
        }

        private void InitOpenFileDialog()
        {
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.InitialDirectory = "C:\\";
            _openFileDialog.Filter = "File png|*.png|File jpg|*.jpg|All files|*.*";
            _openFileDialog.FilterIndex = 1;
            _openFileDialog.RestoreDirectory = true;
        }
        private static bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif" || extension == ".bmp";
        }

        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x => x.Name == "txt" + name).FirstOrDefault();
            if (textBoxField != null)
            {
                var textBox = (UserControl)textBoxField.GetValue(this)!;
                textBox.Focus();
            }
        }

        public new string ProductName
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }
        public string CalculationUnit
        {
            get { return txtCalculationUnit.Text; }
            set { txtCalculationUnit.Text = value; }
        }
        public byte[] ImageData { get; private set; } = null!;

        public decimal? ImportUnitPrice
        {
            get { try
                {
                    return decimal.Parse(txtImportUnitPrice.Text);
                }
                catch
                {
                    return null;
                }
            }
            set { txtCalculationUnit.Text = value.ToString(); }
        }
        public decimal? UnitPrice
        {
            get { try
                {
                    return decimal.Parse(txtUnitPrice.Text);
                }
                catch
                {
                    return null;
                }
            }
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
                UserControl control = (UserControl)fieldType.GetValue(this)!;
                control.Text = String.Empty;
            }
        }

        public event EventHandler? AddProduct;

        private void ptbUpload_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(_openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var br = new BinaryReader(fs))
                    {
                        long numBytes = new FileInfo(_openFileDialog.FileName).Length;
                        ImageData = br.ReadBytes((int)numBytes);
                        ptbUpload.Image = Image.FromStream(fs);
                    }
                }
            }
        }

        private void ptbUpload_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void ptbUpload_DragDrop(object sender, DragEventArgs e)
        {
            string[]? files = (string[]?)e.Data?.GetData(DataFormats.FileDrop);
            if (files != null && files.Length > 0)
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

        private void txtImportUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecimalPressed(sender,e);
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DecimalPressed(sender,e);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
