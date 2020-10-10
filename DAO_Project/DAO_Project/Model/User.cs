using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Project
{
    class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Surname = {Surname}, Number = {Number}";
        }
        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            User other = (User)obj;
            return this.Id.Equals(other.Id);
        }
        public override int GetHashCode()
        {
            return Id;
        }
    }
}
