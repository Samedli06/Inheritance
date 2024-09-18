using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Profile
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public UserRole Role { get; set; }
        

        public  Profile(string Name, string Surname,  string Email, string Password, UserRole role)
        {
            name = Name;
            surname = Surname;
            email = Email;
            password = Password;
            Role = role;
        }

        
        public override string ToString()
        {
            return $"Username: {name}\nSurname: {surname}\nEmail: {email}\nPassword:{password}\nRole:{Role}";
        }

    }
}
