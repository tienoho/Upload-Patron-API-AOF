using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UploadPatronExcelAOF.DBConnect;
using UploadPatronExcelAOF.GUI;
using UploadPatronExcelAOF.Properties;
using UploadPatronExcelAOF.Tool;

namespace UploadPatronExcelAOF
{
    public partial class ControlMainForm : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public ControlMainForm()
        {
            InitializeComponent();
            log4net.Config.BasicConfigurator.Configure();
            log.Info("");
            if (DataDBLocal.listZ308.Count < 0) EnabledPanl(false);
        }
        private void ControlMainForm_Load(object sender, EventArgs e)
        {
            ButtonFontBold(btnAddPatron, FontStyle.Bold, Color.Green);
            ButtonFontBold(btnOpenBlock, FontStyle.Regular, Color.Black);
            ButtonFontBold(btnRenamePic, FontStyle.Regular, Color.Black);

            _pnlRight.Controls.Clear();
            //UCAddPatron uC = new UCAddPatron();
            UCAddPatronTest uC = new UCAddPatronTest();
            _pnlRight.Controls.Add(uC);
            uC.Show();
            lblInformation.Text = "Chức năng: Thêm người đùng";
        }
        #region StyleMouse
        private void _btNhanVien_MouseLeave(object sender, EventArgs e)
        {
            MouseChangeColorBackgroundImage(btnAddPatron, SystemColors.Control);
        }
        private void _btNhanVien_MouseMove(object sender, MouseEventArgs e)
        {
            MouseChangeColorBackgroundImage(btnAddPatron, SystemColors.Control, Resources.background);
        }
        private void BtnOpenBlock_MouseLeave(object sender, EventArgs e)
        {
            MouseChangeColorBackgroundImage(btnOpenBlock, SystemColors.Control);
        }
        private void BtnOpenBlock_MouseMove(object sender, MouseEventArgs e)
        {
            MouseChangeColorBackgroundImage(btnOpenBlock, SystemColors.Control, Resources.background);
        }
        private void btnRest_MouseLeave(object sender, EventArgs e)
        {
            MouseChangeColorBackgroundImage(btnRest, SystemColors.Control);
        }
        private void btnRest_MouseMove(object sender, MouseEventArgs e)
        {
            MouseChangeColorBackgroundImage(btnRest, SystemColors.Control, Resources.background);
        }
        private void BtnRenamePic_MouseLeave(object sender, EventArgs e)
        {
            MouseChangeColorBackgroundImage(btnRenamePic, SystemColors.Control);
        }

        private void BtnRenamePic_MouseMove(object sender, MouseEventArgs e)
        {
            MouseChangeColorBackgroundImage(btnRenamePic, SystemColors.Control, Resources.background);
        }
        #endregion StyleMouse

        #region Event
        private void BtnOpenBlock_Click(object sender, EventArgs e)
        {
            ButtonFontBold(btnOpenBlock, FontStyle.Bold, Color.Green);
            ButtonFontBold(btnAddPatron, FontStyle.Regular, Color.Black);
            ButtonFontBold(btnRenamePic, FontStyle.Regular, Color.Black);

            _pnlRight.Controls.Clear();
            UCOpenBlockPatronTest uc = new UCOpenBlockPatronTest();
            _pnlRight.Controls.Add(uc);
            uc.Show();
            lblInformation.Text = "Chức năng: Mở/Khóa bạn đọc";
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                lblInformation.Text = "Đang cập nhập lại dữ liệu từ server....";
                EnabledPanl(bl: false);
            });
            //DataDBLocal.listZ308 = new QueryDB().listZ308TED();
            Invoke((MethodInvoker)delegate
            {
                EnabledPanl(bl: true);
                lblInformation.Text = "Cập nhập thành công!";
                LoadForm();
            });
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            restConTrol();
        }
        private void Control_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnAddPatron_Click(object sender, EventArgs e)
        {
            ButtonFontBold(btnAddPatron, FontStyle.Bold, Color.Green);
            ButtonFontBold(btnOpenBlock, FontStyle.Regular, Color.Black);
            ButtonFontBold(btnRenamePic, FontStyle.Regular, Color.Black);

            _pnlRight.Controls.Clear();
            //UCAddPatron uC = new UCAddPatron();
            UCAddPatronTest uC = new UCAddPatronTest();
            _pnlRight.Controls.Add(uC);
            uC.Show();
            lblInformation.Text = "Chức năng: Thêm người đùng";
        }

        private void BtnRenamePic_Click(object sender, EventArgs e)
        {
            ButtonFontBold(btnRenamePic, FontStyle.Bold, Color.Green);
            ButtonFontBold(btnAddPatron, FontStyle.Regular, Color.Black);
            ButtonFontBold(btnOpenBlock, FontStyle.Regular, Color.Black);


            _pnlRight.Controls.Clear();
            UCConvertNamePic uC = new UCConvertNamePic();
            _pnlRight.Controls.Add(uC);
            uC.Show();
            lblInformation.Text = "Chức năng: Đổi tên ảnh";
        }
        #endregion Event
        #region Method
        public void EnabledPanl(bool bl)
        {
            _pnlLeft.Enabled = bl;
            _pnlRight.Enabled = bl;
            homeToolStripMenuItem.Enabled = bl;
            dataPatronToolStripMenuItem.Enabled = bl;
        }

        public void LoadForm()
        {
            _pnlRight.Controls.Clear();
            UCAddPatronTest uC = new UCAddPatronTest();
            _pnlRight.Controls.Add(uC);
            uC.Show();
            lblInformation.Text = "Chức năng: Thêm người đùng";
        }
        private void MouseChangeColorBackgroundImage(Button btn, Color color, Image image = null)
        {
            btn.BackColor = color;
            btn.BackgroundImage = image;
        }
        private void ButtonFontBold(Button btn, FontStyle fontStyle, Color color)
        {
            btn.ForeColor = color;
            btn.Font = new Font(btn.Font.Name, btn.Font.Size, fontStyle);

        }
        public void restConTrol()
        {
            Process.Start(Application.ExecutablePath);
            Close();
        }
        #endregion Method
    }
}
