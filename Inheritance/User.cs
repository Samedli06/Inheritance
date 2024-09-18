using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class User : Profile
    {
        public int age { get; set; }
        public User(string Name, string Surname, string Email, string Password, UserRole role, int age) : base(Name, Surname, Email, Password, role)
        {
            role = UserRole.User;
           
        }
    }
}
