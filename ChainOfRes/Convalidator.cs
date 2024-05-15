using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfRes
{
    public abstract class Convalidator
    {

        protected Convalidator NextCheck;

        bool isvalid = true;
        public Convalidator SetSuccesor(Convalidator nextCheck)
        {
            NextCheck = nextCheck;
            return NextCheck;
        }
        public virtual void CheckPassword(string password)
        {
            NextCheck?.CheckPassword(password);
        }


    }
}

