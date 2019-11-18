using System.Net;

namespace UploadPatronExcelAOF.DBConnect
{
	internal class CheckUrl
	{
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public bool CheckUrlExist(string url)
		{
            log4net.Config.BasicConfigurator.Configure();
            log.Info("");
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.Timeout = 15000;
			httpWebRequest.Method = "HEAD";
			try
			{
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    log.Info(url + "\t"+httpWebResponse.StatusCode);
                    return httpWebResponse.StatusCode == HttpStatusCode.OK;
				}
			}
			catch (WebException we)
			{
                log.Error(we.Message);
                return false;
			}
		}
	}
}
