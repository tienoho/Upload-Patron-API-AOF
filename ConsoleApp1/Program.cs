using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string url = "UrlLdap=LDAP://10.2.201.18:389";
            Console.WriteLine(url);

            int numberStart = url.IndexOf("LDAP://") + 7;
            Console.WriteLine(numberStart);

            int numberEnd = url.LastIndexOf(":");
            Console.WriteLine(numberEnd);

            string hostUri = url.Substring(numberStart, numberEnd - numberStart);

            Console.WriteLine(hostUri);
            int portNumber = int.Parse(url.Substring(numberEnd + 1));
            Console.WriteLine(portNumber);

            //int n = 0, m = 0;
            //int sumDamage = 0;
            //Console.Write("Nhập n và m:");
            //do
            //{
            //    string twoNumber = Console.ReadLine();
            //    n = int.Parse(twoNumber.Split(' ')[0]);
            //    m = int.Parse(twoNumber.Split(' ')[1]);
            //    Console.WriteLine($"n={n},n={m}");

            //} while (0 > n && n > 100 && 0 > m && m > 100);

            //string[] baiCuaBinh = new string[n];
            //string[] baiCuaAn = new string[m];

            //Console.WriteLine("Nhập thông tin số bài của Bình:");
            //for (int i = 0; i < n; i++)
            //{
            //    int str = 0;
            //    do
            //    {
            //        baiCuaBinh[i] = Console.ReadLine();
            //        str = int.Parse(baiCuaBinh[i].Split(' ')[1]);
            //    } while (0 > str && str > 8000);

            //}
            //Console.WriteLine("Nhập thông tin số bài của An:");
            //for (int i = 0; i < m; i++)
            //{
            //    int str = 0;
            //    do
            //    {
            //        baiCuaAn[i] = Console.ReadLine();
            //        str = int.Parse(baiCuaAn[i]);
            //    } while (0 > str && str > 8000);

            //}
            ////
            //int luotBai = 0;
            //for (int i = 0; i < m; i++)
            //{
            //    //for(int y = i; y < n; y++)
            //    //{

            //    //}
            //    int STRAn = int.Parse(baiCuaAn[i]);
            //    if (luotBai == n)
            //    {
            //        sumDamage += STRAn;
            //        break;
            //    }
            //    else
            //    {
            //        string viTri = baiCuaBinh[luotBai].Split(' ')[0];
            //        int STRBinh = int.Parse(baiCuaBinh[luotBai].Split(' ')[1]);

            //        switch (viTri)
            //        {
            //            case "ATK":
            //                if (STRAn >= STRBinh)
            //                {
            //                    sumDamage += STRAn - STRBinh;
            //                    luotBai++;
            //                }
            //                break;
            //            case "DEF":
            //                if (STRAn > STRBinh)
            //                {
            //                    //sumDamage += STRAn - STRBinh;
            //                    luotBai++;
            //                }
            //                break;
            //        }
            //    }
            //}
            //Console.Write($"Damage phải nhận: {sumDamage}");
            //string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\UploadPatronLog";
            //Console.Write(pathUser);
            //CreateFolder(pathUser);

            Console.ReadKey();
        }
        private static void CreateFolder(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }
    }
}
