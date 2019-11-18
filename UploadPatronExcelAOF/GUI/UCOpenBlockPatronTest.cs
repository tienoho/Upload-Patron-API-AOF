using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UploadPatronExcelAOF.Tool;
using UploadPatronExcelAOF.DBConnect;
using System.IO;
using UploadPatronExcelAOF.API;
using System.Runtime.InteropServices;
using UploadPatronExcelAOF.Z303;
using UploadPatronExcelAOF.Entity;
using System.Diagnostics;
using System.Reflection;

namespace UploadPatronExcelAOF.GUI
{
    public partial class UCOpenBlockPatronTest : UserControl
    {
        #region Fields
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DataTable dataExcel = null;
        private List<Z308> listZ308 = null;
        private ToolP tool = new ToolP();

        private List<SinhVien> listTapHuan;
        public List<SinhVien> DSKhongTonTai;
        public int statusResult = 0;
        private string directoryPath = DataDBLocal.pathUserLog;
        private string url = "https://drive.google.com/file/d/1HONpc5LvaG3UmMrix8I0EUMOTVOcHDjN/view?usp=sharing";
        #endregion Fields
        public UCOpenBlockPatronTest()
        {
            InitializeComponent();
            log4net.Config.BasicConfigurator.Configure();
            log.Info("");
        }
        private void UCOpenBlockPatron_Load(object sender, EventArgs e)
        {
            listZ308 = Extensions.CloneObject(DataDBLocal.listZ308);
            CreateFolder(directoryPath);
            ComboxBlock();
        }

        private void CreateFolder(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Btn_browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "excel file |*.xls;*.xlsx";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Chọn file excel";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_taphuan.Text = openFileDialog.FileName;
            }
            if (txt_taphuan.Text != "")
            {

                dataExcel = new HandlingExcel().ReadFromExcelfile(txt_taphuan.Text, "");
                new ToolsPatron().AddDataListBarcode(dataExcel);
                new ToolsPatron().CompreRemovePatronListNotExist();
                dgvDataExcel.DataSource = DataDBLocal.ListAlreadyExists;
                dgvDataBarcode.DataSource = DataDBLocal.ListExcelBarcode.Select(x => new { MaSV = x }).ToList();
                dgvNotExist.DataSource = DataDBLocal.ListExcelBarcodeNotExist.Select(x => new { MaSV = x }).ToList();
                new ToolsPatron().CountColumnDataGridView(dgvDataExcel, lbCountListExcel);
                new ToolsPatron().CountColumnDataGridView(dgvNotExist, lbCountHad);
                btnPush.Enabled = true;
                new ToolP().EnabledButton(DataDBLocal.ListAlreadyExists, btn_excel_danhsach);
                new ToolP().EnabledButton(DataDBLocal.ListExcelBarcodeNotExist, btn_excel_danhsach_khongtontai);
                MessageBox.Show("Chuyển dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Chưa nhập đường dẫn");
            }
        }

        private void BtnPush_Click(object sender, EventArgs e)
        {
            if (listTapHuan.Count > 0)
            {
                RequestApiUpdate();
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu!!!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start(url);
        }

        private void Btn_hd_Click(object sender, EventArgs e)
        {

        }

        private void RequestApiUpdate()
        {
            statusResult = 0;
            string block = (comboBox1.SelectedItem as ComboboxItem).Value.ToString();
            string blockName = (comboBox1.SelectedItem as ComboboxItem).Text;

            List<PatronEntity> ListAlreadyExists = DataDBLocal.ListAlreadyExists.CloneObject();

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn " + blockName + " không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Loading_FS.text = "\tĐang cập nhập dữ liệu ...";
                    Loading_FS.ShowSplash();
                    using (StreamWriter streamWriter = new StreamWriter(directoryPath + "\\" + "logUpdate" + new ToolP().getDate() + ".txt"))
                    {
                        foreach (PatronEntity patron in ListAlreadyExists)
                        {
                            streamWriter.WriteLine(new AlephUploadPatronAPI().Url(new SBApiAleph().sbPatronApi(patron.MaSV_O, block).ToString()));
                        }
                        statusResult = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: \n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Error(ex.Message);
                }
                finally
                {
                    Loading_FS.CloseSplash();
                }
                if (statusResult == 1)
                    MessageBox.Show("Cập nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Btn_excel_danhsach_Click_1(object sender, EventArgs e)
        {
            if (DataDBLocal.ListAlreadyExists.Count > 0)
            {
                new HandlingExcel().GetPathDirectoryAndWriteExcel(DataDBLocal.ListAlreadyExists.Select(x => new { x.pationID, x.MaSV_O, x.HoTen, x.gioiTinh, x.ngaySinh }).ToList());
            }
        }

        private void Btn_excel_danhsach_khongtontai_Click(object sender, EventArgs e)
        {
            if (DataDBLocal.ListExcelBarcodeNotExist.Count > 0)
            {
                new HandlingExcel().GetPathDirectoryAndWriteExcel(DataDBLocal.ListExcelBarcodeNotExist.Select(MaSV => new { MaSV }).ToList());
            }
        }

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
            comboBox1.SelectedIndex = 1;
        }
        public StringBuilder sbPatronApi(string patronId, string name, string block)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            stringBuilder.Append("<p-file-20>");
            stringBuilder.Append("<patron-record>");
            stringBuilder.Append(new z303Block().tab3(patronId));
            stringBuilder.Append(new z305Block().tab5("LDC", patronId, block));
            stringBuilder.Append(new z305Block().tab5("LDC50", patronId, block));
            stringBuilder.Append(new z305Block().tab5("ALEPH", patronId, block));
            stringBuilder.Append("</patron-record>");
            stringBuilder.Append("</p-file-20>");
            return stringBuilder;
        }
        private void ResetForm()
        {

        }
    }
}
