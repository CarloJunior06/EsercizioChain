using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRes.ConvalidError
{
    internal class MissingNumCheck : Convalidator
    {
        public override void CheckPassword(string password)
        {
            int digitCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    digitCount++;
                }

            }
            if (digitCount < 2)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR! The password must contain at least 2 numbers");

            }

        }
    }
}
