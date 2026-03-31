using _08_StatiClassExtensionMethodsExceptions.Exeptions;
using _08_StatiClassExtensionMethodsExceptions.Models;
using System;

public class Program
{
    static void Main(string[] args)
    {
        LoginSystem system = new LoginSystem();

        while (true)
        {
            try
            {
                Console.WriteLine("Enter username: ");
                string username = Console.ReadLine();

                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();

                bool result = system.Login(username, password);

                if (result)
                    break;
            }
            catch(InvalidUsernameExeptions ex)
            {
                Console.WriteLine("ERROR: " + ex.Message); 
            }
            catch (InvalidPasswordExeptions ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (UserNotFoundException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                system.ShowUsers();
            }
            catch (IncorrectPasswordException ex)
            {
                Console.WriteLine("WARNING: " + ex.Message);
            }
            catch (AccountLockedException ex)
            {
                Console.WriteLine("CRITICAL: " + ex.Message);
                Console.WriteLine("Contact admin!");
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("UNEXCEPTED ERROR: " + ex.Message);
            }

        }
    }
}
























