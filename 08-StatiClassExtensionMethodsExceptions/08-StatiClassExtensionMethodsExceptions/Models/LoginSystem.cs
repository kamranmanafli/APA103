using _08_StatiClassExtensionMethodsExceptions.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Models
{
    public class LoginSystem
    {
        private User[] users;
        private const int MaxAttempts = 3;

        public LoginSystem()
        {
            users = new User[]
            {
            new User("admin", "admin123"),
            new User("student", "student123"),
            new User("teacher", "teacher123"),
            };
        }

        public void ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new InvalidUsernameExeptions("Username cannot be empty!");

            if (username.Length < 3)
                throw new InvalidUsernameExeptions("Username must be at least 3 characters!");
        }

        public void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new InvalidPasswordExeptions("Password cannot be empty!");

            if (password.Length < 6)
                throw new InvalidPasswordExeptions("Password must be at least 6 characters");
        }

        private User FindUser(string username)
        {
            foreach (var user in users)
            {
                if(user.Username.ToLower() == username.ToLower())
                    return user;
            }
            return null;
        }

        public bool Login(string username, string password)
        {
            ValidateUsername(username);
            ValidatePassword(password);

            User user = FindUser(username);

            if (user == null)
                throw new UserNotFoundException(username);

            if (user.IsLocked)
                throw new AccountLockedException();

            if(user.Password == password)
            {
                user.FailedAttempts = 0;
                Console.WriteLine($"Login succesful Welcome, {username}!");
                return true;
            }
            else
            {
                user.FailedAttempts++;

                int attemptsLeft = MaxAttempts - user.FailedAttempts;

                if (attemptsLeft > 0)
                    throw new IncorrectPasswordException(attemptsLeft);
                else
                {
                    user.IsLocked = true;
                    throw new AccountLockedException();
                }
            }
        }
        public void ShowUsers()
        {
            Console.WriteLine("Aviable users:");
            foreach (var user in users)
            {
                Console.WriteLine($"- {user.Username}");
            }
        }

    }
}

