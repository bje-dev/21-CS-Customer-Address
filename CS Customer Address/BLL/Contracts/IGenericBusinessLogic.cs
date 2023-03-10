using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IGenericBusinessLogic<T> where T : class, new()
    {
        void Insert(T obj);
        T GetOne(Guid id);
        void Update(T obj);
        void Delete(Guid id);
        IEnumerable<T> GetAll();

    }
}
