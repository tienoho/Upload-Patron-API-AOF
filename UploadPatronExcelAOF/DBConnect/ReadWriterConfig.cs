using System.IO;
using UploadPatronExcelAOF.API;
using UploadPatronExcelAOF.Entity;

namespace UploadPatronExcelAOF.DBConnect
{
	internal class ReadWriterConfig
	{
		public DataOracle oracle = null;

		public Aleph aleph = null;

		public string ReadConfig()
		{
			string[] array = File.ReadAllLines("ConfigConnect");
			return array[0].Trim();
		}

		public DataOracle ReadConfigDataBase()
		{
			using (StreamReader streamReader = new StreamReader("ConfigConnect"))
			{
				oracle = new DataOracle();
				string text;
				while ((text = streamReader.ReadLine()) != null)
				{
					if (text.Contains("="))
					{
						string text2 = text.Substring(0, text.IndexOf("="));
						switch (text2.ToLower())
						{
						case "host":
							oracle.host = getField(text);
							break;
						case "port":
							oracle.port = getField(text);
							break;
						case "sid":
							oracle.sid = getField(text);
							break;
						case "user":
							oracle.user = getField(text);
							break;
						case "password":
							oracle.password = getField(text);
							break;
						}
					}
				}
			}
			return oracle;
		}

		public Aleph ReadConfigAleph()
		{
			using (StreamReader streamReader = new StreamReader("ConfigConnect"))
			{
				aleph = new Aleph();
				string text;
				while ((text = streamReader.ReadLine()) != null)
				{
					if (text.Contains("="))
					{
						string text2 = text.Substring(0, text.IndexOf("="));
						switch (text2.ToLower())
						{
						case "urlaleph":
							aleph.UrlAleph = getField(text);
							break;
						case "library":
							aleph.Library = getField(text);
							break;
						case "updateflag":
							aleph.UpdateFlag = getField(text);
							break;
						}
					}
				}
			}
			return aleph;
		}


		public ReadWriterConfig()
		{
			if (!File.Exists("ConfigConnect"))
			{
				using (StreamWriter streamWriter = new StreamWriter("ConfigConnect"))
				{
					streamWriter.WriteLine("#DataBase");
					streamWriter.WriteLine("host=catlib.vnua.edu.vn");
					streamWriter.WriteLine("port=1521");
					streamWriter.WriteLine("sid=aleph23");
					streamWriter.WriteLine("user=aleph_dba");
					streamWriter.WriteLine("password=aleph_dba");
					streamWriter.WriteLine("#Aleph");
					streamWriter.WriteLine("UrlAleph=http://catlib.vnua.edu.vn");
					streamWriter.WriteLine("Library=library=LDC50");
					streamWriter.WriteLine("UpdateFlag=update_flag=N");
				}
			}
		}

		public string getField(string str)
		{
			if (str.Contains("="))
			{
				int num = str.IndexOf("=");
				str = str.Substring(num + 1, str.Length - (num + 1));
			}
			return str.Trim();
		}
	}
}


