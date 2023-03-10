using System;
using System.Collections.Generic;
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

        private LoggerManager()
        {
            //Implent here the initialization of your singleton
        }









    }

}
