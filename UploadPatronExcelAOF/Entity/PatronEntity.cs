using System.ComponentModel;
namespace UploadPatronExcelAOF.Entity
{
    public class PatronEntity
    {
        [DisplayName("PatronID")]
        public string pationID
        {
            get;
            set;
        }
        [DisplayName("Mã Sinh Viên")]
        public string MaSV_O
        {
            get;
            set;
        }
        [DisplayName("Họ tên")]
        public string HoTen
        {
            get;
            set;
        }
        [DisplayName("Giới tính")]
        public string gioiTinh
        {
            get;
            set;
        }
        [DisplayName("Ngày sinh")]
        public string ngaySinh
        {
            get;
            set;
        }
        [DisplayName("Địa chỉ")]
        public string DiaChi
        {
            get;
            set;
        }
        [DisplayName("Ngày")]
        public string Day
        {
            get;
            set;
        }
        public string Day4
        {
            get;
            set;
        }

        [DisplayName("Khóa học")]
        public string khoaHoc
        {
            get;
            set;
        }
        [DisplayName("Khoa")]
        public string Khoa
        {
            get;
            set;
        }
        [DisplayName("lớp học")]
        public string lopHoc
        {
            get;
            set;
        }
        [DisplayName("Số điện thoại")]
        public string phone
        {
            get;
            set;
        }
        [DisplayName("Email")]
        public string email
        {
            get;
            set;
        }
        [DisplayName("Mật khẩu")]
        public string password
        {
            get;
            set;
        }
        [DisplayName("Ngày hết hạn")]
        public string NgayHetHan
        {
            get;
            set;
        }
    }
}
