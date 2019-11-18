using System;
using System.Collections.Generic;

namespace UploadPatronExcelAOF.Entity
{
	public class Z31 : IComparable
	{
		public string Z31_REC_KEY
		{
			get;
			set;
		}

		public string Z31_DESCRIPTION
		{
			get;
			set;
		}

		public string Z31_KEY
		{
			get;
			set;
		}

		public string Z31_NET_SUM
		{
			get;
			set;
		}

		public static List<Z31> listZ31
		{
			get;
			set;
		}

		public virtual int CompareTo(object obj)
		{
			Z31 z = obj as Z31;
			if (string.Compare(Z31_REC_KEY.ToString(), z.Z31_REC_KEY.ToString(), ignoreCase: true) == 1)
			{
				return 1;
			}
			if (string.Compare(Z31_REC_KEY.ToString(), z.Z31_REC_KEY.ToString(), ignoreCase: true) == 0)
			{
				return 0;
			}
			return -1;
		}
	}
}
