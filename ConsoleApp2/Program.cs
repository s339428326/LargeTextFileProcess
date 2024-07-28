using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotenv.net;
using dotenv.net.Utilities;
using System.Collections;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Controller.File.EnvInit(); //設置環境檔案
            string PROG_ENV = Controller.GetEnvValue("PROG_ENV");
            Console.WriteLine($"目前執行環境為:{PROG_ENV}");

            if (PROG_ENV == "DEV") Console.ReadKey();
        }

    }
}
