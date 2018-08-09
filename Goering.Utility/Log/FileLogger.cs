using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goering.Utility.Log
{
    public static class FileLogger
    {
        static FileLogger()
        {

        }

        /// <summary>
        /// 记录日志到文件
        /// </summary>
        /// <param name="message"></param>
        public static void WriteLog(string message)
        {
            try
            {
                if (!Directory.Exists(@"" + AppDomain.CurrentDomain.BaseDirectory + "/Log/"))
                {
                    Directory.CreateDirectory(@"" + AppDomain.CurrentDomain.BaseDirectory + "/Log");
                }

                string logFileName = @"" + AppDomain.CurrentDomain.BaseDirectory + "/Log/" + DateTime.Now.ToString("yyyyMMdd") + ".txt"; // 文件路径
                FileInfo fileinfo = new FileInfo(logFileName);

                using (FileStream fs = fileinfo.OpenWrite())
                {
                    StreamWriter sw = new StreamWriter(fs);
                    sw.BaseStream.Seek(0, SeekOrigin.End);
                    sw.WriteLine("=====================================");
                    sw.Write("日志时间为:" + DateTime.Now.ToString() + "\r\n");
                    sw.Write("日志内容为:" + message + "\r\n");
                    sw.WriteLine("=====================================");
                    sw.WriteLine("");
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
