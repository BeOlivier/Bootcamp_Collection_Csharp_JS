using System.Collections.Generic;

namespace Patterns.Business.SaltBusiness
{
    public interface IRepository<T>
    {
        void Create(T obj);
        IList<T> Read();
        void Update(T obj);
        void Delete(T obj);
    }

    
}