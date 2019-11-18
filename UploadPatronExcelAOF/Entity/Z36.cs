using System.Collections.Generic;

namespace UploadPatronExcelAOF.Entity
{
	public class Z36 : Z31
	{
		public string Z36_ID
		{
			get;
			set;
		}

		public string PatronBarcode
		{
			get;
			set;
		}

		public string barcode
		{
			get;
			set;
		}

		public string hoTen
		{
			get;
			set;
		}

		public string nhanDe
		{
			get;
			set;
		}

		public string Z36_LOAN_DATE
		{
			get;
			set;
		}

		public static List<Z36> listMuonTraZ36
		{
			get;
			set;
		}

		public override int CompareTo(object obj)
		{
			Z36 z = obj as Z36;
			if (string.Compare(barcode.ToString(), z.barcode.ToString(), ignoreCase: true) == 1)
			{
				return 1;
			}
			if (string.Compare(barcode.ToString(), z.barcode.ToString(), ignoreCase: true) == 0)
			{
				return 0;
			}
			return -1;
		}
	}
}
