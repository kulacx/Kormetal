using System.Collections.Generic;

namespace Kormetal.Dal.Abstract
{
   public interface IEntityRepository<T>
    {
        List<T> GetAll();

        T Get(int id);

        void Delete(int id);

        void Add(T entity);

        void Update(T entity);
    }
}
