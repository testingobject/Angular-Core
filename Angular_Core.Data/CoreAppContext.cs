using Angular_Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Angular_Core.Data
{
    public class CoreAppContext: DbContext
    {
        public CoreAppContext(DbContextOptions<CoreAppContext> options) : base(options)
        {

        }
        public virtual DbSet<User> Users { get; set; }
    }
}
