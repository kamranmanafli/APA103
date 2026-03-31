using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Exeptions
{
    public class IncorrectPasswordException : Exception
    {
        public int AtteptsLeft  { get; set; }

        public IncorrectPasswordException(int attemptsLeft)
            : base($"Incorrect password! Attemps left: {attemptsLeft}")
        {
            AtteptsLeft = attemptsLeft;
        }
    }
}
