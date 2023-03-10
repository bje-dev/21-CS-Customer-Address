using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Sql
{


    internal sealed class SqlAddressRepository:IGenericRepository<Address>
    {
        private readonly static SqlAddressRepository _instance = new SqlAddressRepository();

        public static SqlAddressRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private SqlAddressRepository()
        {
            //Implent here the initialization of your singleton
        }

        public void Add(Address obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Address obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Address GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAll()
        {
            throw new NotImplementedException();
        }
    }



}
