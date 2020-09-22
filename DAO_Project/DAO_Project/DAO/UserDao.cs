using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Project.DAO
{
    class UserDao
    {

        public void AddUser(string name, string surname)
        {
            using (var context = new MyDBContext())
            {
                var user = new User()
                {
                    Name =name,
                    Surname = surname
                };

                context.Users.Add(user);
            }
        }
    }
}
