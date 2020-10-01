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
                context.SaveChanges();
        }
        public void Remove(User user)
        {
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public void Update(User user)
        {
            context.Users.Attach(user);
            context.SaveChanges();
        }

        public User FindById(int Id)
        {
            return context.Users.Find(Id);
        }
    }
}
