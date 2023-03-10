using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.File
{


    public sealed class FileCustomerRepository:IGenericRepository<Customer>
    {

        private readonly static FileCustomerRepository _instance = new FileCustomerRepository();

        public static FileCustomerRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private FileCustomerRepository()
        {
            //Implent here the initialization of your singleton
        }

        public void Add(Customer obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Customer GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }
    }

    
}
