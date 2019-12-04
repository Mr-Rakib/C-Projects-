using System;
using System.Linq;

namespace LogInValidation
{


    class Program
    {
        /// <summary>
        /// 
        /// Login Validaton
        /// 
        /// Conditions : (username)
        /// 1) should not empty
        /// 2) does not contain any special character
        /// 3) should not a digit 
        /// 
        /// Conditions : (password)
        /// 1) should not empty
        /// 2) more than 6 character
        /// 3) must contains atlest one Uppercase Character
        /// 
        /// </summary>


        Program()
        {
                userLogin(); 
        }

        

        private void userLogin()
        {
            l1:
            Console.Write("Enter Username : ");
            string username = Console.ReadLine();
        
            if ( isValidUserName(username) )
            {
                l2:
                Console.Write("Enter Password : ");
                string password = Console.ReadLine();
               
                    if (isValidPassword(password))
                    {
                        Console.WriteLine("Successfully Loged in"); 
                    }else
                    {
                        Console.WriteLine("invalid Password");
                        goto l2;
                    }
            }
            else
            {
                Console.WriteLine("Invalid Username");
                goto l1; 
            }
        }

        private Boolean isValidPassword(string password)
        {
            if (! password.Equals("") && password.Length >= 6 && password.Any(char.IsUpper))
            {
                return true;
            }
            else return false;
        }

        private Boolean isValidUserName(string username)
        {
           if( username.Equals("") || !username.All(c => char.IsLetterOrDigit(c)) || username.All(char.IsDigit) ) 
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }
    }
}
