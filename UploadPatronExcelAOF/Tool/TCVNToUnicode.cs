namespace UploadPatronExcelAOF.Tool
{
    internal class TCVNToUnicode
    {
        private static char[] tcvnchars;

        private static char[] unichars;

        private static char[] convertTable;

        static TCVNToUnicode()
        {
            tcvnchars = new char[74]{'µ','\u00b8','¶','·','¹','\u00a8','»','¾','¼','½','Æ','©','Ç','Ê','È','É','Ë','®','Ì','Ð','Î','Ï','Ñ','ª','Ò','Õ','Ó','Ô','Ö',
                '×','Ý','Ø','Ü','Þ','ß','ã','á','â','ä','«','å','è','æ','ç','é','¬','ê','í','ë','ì','î','ï','ó','ñ','ò','ô','­','õ','ø', 'ö','÷','ù','ú','ý','û','ü',
                'þ','¡','¢','§','£','¤','¥','¦'            };
            unichars = new char[74]{'à','á','ả','ã','ạ','ă','ằ','ắ','ẳ','ẵ','ặ','â','ầ','ấ','ẩ','ẫ','ậ','đ','è','é','ẻ','ẽ','ẹ','ê','ề','ế','ể','ễ','ệ','ì','í','ỉ',
                                    'ĩ','ị','ò','ó','ỏ','õ','ọ','ô','ồ','ố','ổ','ỗ','ộ','ơ','ờ','ớ','ở','ỡ','ợ','ù','ú','ủ','ũ','ụ','ư','ừ','ứ','ử','ữ','ự','ỳ','ý',
                                    'ỷ','ỹ','ỵ','Ă','Â','Đ','Ê','Ô','Ơ','Ư'};

            convertTable = new char[256];
            for (int i = 0; i < 256; i++)
            {
                convertTable[i] = (char)i;
            }
            for (int j = 0; j < tcvnchars.Length; j++)
            {
                convertTable[tcvnchars[j]] = unichars[j];
            }
        }

        public static string convertTCVN3ToUnicode(string value)
        {
            char[] array = value.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 'Ā')
                {
                    array[i] = convertTable[array[i]];
                }
            }
            return new string(array);
        }
    }
}
