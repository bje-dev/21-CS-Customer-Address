using DAL.Contracts;
using DAL.Repositories.File;
using DAL.Repositories.Sql;
using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{


    public sealed class Factory
    {
        private readonly static Factory _instance = new Factory();

        private readonly string backend;

        public static Factory Current
        {
            get
            {
                return _instance;
            }
        }

        private Factory()
        {
            //Implent here the initialization of your singleton
            backend = ConfigurationManager.AppSettings["backend"];

        }
    


    public IGenericRepository<Customer> GetCustomerRepository()

        {
            if (backend=="SQL")
            {
               return SqlCustomerRepository.Current;
            }
            else
            {
                return FileCustomerRepository.Current;
            }

        }    


    public IGenericRepository<Address> GetAddressRepository()
        {
           
            if (backend == "SQL")
            {

                return SqlAddressRepository.Current;

                
            }
            else
            {
                throw new Exception("No se puede buscar un Customer desde un archivo File");

            }
        }

      
    
    }




}
