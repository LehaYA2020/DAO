using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAO_Project.DAO
{
    class UserDao
    {
        private MyDBContext context = new MyDBContext();

        public void Save(User user)
        {
                context.Users.Add(user);
                context.Users.Add(user);
                context.SaveChanges();
        }

        public User FindById(int Id)
        {
            
            return context.Users.Find(Id);
        }
    }
}
