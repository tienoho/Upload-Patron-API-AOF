using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadPatronExcelAOF.Tool
{
   public static class OpenUrl
    {
        public static void RequestApi(string url)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}
