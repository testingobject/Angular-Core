using System;
using System.Collections.Generic;
using System.Text;
using Angular_Core.Data.Models;
using Angular_Core.Services;
using Angular_Core.Services.IRepository.Base;
using Angular_Core.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Angular_Core.Services.Repository.Base
{
    public abstract class EntityRepository<T> : IEntityRepository<T> where T : BaseEntity
    {
        private readonly CoreAppContext dbContext;
        protected DbSet<T> _dbset;

        public EntityRepository(CoreAppContext context)
        {
            dbContext = context;
            _dbset = dbContext.Set<T>();

        }
        public virtual T Create(T entity)
        {
            _dbset.Add(entity);
            dbContext.SaveChanges();
            return entity;
        }
        public virtual  T Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            dbContext.SaveChanges();
            return entity;
        }
        public virtual void Delete(T entity)
        {
            _dbset.Remove(entity);
            dbContext.SaveChanges();
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable<T>();
        }
    }
}
