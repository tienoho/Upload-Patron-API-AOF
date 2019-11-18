using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UploadPatronExcelAOF.Entity
{
    public class Z305 : IComparable
    {
        public string Z305_REC_KEY { get; set; }
        public string Z305_DELINQ_1 { get; set; }
        public virtual int CompareTo(object obj)
        {
            Z305 z = obj as Z305;
            if (string.Compare(Z305_REC_KEY.ToString(), z.Z305_REC_KEY.ToString(), ignoreCase: true) == 1)
            {
                return 1;
            }
            if (string.Compare(Z305_REC_KEY.ToString(), z.Z305_REC_KEY.ToString(), ignoreCase: true) == 0)
            {
                return 0;
            }
            return -1;
        }
    }
}
