using BLL.Contracts;
using DAL.Contracts;
using DAL.Factory;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CustomerBusinessLogic : IGenericBusinessLogic<Customer>
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Customer obj)
        {
            if (obj.Edad<18)
            {
                //Pasar objeto a la factory
                Factory.Current.CreateCustomerRepository(obj);

            }
            else
            {
                throw new Exception("El customer debe ser mayor a 18 años");
            }
        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
