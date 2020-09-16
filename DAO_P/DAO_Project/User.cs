using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class User
    {
        public string name;
        public string surname;
        public int Id;
        public User(int Id, string name, string surname)
        {
            this.Id = Id;
            this.name = name;
            this.surname = surname;
        }
    }
}
