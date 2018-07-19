using System;
using System.Collections.Generic;
using System.Text;

namespace Angular_Core.Services.IRepository.Base
{
    public interface IEntityRepository<T> 
    {
        T Create(T entity);

        T Update(T entity);

        void Delete(T entity);

        IEnumerable<T> GetAll();
    }
}
