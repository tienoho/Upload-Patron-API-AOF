using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadPatronExcelAOF.Entity
{
    public class SinhVien : IComparable
    {
        public string patronId
        {
            get;
            set;
        }

        public string maSV
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public int CompareTo(object obj)
        {
            SinhVien sinhVien = obj as SinhVien;
            if (string.Compare(maSV.ToString(), sinhVien.maSV.ToString(), ignoreCase: true) == 1)
            {
                return 1;
            }
            if (string.Compare(maSV.ToString(), sinhVien.maSV.ToString(), ignoreCase: true) == 0)
            {
                return 0;
            }
            return -1;
        }
    }
}
