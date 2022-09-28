using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Software_II_C969_Dainen_Mann
{
    class Logger
    {
        private static DateTime? _time;
        private static readonly ReaderWriterLockSlim rwl = new ReaderWriterLockSlim();
        public static void SetTime(DateTime? Time)
        {
            _time = Time;
        }
        public static DateTime? GetTime()
        {
            return _time;
        }

        // This creates a text file for logging purposes.
        public static void WriteUserLoginLog(string userName)
        {

            FileStream outp = new FileStream("log.txt", FileMode.Append, FileAccess.Write);
            using (StreamWriter sr = new StreamWriter(outp))
            {
                sr.WriteLine("User Name: " + userName + " Logged in at : " + DateTime.Now.ToString());
                sr.Close();
            }
        }
        public static void LogMessage(String logName, String LogMessage, String logType, String msgSource)
        {
            String dirPath = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\') + "\\logs\\";
            String filePath = dirPath + logName + "_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

            Directory.CreateDirectory(dirPath);
            try
            {
                rwl.EnterWriteLock();
                switch (logType)
                {
                    case "log":
                        using (StreamWriter sw = File.AppendText(filePath))
                        {
                            sw.WriteLine(String.Format("{0:G} ({2}): {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:"), LogMessage, msgSource));
                        }
                        break;
                    case "error":
                        using (StreamWriter sw = File.AppendText(filePath))
                        {
                            sw.WriteLine(String.Format("{0:G} ({2}): Exception: {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:"), LogMessage, msgSource));
                        }
                        break;
                }
            }
            finally
            {
                rwl.ExitWriteLock();
            }
        }
    }
}
