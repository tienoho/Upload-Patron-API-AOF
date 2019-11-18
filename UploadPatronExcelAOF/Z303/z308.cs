using System.Text;
using UploadPatronExcelAOF.Entity;

namespace UploadPatronExcelAOF.Z303
{
	internal class z308
	{
		public string tab8(PatronEntity patronEntity)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<z308>");
			stringBuilder.Append("<record-action>A</record-action>");
			stringBuilder.Append("<z308-key-type>00</z308-key-type>");
			stringBuilder.Append("<z308-key-data>" + patronEntity.pationID + "</z308-key-data>");
			stringBuilder.Append("<z308-user-library></z308-user-library>");
			stringBuilder.Append("<z308-verification>" + patronEntity.password + "</z308-verification>");
			stringBuilder.Append("<z308-verification-type>00</z308-verification-type>");
			stringBuilder.Append("<z308-id>" + patronEntity.pationID + "</z308-id>");
			stringBuilder.Append("<z308-status>AC</z308-status>");
			stringBuilder.Append("<z308-encryption>H</z308-encryption>");
			stringBuilder.Append("</z308>");
			stringBuilder.Append("<z308>");
			stringBuilder.Append("<record-action>A</record-action>");
			stringBuilder.Append("<z308-key-type>01</z308-key-type>");
			stringBuilder.Append("<z308-key-data>" + patronEntity.MaSV_O + "</z308-key-data>");
			stringBuilder.Append("<z308-user-library></z308-user-library>");
			stringBuilder.Append("<z308-verification>" + patronEntity.password + "</z308-verification>");
			stringBuilder.Append("<z308-verification-type>00</z308-verification-type>");
			stringBuilder.Append("<z308-id>" + patronEntity.pationID + "</z308-id>");
			stringBuilder.Append("<z308-status>AC</z308-status>");
			stringBuilder.Append("<z308-encryption>H</z308-encryption>");
			stringBuilder.Append("</z308>");
			return stringBuilder.ToString();
		}
	}
}
