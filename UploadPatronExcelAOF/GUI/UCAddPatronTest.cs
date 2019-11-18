using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UploadPatronExcelAOF.Tool;
using UploadPatronExcelAOF.DBConnect;
using System.IO;
using UploadPatronExcelAOF.API;
using UploadPatronExcelAOF.Entity;

namespace UploadPatronExcelAOF.GUI
{
    public partial class UCAddPatronTest : UserControl
    {
        #region Fields
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private ToolP tool = new ToolP();
        private StringBuilder sbList = null;
        private List<PatronEntity> listPatron = null;
        private List<StringBuilder> listSb = null;
        DataTable dataExcel = null;
        private int countP = 1;
        private string directoryPath = DataDBLocal.pathUserLog;
        private string url = "https://drive.google.com/file/d/1tcw4B8sJ8CqmvhOMIh0WGGJqQjqr9fKK/view?usp=sharing";
        #endregion Fields
        public UCAddPatronTest()
        {
            InitializeComponent();
            log4net.Config.BasicConfigurator.Configure();
            log.Info("");
        }
        private void UCAddPatronTest_Load(object sender, EventArgs e)
        {
            // listZ308 = DataDBLocal.listZ308.CloneObject();
            ComboxBlock(); ComboxLoaiBanDoc();
            txtPatronId.Text = "1";
            txtLine.Text = "2";
            countP = new QueryDB().GetLastPatronId();
            txtPatronId.Text = $"{countP + 1:000000000000}";
            CreateFolder(directoryPath);
        }

        private void CreateFolder(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        #region Event
        private void btnThoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txtLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBrowserFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "excel file |*.xls;*.xlsx";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Chọn file excel";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog.FileName;
            }
            if (txtFileName.Text != "")
            {
                //readExcel2();
                //lưu dữ liệu từ excel vào dataExcel
                dataExcel = new HandlingExcel().ReadFromExcelfile(txtFileName.Text, "First Sheet");
                dgvPatron.DataSource = dataExcel;
                new ToolsPatron().CountColumnDataGridView(dgvPatron, lbCountListExcel);
                //Thêm dữ liệu từ dataExcel vào DataDBLocal.ListPatronOrigin
                DataDBLocal.ListPatronOrigin = new ToolsPatron().AddDataPatron(txtPatronId.Text, dataExcel);
                dataGridView1.DataSource = DataDBLocal.ListPatronOrigin;
                new ToolsPatron().CountColumnDataGridView(dataGridView1, lbCountListPatron);
                // new ToolsPatron().AddDataPatron(txtPatronId.Text,dataExcel);
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBrowserSave.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text != "")
            {
                //compreRemovePatron();
                //WriteXmlApi();
                string block = (comboBox1.SelectedItem as ComboboxItem).Value.ToString();
                string loaiBanDoc = (cbLoaiBanDoc.SelectedItem as ComboboxItem).Value.ToString();

                new ToolsPatron().CompreRemovePatron();
                new ToolsPatron().WriteXmlApi(DataDBLocal.ListPatronNew, block, loaiBanDoc);

                dataGridView1.DataSource = DataDBLocal.ListPatronNew;
                dgvHad.DataSource = DataDBLocal.ListAlreadyExists;

                new ToolsPatron().CountColumnDataGridView(dgvPatron, lbCountListExcel);
                new ToolsPatron().CountColumnDataGridView(dataGridView1, lbCountListPatron);
                new ToolsPatron().CountColumnDataGridView(dgvHad, lbCountHad);

                new ToolP().EnabledButton(DataDBLocal.ListPatronNew, btnExportExcelAddPatron);
                new ToolP().EnabledButton(DataDBLocal.ListAlreadyExists, btnbtnExportExcelNotPatron);
                if (DataDBLocal.ListPatronNew.Count > 0)
                {
                    btnPush.Enabled = true;
                    btnConvert.Enabled = false;
                    btnbtnExportExcelNotPatron.Enabled = true;
                    btnExportExcelAddPatron.Enabled = true;
                    MessageBox.Show("chuyển đổi dữ liệu thành công!", "Thông báo!");
                }

            }
        }
        private void txtPatronId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnPush_Click(object sender, EventArgs e)
        {
            if (txtBrowserSave.Text != "")
            {
                Loading_FS.text = "\tĐang tạo người dùng ...";
                Loading_FS.ShowSplash();
                using (StreamWriter streamWriter = new StreamWriter(directoryPath + "/Api-Patron-Log-" + tool.getDate() + ".txt"))
                {
                    foreach (StringBuilder item in DataDBLocal.listStringBuilder)
                    {
                        streamWriter.WriteLine(new AlephUploadPatronAPI().Url(item.ToString()));
                    }
                }
                //xuất ra danh sách patronid và patronbarcode để chuyển tên ảnh bạn đọc
                ExportDanhSachTT();
                Loading_FS.CloseSplash();
                MessageBox.Show("Tạo người thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Loading_FS.text = "\tĐang cập nhập lại dữ liệu ...";
                Loading_FS.ShowSplash();
                ResetForm();
                Loading_FS.CloseSplash();
                MessageBox.Show("Cập nhập dữ liệu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Chưa chọn đường dẫn lưu !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void BtnExcelDemo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenUrl.RequestApi(url);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.Error(ex.Message);
            }
        }

        private void Btn_excel_danhsach_Click(object sender, EventArgs e)
        {
            if (DataDBLocal.ListPatronNew.Count > 0)
            {
                new HandlingExcel().GetPathDirectoryAndWriteExcel(DataDBLocal.ListPatronNew);
            }
        }

        private void BtnHad_Click(object sender, EventArgs e)
        {
            if (DataDBLocal.ListAlreadyExists.Count > 0)
            {                
                new HandlingExcel().GetPathDirectoryAndWriteExcel(DataDBLocal.ListPatronNew.Select(x => new { x.pationID, x.MaSV_O, x.HoTen, x.gioiTinh, x.ngaySinh }).ToList());
            }
        }
        #endregion Event
        #region Method
        private void ComboxBlock()
        {
            ComboboxItem comboboxItem = new ComboboxItem();
            comboboxItem.Text = "Mở";
            comboboxItem.Value = "00";
            comboBox1.Items.Add(comboboxItem);
            comboboxItem = new ComboboxItem();
            comboboxItem.Text = "Khóa";
            comboboxItem.Value = "05";
            comboBox1.Items.Add(comboboxItem);
            comboBox1.SelectedIndex = 0;
        }
        private void ComboxLoaiBanDoc()
        {
            ComboboxItem comboboxItem = new ComboboxItem();
            comboboxItem.Text = "Sinh Viên";
            comboboxItem.Value = "01";
            cbLoaiBanDoc.Items.Add(comboboxItem);

            comboboxItem = new ComboboxItem();
            comboboxItem.Text = "Cao học - Nghiên cứu sinh";
            comboboxItem.Value = "02";
            cbLoaiBanDoc.Items.Add(comboboxItem);

            comboboxItem = new ComboboxItem();
            comboboxItem.Text = "Cán bộ - Giáo viên - Nghiên cứu viên";
            comboboxItem.Value = "03";
            cbLoaiBanDoc.Items.Add(comboboxItem);

            comboboxItem = new ComboboxItem();
            comboboxItem.Text = "Lãnh đạo - Quản lý";
            comboboxItem.Value = "04";
            cbLoaiBanDoc.Items.Add(comboboxItem);

            comboboxItem = new ComboboxItem();
            comboboxItem.Text = "Ngoài học viện";
            comboboxItem.Value = "05";
            cbLoaiBanDoc.Items.Add(comboboxItem);

            cbLoaiBanDoc.SelectedIndex = 0;
        }
        private void ExportDanhSachTT()
        {
            //if (listPatron.Count > 0)
            if (DataDBLocal.sbList.Length > 0)
            {
                //sbList = new StringBuilder();
                //foreach (PatronEntity item in listPatron)
                //{
                //    sbList.Append(item.pationID);
                //    sbList.Append("\t");
                //    sbList.AppendLine(item.MaSV_O);
                //}
                //File.WriteAllText(txtBrowserSave.Text + "/DanhSachTT" + tool.getDate() + ".txt", sbList.ToString());
                File.WriteAllText(txtBrowserSave.Text + "/DanhSachTT" + tool.getDate() + ".txt", DataDBLocal.sbList.ToString());
            }
        }

        private void ResetForm()
        {
            //DataDBLocal.listZ308 = new List<Z308>();
            DataDBLocal.listZ308 = new QueryDB().GetListZ308();
            //listZ308 = new List<Z308>();
            //listZ308 = DataDBLocal.listZ308.CloneObject();
            countP = new QueryDB().GetLastPatronId();
            txtPatronId.Text = $"{countP + 1:000000000}";
            //dgvPatron.DataSource = null;
            //dgvHad.DataSource = null;
            txtFileName.Clear();
            txtBrowserSave.Clear();
            btnConvert.Enabled = false;
            btnPush.Enabled = false;
        }
        private void ExportExcelAddPatron(string str)
        {
        }
        private void ExportExcelHadPatron(string str)
        {
        }
        #endregion Method        
    }
}
