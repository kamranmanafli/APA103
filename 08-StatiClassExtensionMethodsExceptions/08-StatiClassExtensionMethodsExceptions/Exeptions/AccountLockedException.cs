using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Exeptions
{
    public class AccountLockedException : Exception
    {
        public AccountLockedException()
            : base("Account is locked due to multiple failed attemts!") { }
    }
}
