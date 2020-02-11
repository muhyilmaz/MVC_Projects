using System;
using System.IO;
using System.Text;

namespace Logger
{
    public sealed class Log : ILog
    {
        
        private static Log instance = null;
        private static readonly object obj = new object();
        public static Log GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new Log();

                        }
                    }
                }


                return instance;
            }
        }
        private Log()
        {
           
        }

        public void LogException(string message)
        {
            string fileName = string.Format("{0}_{1}", "Exception", DateTime.Now.ToShortDateString());
            string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("----------------------------------------");
            stringBuilder.AppendLine(DateTime.Now.ToString());
            stringBuilder.AppendLine(message);

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(stringBuilder.ToString());
                writer.Flush();
            }
        }



        //public class DerivatedSingleton : Singleton
        //{

        //}
    }
}
