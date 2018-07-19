using System;
using System.Collections.Generic;
using System.Text;

namespace Angular_Core.Services
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
