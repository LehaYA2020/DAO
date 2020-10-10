using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Project
{
    class MyDBContext : DbContext
    {
        public MyDBContext() : base("DbConnectionString")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
