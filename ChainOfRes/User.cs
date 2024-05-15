using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChainOfRes
{
    internal class User : Convalidator
    {
        string _userName { get; set; }
        string _password { get; set; }
        bool valid;

        public User()
        {
        }

        public User(string userName, string password, bool valid)
        {
            _userName = userName;
            _password = password;
            this.valid = valid;
        }

        public void InitializeUser()
        {
            Console.WriteLine("Hi, insert your new Username please:");
            _userName = Console.ReadLine();

        }
        public void InitializePassword()
        {
            Console.WriteLine("Password requirements: ");
            Console.WriteLine("-The password must be at least 8 characters long");
            Console.WriteLine("-The password must contain at least 2 numbers");
            Console.WriteLine("-The password must contain at least one capital letter");
            Console.WriteLine("-The password must contain at least one special character");
            Console.WriteLine();
            Console.WriteLine("Hi, insert your new Password please:");
            _password = Console.ReadLine();
            NextCheck.CheckPassword(_password);
        }
        
    }
}

