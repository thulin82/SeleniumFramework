using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeleniumFramework.Helpers
{
    public class LogHelpers
    {
        private static string _logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter _streamWriter = null;

        public static void CreateLogFile()
        {
            string dir = Directory.GetCurrentDirectory();

            if (Directory.Exists(dir))
            {
                _streamWriter = File.AppendText(dir + Path.DirectorySeparatorChar + _logFileName + ".log");
            }
            else
            {
                Directory.CreateDirectory(dir);
                _streamWriter = File.AppendText(dir + Path.DirectorySeparatorChar + _logFileName + ".log");
            }
        }

        public static void WriteToFile(string logMessage)
        {
            _streamWriter.Write("{0} {1} ", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
            _streamWriter.WriteLine("{0}", logMessage);
            _streamWriter.Flush();
        }
    }
}
