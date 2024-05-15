using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRes.ConvalidError
{
    internal class SpecialCharCheck : Convalidator
    {
        public override void CheckPassword(string password)
        {
            bool specialCharPresence = false;
            for (int i = 0; i <password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    specialCharPresence = true;
                    break; 
                }
            }
            if (!specialCharPresence)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR! The password must contain at least one special character");
            }
        }
    }        
}
