using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadPatronExcelAOF
{
    public partial class Loading_FS : Form
    {
        public Loading_FS()
        {
            InitializeComponent();
            label1.Text = text;
        }
        private static Thread _splashThread;
        private static Loading_FS _splashForm;
        public static string text;
        public static void ShowSplash()
        {
            if (_splashThread == null)
            {
                _splashThread = new Thread(new ThreadStart(DoShowSplash));
                _splashThread.IsBackground = true;
                _splashThread.Start();
            }
            else
            {

                _splashThread = new Thread(new ThreadStart(DoShowSplash));
                _splashThread.IsBackground = true;
                _splashThread.Start();
                _splashForm = null;
            }
        }
        private static void DoShowSplash()
        {
            if (_splashForm == null)
            {
                _splashForm = new Loading_FS();
                _splashForm.StartPosition = FormStartPosition.CenterScreen;
                _splashForm.TopMost = true;
            }
            Application.Run(_splashForm);
        }
        public static void CloseSplash()
        {
            if (_splashForm.InvokeRequired)
            {
                _splashForm.Invoke(new MethodInvoker(CloseSplash));
            }
            else
            {
                Application.ExitThread();
            }
        }
        private void Loading_FS_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
