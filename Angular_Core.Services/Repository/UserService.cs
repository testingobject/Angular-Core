using System;
using System.Collections.Generic;
using System.Text;
using Angular_Core.Services.IRepository;
using Angular_Core.Data;
using System.Linq;
using Angular_Core.Data.Models;
using Angular_Core.Services.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Angular_Core.Services.Repository
{
    public class UserService : IUserService

    {
        private readonly CoreAppContext dbContext;

        public UserService(CoreAppContext _context)
        {
            dbContext = _context;
        }

        public User Create(User entity)
        {
            dbContext.Users.Add(entity);
            dbContext.SaveChanges();
            return entity;
        }

        public void Delete(User entity)
        {
            dbContext.Users.Remove(entity);
            dbContext.SaveChanges();
            
        }

        public IEnumerable<User> GetAll()
        {
            return dbContext.Users.ToList();

        }

        public User GetUser(int id)
        {
            return dbContext.Users.Where(d => d.Id == id).FirstOrDefault();
        }

        public User Update(User entity)
        {
            dbContext.Entry(entity).State= EntityState.Modified;
            dbContext.SaveChanges();
            return entity;
        }
    }
}
