using log4net;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //protected static readonly ILog log = LogManager.GetLogger(typeof(Program));
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            log.Debug("Debug level");
            log.Info("Info level");
            log.Warn("Warn level");
            log.Error("Error level");
            log.Fatal("Fatal level");

            Console.ReadLine();
        }
    }
}
