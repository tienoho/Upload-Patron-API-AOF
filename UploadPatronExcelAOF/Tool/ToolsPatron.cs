using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UploadPatronExcelAOF.DBConnect;
using UploadPatronExcelAOF.Entity;
using UploadPatronExcelAOF.Z303;

namespace UploadPatronExcelAOF.Tool
{
    public class ToolsPatron
    {        
        public void AddDataPatron(string PatronIdFirst, DataTable dataExcel)
        {
            int num = int.Parse(PatronIdFirst);
            DataDBLocal.ListPatronOrigin = new List<PatronEntity>();
            foreach (DataRow row in dataExcel.Rows)
            {
                string maSinhVien = row.Field<string>(1);
                if (!String.IsNullOrEmpty(maSinhVien))
                {
                    PatronEntity patron = new PatronEntity();
                    patron.pationID = $"{num:000000000000}";
                    patron.MaSV_O = maSinhVien;
                    patron.HoTen = row.Field<string>(2);
                    patron.Day = DateTime.Now.ToString("yyyyMMdd");
                    patron.ngaySinh = new ToolP().formatDate(row.Field<string>(3));
                    patron.gioiTinh = new ToolP().convertGender(row.Field<string>(4));
                    patron.phone = row.Field<string>(5);
                    patron.email = row.Field<string>(6);
                    patron.lopHoc = row.Field<string>(7);
                    patron.Khoa = row.Field<string>(8);//Khoa\\\
                    patron.khoaHoc = row.Field<string>(9);//Khóa học
                    patron.DiaChi = row.Field<string>(10);
                    patron.NgayHetHan = new ToolP().formatDate(row.Field<string>(11));
                    patron.password = new ToolP().formatDatePassword(row.Field<string>(3));
                    DataDBLocal.ListPatronOrigin.Add(patron);
                    num++;
                }
            }
        }

        //thêm dữ liệu từ DataTable Excel vào List DataDBLocal.ListExcelBarcode
        public void AddDataListBarcode(DataTable dataExcel)
        {
            DataDBLocal.ListExcelBarcode = new List<string>();
            foreach (DataRow row in dataExcel.Rows)
            {
                string maSinhVien = row.Field<string>(0);
                if (!String.IsNullOrEmpty(maSinhVien))
                {
                    DataDBLocal.ListExcelBarcode.Add(maSinhVien);
                }
            }
        }
        //Chuyển dữ liệu sang dạng xml để đưa lên API
        public void WriteXmlApi(List<PatronEntity> ListPatronNew, string block, string borStatus)
        {
            DataDBLocal.listStringBuilder = new List<StringBuilder>();
            DataDBLocal.sbList = new StringBuilder();
            //int num = int.Parse(PatronIdFirst);
            foreach (PatronEntity item in ListPatronNew)
            {
                //item.pationID = $"{num:000000000000}";
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                stringBuilder.Append("<p-file-20>");
                stringBuilder.Append("<patron-record>");
                stringBuilder.Append(new z303().tab3(item));
                stringBuilder.Append(new z304().tab4(item));
                stringBuilder.Append(new z305().tab5(item, block, borStatus, "AOF", "N", "Y", "N", "Y"));
                stringBuilder.Append(new z305().tab5(item, block, borStatus, "AOF50", "N", "Y", "N", "Y"));
                stringBuilder.Append(new z305().tab5(item, block, borStatus, "ALEPH", "N", "Y", "N", "Y"));
                stringBuilder.Append(new z308().tab8(item));
                stringBuilder.Append("</patron-record>");
                stringBuilder.Append("</p-file-20>");
                DataDBLocal.listStringBuilder.Add(stringBuilder);

                DataDBLocal.sbList.Append(item.pationID);
                DataDBLocal.sbList.Append("\t");
                DataDBLocal.sbList.AppendLine(item.MaSV_O);

                //num++;
            }
        }
        public void ExportExcel()
        {

        }
        //đếm số dòng của của DataGridView
        public void CountColumnDataGridView(DataGridView gdv, Label lb)
        {
            if (gdv.ColumnCount > 0)
            {
                lb.Text = "Số lượng: " + gdv.RowCount.ToString();
            }
        }
        // lọc ra các patron đã tồn tại
        //xóa các patron này ra khỏi danh sách
        public void CompreRemovePatron()
        {
            DataDBLocal.ListAlreadyExists = new List<PatronEntity>();
            DataDBLocal.ListPatronNew = new List<PatronEntity>();
            //Sao chép danh sách ListPatronOrigin sang ListPatronNew
            DataDBLocal.ListPatronNew = DataDBLocal.ListPatronOrigin.CloneObject();
            //Sao chép sanh sách DataDBLocal.listZ308 sang listZ308
            List<Z308> listZ308 = DataDBLocal.listZ308.CloneObject();

            //Lọc các patron đã tồn tại
            foreach (Z308 item in listZ308)
            {
                string Z308_REC_KEY = item.Z308_REC_KEY.Trim();
                //loại bỏ 2 ký tự đầu của Z308_REC_KEY
                Z308_REC_KEY = Z308_REC_KEY.Substring(2);

                foreach (PatronEntity item2 in DataDBLocal.ListPatronOrigin)
                {
                    //so sánh Z308_REC_KEY(barcode) với mã sinh viên
                    //nếu = true, thì thêm vào danh sách ListAlreadyExists
                    if (Z308_REC_KEY.Equals(item2.MaSV_O))
                    {
                        item2.pationID = item.Z308_ID;
                        DataDBLocal.ListAlreadyExists.Add(item2);
                    }
                }
            }
            //Xóa các patron đã tồn tại ra khỏi danh sách
            foreach (PatronEntity s in DataDBLocal.ListAlreadyExists)
            {
                //tìm kiếm vị trí của từng patron id đã tồn tại
                int index = DataDBLocal.ListPatronOrigin.FindIndex((PatronEntity dsd) => dsd.MaSV_O.Equals(s.MaSV_O));
                //xóa patron ra khỏi danh sách
                DataDBLocal.ListPatronNew.RemoveAt(index);
            }
        }

        //Lọc ra các mã không tồn tại và tồn tại
        public void CompreRemovePatronListNotExist()
        {
            List<string> ListExcelBarcode = DataDBLocal.ListExcelBarcode.CloneObject();
            DataDBLocal.ListExcelBarcodeNotExist = DataDBLocal.ListExcelBarcode.CloneObject();
            //List<Z308> ListExcelAlreadyExists = new List<Z308>();
            DataDBLocal.ListAlreadyExists = new List<PatronEntity>();
            List<Z308> listZ308 = DataDBLocal.listZ308.CloneObject();

            if (ListExcelBarcode != null && ListExcelBarcode.Count > 0)
            {
                //Lọc các patron tồn tại
                // => lấy ra các danh tồn tại
                foreach (Z308 item in listZ308)
                {
                    string Z308_REC_KEY = item.Z308_REC_KEY.Trim();
                    //loại bỏ 2 ký tự đầu của Z308_REC_KEY
                    Z308_REC_KEY = Z308_REC_KEY.Substring(2);

                    foreach (string maSV in ListExcelBarcode)
                    {
                        //so sánh Z308_REC_KEY(barcode) với mã sinh viên
                        //nếu = true, thì thêm vào danh sách ListAlreadyExists
                        if (Z308_REC_KEY.Equals(maSV))
                        {
                            //item.Z308_REC_KEY = maSV;
                            //ListExcelAlreadyExists.Add(item);
                            PatronEntity p = new PatronEntity();
                            p.MaSV_O = maSV;
                            p.HoTen = item.Z308_ENCRYPTION;
                            DataDBLocal.ListAlreadyExists.Add(p);
                        }
                    }
                }
                //Xóa các patron đã tồn tại ra khỏi danh sách
                //Để được danh sách không tồn tại
                foreach (PatronEntity item in DataDBLocal.ListAlreadyExists)
                {
                    //tìm kiếm vị trí của từng patron id đã tồn tại
                    int index = ListExcelBarcode.FindIndex((string maSV) => maSV.Equals(item.MaSV_O));
                    //xóa patron ra khỏi danh sách
                    DataDBLocal.ListExcelBarcodeNotExist.RemoveAt(index);
                }
            }
        }
    }
}
