using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Exeptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base("User not found!") { }

        public UserNotFoundException(string username) 
            : base($"User {username} not found!") { }
    }
}
