using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp
{
    public class ThirdClass
    {

        public ThirdClass()
        {
            Console.WriteLine("Constructor of third class");
        }

        public void checkingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Yes " + age + " you are OK for this job");
            }
            else Console.WriteLine("Sorry you are just " + age + " too young");
            
        }
    }
}
