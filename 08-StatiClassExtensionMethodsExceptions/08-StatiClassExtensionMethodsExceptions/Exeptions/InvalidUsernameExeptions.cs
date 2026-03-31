using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Exeptions
{
    internal class InvalidUsernameExeptions : Exception
    {
        public InvalidUsernameExeptions() : base("Username is invalid!" ) { }
        public InvalidUsernameExeptions(string message) : base(message) { }
    }
}
