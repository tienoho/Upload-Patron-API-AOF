using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UploadPatronExcelAOF.DBConnect;

namespace UploadPatronExcelAOF
{
    public partial class FormStartLoading : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Thread threadInput = null;
        Thread thread1 = null;
        //Thread thread2 = null;
        //Thread thread3 = null;
        //Thread thread4 = null;
        //Thread thread5 = null;

        Boolean booleanZ308 = false;
        //Boolean booleanZ30 = false;
        //Boolean booleanZ00R = false;
        //Boolean booleanZ36 = false;
        //Boolean booleanZ31 = false;
        public FormStartLoading()
        {
            InitializeComponent();
            log4net.Config.BasicConfigurator.Configure();
            log.Debug("Open Progam UploadPatron");
            log.Info("");
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker1.WorkerSupportsCancellation = true;

            labelError.Visible = false;
            labelError.Parent = pictureError;
            labelError.BackColor = Color.Transparent;
            lbLoad.Visible = false;
            lbLoad.Parent = picLoader;
            lbLoad.BackColor = Color.Transparent;
        }

        public void Startaaa()
        {
            if (TestConnecting())
            {
                //DataDBLocal.listZ308 = new QueryDB().listZ308TED();
                //DataDBLocal.listZ30 = new QueryDB().listZ30();                
                //DataDBLocal.listZ00R = new QueryDB().listZ00R();
                //DataDBLocal.listZ36 = new QueryDB().listZ36();
                //DataDBLocal.listZ31 = new QueryDB().listZ31();

                //DataDBLocal.listZ00 = new QueryDB().listZ00();
                //Invoke((MethodInvoker)delegate
                //{
                //    SetLoading(displayLoader: false);
                //    Hide();
                //    ControlMainForm control = new ControlMainForm();
                //    control.EnabledPanl(bl: true);
                //    control.LoadForm();
                //    control.Show();
                //});

                thread1 = new Thread(LoadZ308);
                thread1.Start();

                //thread1 = new Thread(LoadZ00R);
                //thread1.Start();
                //thread2 = new Thread(LoadZ30);
                //thread2.Start();
                //thread3 = new Thread(LoadZ308);
                //thread3.Start();
                //thread4 = new Thread(LoadZ31);
                //thread4.Start();
                //thread5 = new Thread(LoadZ36);
                //thread5.Start();


            }
            else
            {
                Invoke((MethodInvoker)delegate
                {
                    pictureError.Visible = true;
                    labelError.Visible = true;
                    Cursor = Cursors.Default;
                });
            }
        }

        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                Invoke((MethodInvoker)delegate
                {
                    picLoader.Visible = true;
                    lbLoad.Visible = true;
                    Cursor = Cursors.WaitCursor;
                });
            }
            else
            {
                Invoke((MethodInvoker)delegate
                {
                    picLoader.Visible = false;
                    Cursor = Cursors.Default;
                });
            }
        }

        private bool TestConnecting()
        {
            bool result = false;
            try
            {
                SetLoading(displayLoader: true);
                Thread.Sleep(1000);
                DataOracle oracle = new ReadWriterConfig().ReadConfigDataBase();
                DBConnecting.conn = DBConnecting.GetDBConnection(oracle);
                DBConnecting.conn.Open();
                result = true;
                DBConnecting.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo!");
                log.Error(ex.Message);
            }
            return result;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {

            try
            {
                if (threadInput != null)
                    threadInput.Abort();
                if (thread1 != null)
                    thread1.Abort();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }

            //thread2.Abort();
            //thread3.Abort();
            //thread4.Abort();
            //thread5.Abort();
            Application.Exit();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            threadInput = new Thread(Startaaa);
            threadInput.Start();
        }
        private void CheckLoadFormMain()
        {
            //if (booleanZ00R == true && booleanZ30 == true && booleanZ308 == true && booleanZ31 == true && booleanZ36 == true)
            if (booleanZ308 == true)
                Invoke((MethodInvoker)delegate
                {
                    SetLoading(displayLoader: false);
                    Hide();
                    ControlMainForm control = new ControlMainForm();
                    control.EnabledPanl(bl: true);
                    control.LoadForm();
                    control.Show();
                });
        }
        //private void LoadZ00R()
        //{
        //    try
        //    {
        //        DataDBLocal.listZ00R = new QueryDB().listZ00R();
        //        booleanZ00R = true;
        //        CheckLoadFormMain();
        //    }
        //    catch
        //    {
        //        booleanZ30 = false;
        //    }

        //}
        //private void LoadZ31()
        //{
        //    try
        //    {
        //        DataDBLocal.listZ31 = new QueryDB().listZ31();
        //        booleanZ31 = true;
        //        CheckLoadFormMain();
        //    }
        //    catch
        //    {
        //        booleanZ30 = false;
        //    }

        //}
        //private void LoadZ36()
        //{
        //    try
        //    {
        //        DataDBLocal.listZ36 = new QueryDB().listZ36();
        //        booleanZ36 = true;
        //        CheckLoadFormMain();
        //    }
        //    catch
        //    {
        //        booleanZ30 = false;
        //    }

        //}
        //private void LoadZ30()
        //{
        //    try
        //    {
        //        DataDBLocal.listZ30 = new QueryDB().listZ30();
        //        booleanZ30 = true;
        //        CheckLoadFormMain();
        //    }
        //    catch
        //    {
        //        booleanZ30 = false;
        //    }

        //}
        private void LoadZ308()
        {
            try
            {
                DataDBLocal.listZ308 = new QueryDB().GetListZ308();
                booleanZ308 = true;
                CheckLoadFormMain();
            }
            catch
            {
                booleanZ308 = false;
            }
        }
    }
}
