using System.Text;
using UploadPatronExcelAOF.Entity;

namespace UploadPatronExcelAOF.Z303
{
	internal class z304
	{
		public string tab4(PatronEntity patronEntity)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<z304>");
			stringBuilder.Append("<record-action>A</record-action>");
			stringBuilder.Append("<email-address>" + patronEntity.email + "</email-address>");
			stringBuilder.Append("<z304-id>" + patronEntity.pationID + "</z304-id>");
			stringBuilder.Append("<z304-sequence>01</z304-sequence>");
			stringBuilder.Append("<z304-address-0>" + patronEntity.gioiTinh + " " + patronEntity.HoTen + "</z304-address-0>");
			stringBuilder.Append("<z304-address-1>" + patronEntity.DiaChi + "</z304-address-1>");
			stringBuilder.Append("<z304-zip></z304-zip>");
			stringBuilder.Append("<z304-email-address>" + patronEntity.email + "</z304-email-address>");
			stringBuilder.Append("<z304-telephone>" + patronEntity.phone + "</z304-telephone>");
			stringBuilder.Append("<z304-date-from>" + patronEntity.Day + "</z304-date-from>");
			stringBuilder.Append("<z304-date-to>" + patronEntity.NgayHetHan + "</z304-date-to>");
			stringBuilder.Append("<z304-address-type>01</z304-address-type>");
			stringBuilder.Append("<z304-telephone-2></z304-telephone-2>");
			stringBuilder.Append("<z304-telephone-3></z304-telephone-3>");
			stringBuilder.Append("<z304-telephone-4></z304-telephone-4>");
			stringBuilder.Append("<z304-sms-number></z304-sms-number>");
			stringBuilder.Append("<z304-update-date>" + patronEntity.Day + "</z304-update-date>");
			stringBuilder.Append("<z304-cat-name>MASTER</z304-cat-name>");
			stringBuilder.Append("</z304>");
			return stringBuilder.ToString();
		}
	}
}
