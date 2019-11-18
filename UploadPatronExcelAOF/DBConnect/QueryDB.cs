using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using UploadPatronExcelAOF.Entity;
using UploadPatronExcelAOF.Tool;

namespace UploadPatronExcelAOF.DBConnect
{
    internal class QueryDB
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public QueryDB()
        {
            log4net.Config.BasicConfigurator.Configure();
            log.Debug("");
        }
        public List<Z308> GetListZ308()
        {
            var listZ308 = new List<Z308>(TotalRecordsZ308());
            string sql = "SELECT * FROM LDC00.Z308,LDC00.Z303 where Z308.Z308_ID=Z303.Z303_REC_KEY and Z308.Z308_REC_KEY like'01%'";
            try
            {
                using (OracleDataReader oracleDataReader = new DBConnecting().GetDataReader(sql))
                {
                    while (oracleDataReader.Read())
                    {
                        var z308 = new Z308();
                        z308.Z308_REC_KEY = oracleDataReader["Z308_REC_KEY"].ToString().Trim();
                        z308.Z308_VERIFICATION = oracleDataReader["Z308_VERIFICATION"].ToString().Trim();
                        z308.Z308_VERIFICATION_TYPE = oracleDataReader["Z308_VERIFICATION_TYPE"].ToString().Trim();
                        z308.Z308_ID = oracleDataReader["Z308_ID"].ToString().Trim();
                        z308.Z308_STATUS = oracleDataReader["Z308_STATUS"].ToString().Trim();
                        z308.Z308_ENCRYPTION = oracleDataReader["Z303_NAME"].ToString().Trim();
                        z308.Z308_UPD_TIME_STAMP = oracleDataReader["Z308_UPD_TIME_STAMP"].ToString().Trim();
                        listZ308.Add(z308);
                    }
                }
            }
            catch (OracleException ex)
            {
                log.Error(ex.Message);
            }
            return listZ308;
        }
        public List<Z305> GetListZ305()
        {
            var listZ305 = new List<Z305>();
            string sql = "SELECT Z305_REC_KEY,Z305_DELINQ_1 FROM LDC50.Z305 WHERE Z305_REC_KEY Like '%LDC  ' AND Z305_DELINQ_1!=5";
            try
            {
                using (OracleDataReader oracleDataReader = new DBConnecting().GetDataReader(sql))
                {
                    while (oracleDataReader.Read())
                    {
                        var z305 = new Z305();
                        z305.Z305_REC_KEY = oracleDataReader["Z305_REC_KEY"].ToString().Replace("LDC", "").Trim();
                        z305.Z305_DELINQ_1 = oracleDataReader["Z305_DELINQ_1"].ToString().Trim();
                        listZ305.Add(z305);
                    }
                    listZ305.Sort();
                }
            }
            catch (OracleException ex)
            {
                log.Error(ex.Message);
            }
            return listZ305;
        }
        public List<Z36> GetListZ36()
        {
            var listZ36 = new List<Z36>();
            string sql = "SELECT * FROM LDC50.Z36";
            try
            {
                using (OracleDataReader oracleDataReader = new DBConnecting().GetDataReader(sql))
                {
                    while (oracleDataReader.Read())
                    {
                        Z36 z = new Z36();
                        z.Z31_REC_KEY = oracleDataReader["Z36_REC_KEY"].ToString().Trim();
                        z.Z36_ID = oracleDataReader["Z36_ID"].ToString().Trim();
                        z.Z36_LOAN_DATE = oracleDataReader["Z36_LOAN_DATE"].ToString().Trim();
                        listZ36.Add(z);
                    }
                }
            }
            catch (OracleException ex)
            {
                log.Error(ex.Message);
            }
            return listZ36;
        }

        public List<Z31> listZ31()
        {
            List<Z31> list = new List<Z31>();
            string sql = "SELECT * FROM LDC50.Z31 where Z31.Z31_STATUS like 'O'";
            using (OracleDataReader oracleDataReader = new DBConnecting().GetDataReader(sql))
            {
                while (oracleDataReader.Read())
                {
                    Z31 z = new Z31();
                    string text = oracleDataReader["Z31_REC_KEY"].ToString().Trim();
                    z.Z31_REC_KEY = text.Substring(0, 12).Trim();
                    z.Z31_DESCRIPTION = oracleDataReader["Z31_DESCRIPTION"].ToString().Trim();
                    z.Z31_KEY = oracleDataReader["Z31_KEY"].ToString().Trim();
                    z.Z31_NET_SUM = oracleDataReader["Z31_NET_SUM"].ToString().Trim();
                    list.Add(z);
                }
                // oracleDataReader.Close();
                //DBConnecting.conn.Close();
            }
            return list;
        }

        public List<Z30> listZ30()
        {
            List<Z30> list = new List<Z30>();
            string sql = "SELECT * FROM LDC50.Z30";
            using (OracleDataReader oracleDataReader = new DBConnecting().GetDataReader(sql))
            {
                while (oracleDataReader.Read())
                {
                    Z30 z = new Z30();
                    z.Z30_REC_KEY = oracleDataReader["Z30_REC_KEY"].ToString().Trim();
                    z.Z30_BARCODE = oracleDataReader["Z30_BARCODE"].ToString().Trim();
                    z.Z30_SUB_LIBRARY = oracleDataReader["Z30_SUB_LIBRARY"].ToString().Trim();
                    list.Add(z);
                }
                //oracleDataReader.Close();
                //DBConnecting.conn.Close();
            }
            return list;
        }

        public List<Z00> listZ00()
        {
            List<Z00> list = new List<Z00>();
            string sql = "SELECT * FROM LDC01.Z00";
            using (OracleDataReader oracleDataReader = new DBConnecting().GetDataReader(sql))
            {
                while (oracleDataReader.Read())
                {
                    Z00 z = new Z00();
                    z.Z00_DOC_NUMBER = oracleDataReader["Z00_DOC_NUMBER"].ToString().Trim();
                    z.Z00_NO_LINES = oracleDataReader["Z00_NO_LINES"].ToString().Trim();
                    z.Z00_DATA_LEN = oracleDataReader["Z00_DATA_LEN"].ToString().Trim();
                    z.Z00_DATA = oracleDataReader["Z00_DATA"].ToString().Trim();
                    list.Add(z);
                }
                //oracleDataReader.Close();
                // DBConnecting.conn.Close();
            }
            return list;
        }

        public List<Z00R> listZ00R()
        {
            List<Z00R> list = new List<Z00R>();
            string sql = "SELECT Z00R_DOC_NUMBER,Z00R_TEXT FROM LDC01.Z00R where Z00R.Z00R_FIELD_CODE like '245%'";
            using (OracleDataReader oracleDataReader = new DBConnecting().GetDataReader(sql))
            {
                while (oracleDataReader.Read())
                {
                    Z00R z00R = new Z00R();
                    z00R.Z00R_DOC_NUMBER = oracleDataReader["Z00R_DOC_NUMBER"].ToString().Trim();
                    z00R.Z00R_TEXT = oracleDataReader["Z00R_TEXT"].ToString().Trim();
                    list.Add(z00R);
                }
                //oracleDataReader.Close();
                //DBConnecting.conn.Close();
            }
            return list;
        }
        public int GetLastPatronId()
        {
            int result = 0;
            string sql = "SELECT Z308_ID FROM (SELECT Z308_ID FROM LDC00.Z308 where Z308_ID like '000%' and Z308_REC_KEY like '01%' order by TO_NUMBER(Z308_ID) desc) WHERE ROWNUM <= 1";
            try
            {
                using (OracleDataReader oracleDataReader = new DBConnecting().GetDataReader(sql))
                {
                    while (oracleDataReader.Read())
                    {
                        result = int.Parse(oracleDataReader["Z308_ID"].ToString().Trim());
                    }
                }
            }
            catch (OracleException ex)
            {
                log.Error(ex.Message);
            }
            return result;
        }
        public int TotalRecordsZ308()
        {
            int result = 0;
            string sql = "SELECT COUNT(Z308.Z308_ID) as COUNT FROM LDC00.Z308,LDC00.Z303 where Z308.Z308_ID=Z303.Z303_REC_KEY and Z308.Z308_REC_KEY like'01%'";
            try
            {
                using (OracleDataReader oracleDataReader = new DBConnecting().GetDataReader(sql))
                {
                    while (oracleDataReader.Read())
                    {
                        result = int.Parse(oracleDataReader["COUNT"].ToString().Trim());
                    }
                }
            }
            catch (OracleException ex)
            {
                log.Error(ex.Message);
            }
            return result;
        }
        public bool CheckBarcode(string barcode)
        {
            bool result = false;
            string sql = "SELECT Z308_REC_KEY FROM LSP00.Z308 where Z308.Z308_REC_KEY like'01" + barcode + "%'";
            try
            {
                using (OracleDataReader oracleDataReader = new DBConnecting().GetDataReader(sql))
                {
                    if (oracleDataReader.Read())
                    {
                        result = true;
                    }
                }
            }
            catch (OracleException ex)
            {
                log.Error(ex.Message);
            }
            return result;
        }
    }
}
