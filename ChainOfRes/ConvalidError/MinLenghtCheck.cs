using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRes.ConvalidError
{
    internal class MinLenghtCheck:Convalidator
    {
        public override void CheckPassword(string password)
        {
            int lenght = password.Length;
            if (lenght < 8)
            {
                Console.WriteLine($"Error! The password must be at least 8 characters long");                
            }
        base.CheckPassword(password);

        }
        

    }
}
