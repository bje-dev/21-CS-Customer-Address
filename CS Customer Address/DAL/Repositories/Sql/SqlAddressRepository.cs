using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Sql
{

    internal sealed class Singleton
    {
        private readonly static Singleton _instance = new Singleton();

        public static Singleton Current
        {
            get
            {
                return _instance;
            }
        }

        private Singleton()
        {
            //Implent here the initialization of your singleton
        }
    }

  
}
