using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Sql
{
   

        internal sealed class SqlCustomerRepository:IGenericRepository<Customer>
        {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Customer] (cus_nombre, cus_apellido, cus_email, cus_edad) VALUES (@nombre, @apellido, @email, @edad)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Customer] SET (cus_nombre, cus_apellido, cus_email, cus_edad) WHERE  id_customer= @idcustomer";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Customer] WHERE id_customer= @idcustomer";
        }

        private string SelectOneStatement
        {
            get => "SELECT , cus_nombre, cus_apellido, cus_email, cus_edad FROM [dbo].[Customer] WHERE id_customer = @idcustomer";
        }

        private string SelectAllStatement
        {
            get => "SELECT , cus_nombre, cus_apellido, cus_email, cus_edad FROM [dbo].[Customer]";
        }
        #endregion




        private readonly static SqlCustomerRepository _instance = new SqlCustomerRepository();

            public static SqlCustomerRepository Current
            {
                get
                {
                    return _instance;
                }
            }

            private SqlCustomerRepository()
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
            Customer cus=new Customer();
            return cus;
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }
    }

    
}
