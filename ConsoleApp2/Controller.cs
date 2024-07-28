using dotenv.net;
using System;
using System.Collections.Generic;
using System.IO;


namespace ConsoleApp2
{
    internal class Controller
    {
        //[GET ENV]
        public static string GetEnvValue(string key)
        {
            return Environment.GetEnvironmentVariable(key);
        }



        //FileController
        public class File
        {
            //任務紀錄
            class TaskStatus
            {
                public string TaskStartDate { get; set; } //任務開始時間
                public string TaskEndDate { get; set; } //任務結束食間
                public string FileName { get; set; } //文件檔案名稱
                public string Status { get; set; } //目前狀態

                public TaskStatus()
                {
                    this.TaskStartDate = TaskStartDate;
                    this.TaskEndDate = TaskEndDate;
                    this.FileName = FileName;
                    this.Status = Status;
                }
            }

            //[JSON] 
            public static string JSONInit()
            {
                //witeFile
                TaskStatus task = new TaskStatus();   

                return string.Empty;
            }






            //[Env] 
            public static void EnvInit()
            {
                DotEnv.Load(options: new DotEnvOptions(envFilePaths: new[] { $"{Directory.GetCurrentDirectory()}/.env" }));
                string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
                var envVars = DotEnv.Read();

                //[TEST] 輸出當前資料夾路徑
                Console.WriteLine($"The current directory is {Directory.GetCurrentDirectory()}");


                //[TEST] 輸出當前資料夾底下所有檔案名稱
                foreach (string file in files)
                {
                    Console.WriteLine(Path.GetFileName(file));
                }

                //[TEST] 讀取 .env 設置環境變數
                foreach (KeyValuePair<string, string> file in envVars)
                {
                    Console.WriteLine(file);
                }
            }
        }


    }
}
