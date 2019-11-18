using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UploadPatronExcelAOF.Tool
{
    internal class ToolP
    {
        public string addNameKey(string name)
        {
            name = name.ToLower();
            name = RemoveVietnameseMark(name);
            do
            {
                name += " ";
            }
            while (name.Count() < 38);
            return name;
        }
        public string formatDate(string str)
        {
            try
            {
                if (str != "" || str != null)
                {
                    if (str.Contains("/"))
                    {
                        str = formatDateString(str);
                    }
                    else
                    {
                        double d = double.Parse(str);
                        DateTime conv = DateTime.FromOADate(d);
                        str = conv.ToString("yyyyMMdd");
                    }
                    return str;
                }
            }
            catch
            {
            }
            return "19900101";
        }
        public string formatDateString(string str)
        {
            str = DateTime.ParseExact(str, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            return str;
        }
        public string getNgayHetHan(string str)
        {
            DateTime dateTime = DateTime.Parse(DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy")).AddYears(4).ToString("dd/MM/yyyy"));
            try
            {
                if (str == "" || str == null)
                {
                    str = dateVn(dateTime.ToString());
                }
                else
                {
                    CultureInfo provider = new CultureInfo("vi-VN");
                    str = DateTime.Parse(str, provider).ToString("yyyyMMdd");
                }
            }
            catch
            {
                str = dateVn(dateTime.ToString());
            }
            return str;
        }

        public string dateVn(string str)
        {
            CultureInfo provider = new CultureInfo("vi-VN");
            str = DateTime.Parse(str, provider).ToString("yyyyMMdd");
            return str;
        }

        public string RemoveVietnameseMark(string str)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string input = str.Normalize(NormalizationForm.FormD);
            return regex.Replace(input, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
        }

        public string formatPatronId(string Id)
        {
            int num = Id.Count();
            if (num > 9)
            {
                Id = Id.Substring(Id.Length - 9);
            }
            return Id;
        }

        public string convertGender(string genDer)
        {
            genDer = genDer.ToUpper();
            genDer = ((!(genDer == "NAM")) ? "Ms." : "Mr.");
            return genDer;
        }

        public string bor_type(string str)
        {
            switch (str)
            {
                case "CD":
                    return "AJ";
                case "CN":
                    return "AG";
                case "CP":
                    return "AZ";
                case "KE":
                    return "AC";
                case "KT":
                    return "AV";
                case "MT":
                    return "AN";
                case "NH":
                    return "AM";
                case "SN":
                    return "BW";
                case "TY":
                    return "BR";
                case "TH":
                    return "AL";
                default:
                    return "";
            }
        }

        public string getDate()
        {
            string text = DateTime.Now.Year.ToString();
            string text2 = DateTime.Now.Month.ToString();
            string text3 = DateTime.Now.Day.ToString();
            string text4 = DateTime.Now.Hour.ToString();
            string text5 = DateTime.Now.Minute.ToString();
            string text6 = DateTime.Now.Second.ToString();
            return "_" + text + "." + text2 + "." + text3 + "_" + text4 + "." + text5;
        }

        public string formatDatePassword(string str)
        {
            try
            {
                if (str != "" || str != null)
                {
                    if (str.Contains("/"))
                    {
                        str = formatDatePasswordString(str);
                    }
                    else
                    {
                        double d = double.Parse(str);
                        DateTime conv = DateTime.FromOADate(d);
                        str = conv.ToString("ddMMyyyy");
                    }
                    return str;
                }
            }
            catch
            {
            }
            return "01011990";
        }
        public string formatDatePasswordString(string str)
        {

            str = DateTime.ParseExact(str, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("ddMMyyyy");
            return str;
        }
        public void EnabledButton<T>(List<T> list, Button button)
        {
            if (list.Count > 0)
            {
                button.Enabled = true;
            }
        }
    }
}
