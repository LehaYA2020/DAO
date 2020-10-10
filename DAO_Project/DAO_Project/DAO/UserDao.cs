using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAO_Project.Exceptions;

namespace DAO_Project.DAO
{
    class UserDao
    {
        private MyDBContext context = new MyDBContext();

        public User Save(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }
        public void Remove(User user)
        {
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public User Update(User user)
        {
            User forUpdate = FindById(user.Id);
            if (forUpdate != null)
            {
                forUpdate.Name = user.Name;
                forUpdate.Surname = user.Surname;
                forUpdate.Number = user.Number;
                context.SaveChanges();
                return forUpdate;
            }
            throw new EntityNotFoundException($"User with ID={user.Id} not found");
        }

        public User FindById(int Id)
        {
            return context.Users.Find(Id);
        }
    }
}
