using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    public class ProfileController
    {
        ArrayList profiles = new ArrayList();
        Profile profile = new Profile("","","","", UserRole.User);

        public void signup(string username, string usersurname , string email, string password , UserRole role)
        {
            Profile profile = new Profile( username ,usersurname , email, password,role);
            profiles.Add(profile);
            Console.WriteLine("User signed up successfully.");

        }

        public string getEmail()
        {
            return profile.email;
        }

        public string getPassword()
        {
            return profile.password;
        }

        public void signin(string email ,string password)
        {
            foreach (Profile item in profiles) {
                Profile profile = (Profile)item;
               
               if(profile.email.Equals(email) && profile.password.Equals(password))
                {
                    Console.WriteLine("sign-in succcessful!" + profile.name);
                }
            }
        }

        public void showUsers()
        {
            foreach (Profile profile in profiles)
            {
                Console.WriteLine(profile);
            }
        }

        public void UpdateProfile(Profile profile, string propertyToUpdate , string newValue)
        {
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();

            if (password != profile.password)
            {
                Console.WriteLine("incorrect password");
                return;
            }

            switch (propertyToUpdate.ToLower()) {
                case "name":
                    profile.name = newValue;
                    break;
                case "surname":
                    profile.surname = newValue;
                    break;
                case "email":
                    profile.email = newValue;
                    break;
                case "password":
                    profile.password = newValue;
                    break;
                default:
                    Console.WriteLine("invalid property");
                    return ;
            }
            Console.WriteLine("profile updated successfully");
        }

        public void deleteProfile(Profile profile)
        {
            profiles.Remove(profile);
            Console.WriteLine("profile removed successfully");
        }

        public void showProfile(Profile profile)
        {
            Console.WriteLine(profile);
        }
    }
}
