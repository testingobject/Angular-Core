using System;
using System.Collections.Generic;
using System.Text;

namespace Angular_Core.Services
{
    public abstract class BaseEntity
    {

    }
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {

        public virtual T Id { get; set; }

        //public virtual DateTimeOffset DateDeleted { get; set; }
    }
}
