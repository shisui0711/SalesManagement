namespace QLCHWF.CustomMessageBox
{
    public partial class frmMessageBox : Form
    {
        private Color _cancelColor = Color.DimGray;
        private Color _noColor = Color.IndianRed;
        private Color _abortColor = Color.Goldenrod;
        private Color _primaryColor = Color.FromArgb(18, 145, 250);
        private int _borderSize = 2;
        public Color PrimaryColor
        {
            get { return _primaryColor;}
            set
            {
                _primaryColor = value;
                this.BackColor = _primaryColor;
                this.pnlHeader.FillColor = _primaryColor;
                btnClose.FillColor = _primaryColor;
            } }
        public frmMessageBox(string text)
        {
            InitializeComponent();
            InitializeItems();
            this.lblContent.Text = text;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK,MessageBoxDefaultButton.Button1);
        }

        public frmMessageBox(string text, string caption)
        {
            InitializeComponent();
            InitializeItems();
            this.lblContent.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);
        }

        public frmMessageBox(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();
            this.lblContent.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);
        }

        public frmMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            this.lblContent.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);
            SetIcon(icon);
        }

        public frmMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon,MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();
            this.lblContent.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }
        private void InitializeItems()
        {
            this.lblContent.MaximumSize = new Size(450, 0);
            this.Padding = new Padding(_borderSize);//Set border size
            this.btnClose.DialogResult = DialogResult.Cancel;
            this.btn1.DialogResult = DialogResult.OK;
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
        }

        private void SetFormSize()
        {
            int height = this.pnlHeader.Height + this.lblContent.Height + this.ptbIcon.Height + this.pnlButton.Height;
            int width = this.ptbIcon.Width * 2 + this.lblContent.Width;
            this.Size = new Size(width, height);
        }

        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.pnlButton.Width - btn1.Width) / 2;
            int yCenter = (this.pnlButton.Height - btn1.Height) / 2;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //Ok Button
                    btn1.Visible = true;
                    btn1.Location = new Point(xCenter, yCenter);
                    btn1.Text = @"Đồng ý";
                    btn1.DialogResult = DialogResult.OK;
                    btn1.BackColor = _primaryColor;
                    
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.OKCancel:
                    //OK Button
                    btn1.Visible = true;
                    btn1.Location = new Point(xCenter - (btn1.Width / 2) - 5, yCenter);
                    btn1.Text = @"Đồng ý";
                    btn1.DialogResult = DialogResult.OK;//Set DialogResult
                    btn1.BackColor = _primaryColor;

                    //Cancel Button
                    btn2.Visible = true;
                    btn2.Location = new Point(xCenter + (btn2.Width / 2) + 5, yCenter);
                    btn2.Text = @"Hủy bỏ";
                    btn2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    btn2.BackColor = _cancelColor;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    btn1.Visible = true;
                    btn1.Location = new Point(xCenter - (btn1.Width / 2) - 5, yCenter);
                    btn1.Text = @"Thử lại";
                    btn1.DialogResult = DialogResult.Retry;//Set DialogResult
                    btn1.BackColor = _primaryColor;

                    //Cancel Button
                    btn2.Visible = true;
                    btn2.Location = new Point(xCenter + (btn2.Width / 2) + 5, yCenter);
                    btn2.Text = @"Hủy bỏ";
                    btn2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    btn2.BackColor = _cancelColor;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.YesNo:
                    //Yes Button
                    btn1.Visible = true;
                    btn1.Location = new Point(xCenter - (btn1.Width / 2) - 5, yCenter);
                    btn1.Text = @"Đồng ý";
                    btn1.DialogResult = DialogResult.Yes;//Set DialogResult
                    btn1.BackColor = _primaryColor;

                    //No Button
                    btn2.Visible = true;
                    btn2.Location = new Point(xCenter + (btn2.Width / 2) + 5, yCenter);
                    btn2.Text = @"Từ chối";
                    btn2.DialogResult = DialogResult.No;//Set DialogResult
                    btn2.BackColor = _noColor;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    //Yes Button
                    btn1.Visible = true;
                    btn1.Location = new Point(xCenter - btn1.Width - 5, yCenter);
                    btn1.Text = @"Đồng ý";
                    btn1.DialogResult = DialogResult.Yes;//Set DialogResult
                    btn1.BackColor = _primaryColor;

                    //No Button
                    btn2.Visible = true;
                    btn2.Location = new Point(xCenter, yCenter);
                    btn2.Text = @"Từ chối";
                    btn2.DialogResult = DialogResult.No;//Set DialogResult
                    btn2.BackColor = _noColor;

                    //Cancel Button
                    btn3.Visible = true;
                    btn3.Location = new Point(xCenter + btn2.Width + 5, yCenter);
                    btn3.Text = @"Hủy bỏ";
                    btn3.DialogResult = DialogResult.Cancel;//Set DialogResult
                    btn3.BackColor = _cancelColor;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;

                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    btn1.Visible = true;
                    btn1.Location = new Point(xCenter - btn1.Width - 5, yCenter);
                    btn1.Text = @"Hủy bỏ";
                    btn1.DialogResult = DialogResult.Abort;//Set DialogResult
                    btn1.BackColor = _abortColor;

                    //Retry Button
                    btn2.Visible = true;
                    btn2.Location = new Point(xCenter, yCenter);
                    btn2.Text = @"Thử lại";
                    btn2.DialogResult = DialogResult.Retry;//Set DialogResult                    
                    btn2.BackColor = _primaryColor;

                    //Ignore Button
                    btn3.Visible = true;
                    btn3.Location = new Point(xCenter + btn2.Width + 5, yCenter);
                    btn3.Text = @"Bỏ qua";
                    btn3.DialogResult = DialogResult.Ignore;//Set DialogResult
                    btn3.BackColor = _cancelColor;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
            }
        }

        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Focus button 1
                    btn1.Select();
                    btn1.ForeColor = Color.White;
                    btn1.Font = new Font(btn1.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button2://Focus button 2
                    btn2.Select();
                    btn2.ForeColor = Color.White;
                    btn2.Font = new Font(btn2.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button3://Focus button 3
                    btn3.Select();
                    btn3.ForeColor = Color.White;
                    btn3.Font = new Font(btn3.Font, FontStyle.Underline);
                    break;
            }
        }

        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.ptbIcon.Image = Properties.Resources.error;
                    PrimaryColor = Color.FromArgb(224, 79, 95);
                    break;
                case MessageBoxIcon.Information: //Information
                    this.ptbIcon.Image = Properties.Resources.information;
                    PrimaryColor = Color.FromArgb(38, 191, 166);
                    break;
                case MessageBoxIcon.Question://Question
                    this.ptbIcon.Image = Properties.Resources.question;
                    PrimaryColor = Color.FromArgb(10, 119, 232);
                    break;
                case MessageBoxIcon.Exclamation://Exclamation
                    this.ptbIcon.Image = Properties.Resources.warning;
                    PrimaryColor = Color.FromArgb(255, 140, 0);
                    break;
                case MessageBoxIcon.None: //None
                    this.ptbIcon.Image = Properties.Resources.chat;
                    PrimaryColor = Color.FromArgb(18, 145, 250);
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
