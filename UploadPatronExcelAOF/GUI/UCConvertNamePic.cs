using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using UploadPatronExcelAOF.Entity;
using System.Diagnostics;
using System.Reflection;
using UploadPatronExcelAOF.DBConnect;

namespace UploadPatronExcelAOF.GUI
{
    public partial class UCConvertNamePic : UserControl
    {
        #region Fields
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string[] files = null;
        private List<listID> list;
        private string fileName;
        private string src;
        private string directoryPath = DataDBLocal.pathUserLog;
        private string url1 = "https://drive.google.com/file/d/1Rp6TEy-GC5BlmAqISliAeg0CDXYthsrb/view?usp=sharing";
        #endregion Fields
        public UCConvertNamePic()
        {
            InitializeComponent();
            log4net.Config.BasicConfigurator.Configure();
            log.Info("");
        }
        private void ConvertNamePic_Load(object sender, EventArgs e)
        {

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
        private void btnConvert_Click(object sender, EventArgs e)
        {
            Loading_FS.text = "\tĐang đưa dữ liệu ...";
            Loading_FS.ShowSplash();
            ChangeName();
            Loading_FS.CloseSplash();
            MessageBox.Show("Thành công!", "Thông báo!");
        }

        private void btnchooseTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text file |*.txt;*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Chọn file txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                readTxt();
            }
        }

        private void btnOpenDirectoryName_Click(object sender, EventArgs e)
        {
            openDirectory(lb_showDirectory);
        }

        private void Btn_hd_Click_1(object sender, EventArgs e)
        {

        }
        private void openDirectory(ListBox lb)
        {
            lb.Items.Clear();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.ShowDialog();
            src = folderBrowserDialog.SelectedPath;
            int num = 0;
            try
            {
                files = Directory.GetFiles(src.Trim(), "*.*", SearchOption.AllDirectories);
                for (int i = 0; i < files.Length; i++)
                {
                    lb.Items.Add(files[i]);
                    num++;
                }
                lb_tongfile.Text = num.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                log.Error(ex.Message);
            }
        }

        private void readTxt()
        {
            list = new List<listID>();
            if (fileName == null)
            {
                MessageBox.Show("Chua chon file");
                return;
            }
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                string text;
                while ((text = streamReader.ReadLine()) != null)
                {
                    listID listID = new listID();
                    listID.id = text.Substring(0, text.IndexOf("\t"));
                    listID.barcode = text.Substring(text.LastIndexOf("\t")).Trim();
                    list.Add(listID);
                    listBox3.Items.Add(listID.id + " - " + listID.barcode);
                }
            }
            lb_tong.Text = list.Count.ToString();
        }

        private void ChangeName()
        {
            if (list == null)
            {
                readTxt();
            }
            int num = 0;
            num = list.Count;
            if (files == null)
            {
                return;
            }
            string text = "";
            string text2 = "";
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            Loading_FS.ShowSplash();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < files.Length; i++)
            {
                text = files[i];
                int num5 = text.LastIndexOf("\\");
                string text3 = text.Substring(num5 + 1);
                if (!text3.Contains("."))
                {
                    continue;
                }
                text3 = text3.Substring(0, text3.LastIndexOf("."));
                string text4 = text.Substring(num5 + 1).Substring(text.Substring(num5 + 1).LastIndexOf("."));
                for (int j = 0; j < num; j++)
                {
                    string str = list[j].id.ToString();
                    string text5 = list[j].barcode.ToString();
                    if (text5.Trim().ToUpper().Equals(text3.ToUpper()))
                    {
                        try
                        {
                            if (num3 == 1000)
                            {
                                num3 = 0;
                                num4++;
                            }
                            string text6 = src + "\\Converter\\pic" + num4;
                            if (!Directory.Exists(text6))
                            {
                                Directory.CreateDirectory(text6);
                            }
                            text2 = text6 + "\\" + str + ".jpg";
                            File.Move(text, text2);
                            num3++; num2++;
                        }
                        catch (Exception ex)
                        {
                            log.Error(ex.Message);
                            continue;
                        }
                        break;
                    }
                }
            }
            stopwatch.Stop();
            Loading_FS.CloseSplash();
            MessageBox.Show("Thành công: " + num2 + "\nTime: " + stopwatch.Elapsed.ToString() + "s", "Thông báo!");
            files = null;
            loadItems(lb_showDirectory);
        }

        private void loadItems(ListBox lb)
        {
            files = null;
            lb.Items.Clear();
            try
            {
                files = Directory.GetFiles(src.Trim(), "*.*", SearchOption.AllDirectories);
                for (int i = 0; i < files.Length; i++)
                {
                    lb.Items.Add(files[i]);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnDataDemo_Click(object sender, EventArgs e)
        {

        }
    }
}
