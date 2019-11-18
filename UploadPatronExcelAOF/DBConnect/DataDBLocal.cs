using System;
using System.Collections.Generic;
using System.Text;
using UploadPatronExcelAOF.Entity;
using UploadPatronExcelAOF.Tool;

namespace UploadPatronExcelAOF.DBConnect
{
    public static class DataDBLocal
    {
        public static List<Z308> listZ308 { get; set; }
        public static List<Z36> listZ36 { get; set; }
        public static List<Z00> listZ00 { get; set; }
        public static List<Z00R> listZ00R { get; set; }
        public static List<Z30> listZ30 { get; set; }
        public static List<Z31> listZ31 { get; set; }
        public static List<Z305> listZ305 { get; set; }
        public static List<PatronEntity> ListPatronOrigin { get; set; }
        public static List<PatronEntity> ListPatronNew { get; set; }
        public static List<PatronEntity> ListAlreadyExists { get; set; }
        public static List<PatronEntity> ListNotExist { get; set; }
        public static List<string> ListExcelBarcode { get; set; }
        public static List<string> ListExcelBarcodeNotExist { get; set; }
        public static List<StringBuilder> listStringBuilder { get; set; }
        public static StringBuilder sbList { get; set; }
        public static string pathUserLog = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\UploadPatronLog";

    }
}
