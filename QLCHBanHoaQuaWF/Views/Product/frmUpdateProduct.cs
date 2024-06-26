﻿using QLCHWF.CustomMessageBox;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace QLCHWF.Views.Product
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
        public new string ProductName
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
                    var bitmap = new Bitmap(ptbUpload.Image);
                    bitmap.Save(ms,ptbUpload.Image.RawFormat);
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
            get { try
                {
                    return decimal.Parse(txtImportUnitPrice.Text);
                }
                catch
                {
                    return null;
                }
            }
            set { txtImportUnitPrice.Text = value.ToString(); }
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
                ;}
            set { txtUnitPrice.Text = value.ToString(); }
        }
        public string Description
        {
            get { return txtDescription.Text;}
            set { txtDescription.Text = value; }
        }
        public event EventHandler? UpdateProduct;

        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x => x.Name == "txt" + name).FirstOrDefault();
            if (textBoxField != null)
            {
                var textBox = (UserControl)textBoxField.GetValue(this)!;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptbUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
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

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
