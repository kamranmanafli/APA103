using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Exeptions
{
    public class InvalidPasswordExeptions : Exception
    {
        public InvalidPasswordExeptions() : base("Password is invalid!") { }

        public InvalidPasswordExeptions(string message) : base(message) { }
    }
}
