using System;
using System.Collections.Generic;
using System.Text;
using Angular_Core.Data.Models;
using Angular_Core.Services.IRepository.Base;

namespace Angular_Core.Services.IRepository
{
    public interface IUserService : IEntityRepository<User>
    {
        User GetUser(int id);
    }
}
