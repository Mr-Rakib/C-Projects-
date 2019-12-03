using System;

namespace Custom_Exception
{
    class AgeNotValidException : Exception
    {
        public AgeNotValidException(String msg) : base(msg) { }
  
    }


    class Program
    {
        private void CheckAge()
        {
            while (true)
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age == 0) { Environment.Exit(0); }
                try
                {
                    if (age < 18)
                    {
                        throw new AgeNotValidException("Your age is not valid for this job");
                    }
                    else Console.WriteLine("Congrate You are valid for this job");
                }
                catch (AgeNotValidException anve)
                {
                    Console.WriteLine(anve);
                }
            }
        }

        Program()
        {
            CheckAge();
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }
    }
}
