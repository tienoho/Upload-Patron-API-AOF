using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadPatronExcelAOF.GUI;

namespace UploadPatronExcelAOF.Tool
{
    public class FormProvider
    {
        private static UCAddPatronTest _mainMenu;
        public static UCAddPatronTest MainMenu
        {
            get
            {
                if (_mainMenu == null)
                {
                    _mainMenu = new UCAddPatronTest();
                }
                return _mainMenu;
            }
        }
    }
}
