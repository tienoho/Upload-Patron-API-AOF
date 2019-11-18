using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using UploadPatronExcelAOF.Entity;

namespace UploadPatronExcelAOF.Z303
{
	internal class z303
	{
		public string tab3(PatronEntity patronEntity)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<z303>");
			stringBuilder.Append("<match-id-type>00</match-id-type>");
			stringBuilder.Append("<match-id>" + patronEntity.pationID + "</match-id>");
			stringBuilder.Append("<record-action>A</record-action>");
			stringBuilder.Append("<z303-id>" + patronEntity.pationID + "</z303-id>");
			stringBuilder.Append("<z303-proxy-for-id></z303-proxy-for-id>");
			stringBuilder.Append("<z303-primary-id></z303-primary-id>");
			stringBuilder.Append("<z303-name-key>" + addNameKey(patronEntity.HoTen) + patronEntity.pationID + "</z303-name-key>");
			stringBuilder.Append("<z303-user-type></z303-user-type>");
			stringBuilder.Append("<z303-user-library></z303-user-library>");
			stringBuilder.Append("<z303-open-date>" + patronEntity.Day + "</z303-open-date>");
			stringBuilder.Append("<z303-update-date>" + patronEntity.Day + "</z303-update-date>");
			stringBuilder.Append("<z303-con-lng>VIE</z303-con-lng>");
			stringBuilder.Append("<z303-alpha>L</z303-alpha>");
			stringBuilder.Append("<z303-name>" + patronEntity.HoTen + "</z303-name>");
			stringBuilder.Append("<z303-title>" + patronEntity.gioiTinh + "</z303-title>");
			stringBuilder.Append("<z303-delinq-1>00</z303-delinq-1>");
			stringBuilder.Append("<z303-delinq-n-1></z303-delinq-n-1>");
			stringBuilder.Append("<z303-delinq-1-update-date>" + patronEntity.Day + "</z303-delinq-1-update-date>");
			stringBuilder.Append("<z303-delinq-1-cat-name>MASTER</z303-delinq-1-cat-name>");
			stringBuilder.Append("<z303-delinq-2>00</z303-delinq-2>");
			stringBuilder.Append("<z303-delinq-n-2></z303-delinq-n-2>");
			stringBuilder.Append("<z303-delinq-2-update-date>20122203</z303-delinq-2-update-date>");
			stringBuilder.Append("<z303-delinq-2-cat-name>MASTER</z303-delinq-2-cat-name>");
			stringBuilder.Append("<z303-delinq-3>00</z303-delinq-3>");
			stringBuilder.Append("<z303-delinq-n-3></z303-delinq-n-3>");
			stringBuilder.Append("<z303-delinq-3-update-date>20122203</z303-delinq-3-update-date>");
			stringBuilder.Append("<z303-delinq-3-cat-name>MASTER</z303-delinq-3-cat-name>");
			stringBuilder.Append("<z303-budget></z303-budget>");
			stringBuilder.Append("<z303-profile-id>VNUA-LDC</z303-profile-id>");
			stringBuilder.Append("<z303-ill-library></z303-ill-library>");
			stringBuilder.Append("<z303-home-library></z303-home-library>");
			stringBuilder.Append("<z303-field-1></z303-field-1>");
			stringBuilder.Append("<z303-field-2></z303-field-2>");
			stringBuilder.Append("<z303-field-3></z303-field-3>");
			stringBuilder.Append("<z303-note-1></z303-note-1>");
			stringBuilder.Append("<z303-note-2></z303-note-2>");
			stringBuilder.Append("<z303-salutation></z303-salutation>");
			stringBuilder.Append("<z303-ill-total-limit>0000</z303-ill-total-limit>");
			stringBuilder.Append("<z303-ill-active-limit>0000</z303-ill-active-limit>");
			stringBuilder.Append("<z303-dispatch-library></z303-dispatch-library>");
			stringBuilder.Append("<z303-birth-date>" + patronEntity.ngaySinh + "</z303-birth-date>");
			stringBuilder.Append("<z303-export-consent>N</z303-export-consent>");
			stringBuilder.Append("<z303-proxy-id-type>00</z303-proxy-id-type>");
			stringBuilder.Append("<z303-send-all-letters>Y</z303-send-all-letters>");
			stringBuilder.Append("<z303-plain-html></z303-plain-html>");
			stringBuilder.Append("<z303-want-sms>N</z303-want-sms>");
			stringBuilder.Append("<z303-plif-modification></z303-plif-modification>");
			stringBuilder.Append("<z303-title-req-limit>0000</z303-title-req-limit>");
			stringBuilder.Append("<z303-gender>" + getGender(patronEntity.gioiTinh) + "</z303-gender>");
			stringBuilder.Append("<z303-birthplace></z303-birthplace>");
			stringBuilder.Append("</z303>");
			return stringBuilder.ToString();
		}

		private string addNameKey(string name)
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

		private string getGender(string inStr)
		{
			if (inStr.Equals("Mr."))
			{
				return "M";
			}
			return "F";
		}

		private string RemoveVietnameseMark(string str)
		{
			Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
			string input = str.Normalize(NormalizationForm.FormD);
			return regex.Replace(input, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
		}
	}
}
