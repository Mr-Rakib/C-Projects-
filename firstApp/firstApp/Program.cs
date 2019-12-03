using System;

namespace firstApp
{

    class Program
    {

        int globalVariable = 5;



        Program()
        {
           
            //add();
            //changingFunction( ref globalVariable);
            checkOut(out globalVariable);
            Console.WriteLine("Value of global variable changed to : "+globalVariable);

            SecondClass sc = new SecondClass ();
            sc.WhileLoop();
            sc.checkingAge(22);
            sc.checkingAge(15);

            Console.WriteLine(DateTime.Now);

            DateTime birthDate = new DateTime(1998,05,22,00,00,12);
         
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(birthDate.ToString("yyyyMMdd"));
            int age = now - dob;
            
            Console.WriteLine(age/10000+" years "+ (age/100)%100+" months "+ age%100+" days  ");
            Console.WriteLine();


        }


        public void checkOut(out int i)
        {
            i = 10;
            i += 10;
        }       

        public void add ()
        {

            Console.WriteLine("Enter a number : ");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number : ");
            int j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number : ");
            char op = Convert.ToChar(Console.ReadLine());

            int result = 0;

            switch (op)
            {
                case '+':
                    result = i + j;
                    break;

                case '-':
                    result = i - j;
                    break;

                case '/':
                    result = i / j;
                    break;

                case '*':
                    result = i * j;
                    break;

                default:
                    Console.WriteLine("Wrong Output");
                    break;


            }

            Console.WriteLine("The result is : " + result);
        }

        public int changingFunction(ref int globalVariable)
        {
            //Changing with references 

            globalVariable = globalVariable + 5;
            Console.WriteLine(globalVariable);
            return globalVariable;
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }


        ~Program()
        {
            Console.WriteLine("This is Destructor");
        }


    }
}
