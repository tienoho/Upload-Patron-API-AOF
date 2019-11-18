using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadPatronExcelAOF.Z303;

namespace UploadPatronExcelAOF.Tool
{
    class SBApiAleph
    {
        public StringBuilder sbPatronApi(string patronId, string block)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            stringBuilder.Append("<p-file-20>");
            stringBuilder.Append("<patron-record>");
            stringBuilder.Append(new z303Block().tab3(patronId));
            stringBuilder.Append(new z305Block().tab5("AOF", patronId, block));
            stringBuilder.Append(new z305Block().tab5("AOF50", patronId, block));
            stringBuilder.Append(new z305Block().tab5("ALEPH", patronId, block));
            stringBuilder.Append("</patron-record>");
            stringBuilder.Append("</p-file-20>");
            return stringBuilder;
        }
    }
}
