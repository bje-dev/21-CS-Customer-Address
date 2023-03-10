using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Services
{

    public sealed class LoggerManager
    {
        private readonly static LoggerManager _instance = new LoggerManager();


        public static LoggerManager Current
        {
            get
            {
                return _instance;
            }
        }

        private string filePath;

        private LoggerManager()
        {
            //Implent here the initialization of your singleton

            filePath = ConfigurationManager.AppSettings["filePathLogger"];
        }

        //LoggerManager.Current.Write("Pasando por X", EventLevel.Informational);



        public void Write(string message, EventLevel eventLevel)
        {


            using (StreamWriter streamWriter = new StreamWriter(filePath, true))
            {

                streamWriter.WriteLine($"{DateTime.Now.ToString("dd.MM.yy hh:mm:ss")} [Severity {eventLevel.ToString()}]:{message}");


            }
        }



    }

}
