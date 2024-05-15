using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRes.ConvalidError
{
    internal class MissingCapitalCheck : Convalidator
    {
        public override void CheckPassword(string password)
        {
            bool UpperPresence = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    UpperPresence = true;
                    break;
                }

            }
            if (!UpperPresence)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR! The password must contain at least one capital letter");
            }
        }
    }
}
