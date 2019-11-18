using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace UploadPatronExcelAOF.DBConnect
{
	internal class DBConnecting
	{
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static OracleConnection conn = null;
        public DBConnecting()
        {
            log4net.Config.BasicConfigurator.Configure();
            log.Info("");
        }
		public static OracleConnection GetDBConnection(DataOracle oracle)
		{
			Console.WriteLine("Getting Connection ...");
			string connectionString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = " + oracle.host + ")(PORT = " + oracle.port + "))(CONNECT_DATA = (SID = " + oracle.sid + ")));Persist Security Info=true;User ID=" + oracle.user + "; Password=" + oracle.password + ";";
			conn = new OracleConnection();
			conn.ConnectionString = connectionString;
			return conn;
		}

		public OracleDataReader GetDataReader(string sql)
		{
			OracleDataReader result = null;
			try
			{
				if (conn != null && conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}
                using (OracleCommand oracleCommand = new OracleCommand())
                {
                    oracleCommand.CommandTimeout = 60;
                    oracleCommand.Connection = conn;
                    oracleCommand.CommandText = sql;
                    result = oracleCommand.ExecuteReader();
                    oracleCommand.Dispose();
                    //Console.WriteLine("Connection...");
                    log.Info("Connection...");
                }                    
            }
			catch (OracleException ex)
			{
				Console.WriteLine("Error: " + ex.Message);
                log.Error(ex.Message);
            }
			return result;
		}

		public static void CloseConnection()
		{
			try
			{
				conn.Dispose();
				conn.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
                log.Error(ex.Message);
            }
		}
	}
}
