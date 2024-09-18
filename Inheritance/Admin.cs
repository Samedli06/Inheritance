using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Admin : Profile
    {
        public Admin(string Name, string Surname, string Email, string Password , UserRole role) : base(Name, Surname, Email, Password,role)
        {
            role = UserRole.User;
        }
    }
}
