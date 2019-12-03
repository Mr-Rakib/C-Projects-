using System;

namespace firstApp
{


    public class SecondClass :ThirdClass
    {
        public SecondClass()
        {
            Console.WriteLine("Constructor of the second class");
        }

         ~SecondClass()
        {
            Console.WriteLine("Destructor of the Second Class");
        }

        public void WhileLoop()
        {

            Console.WriteLine("Loop Started : ");
            for (int i = 0; i < 20; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    // Console.WriteLine(i + " " + j);

                    if (j * i % 2 == 1)
                    {
                        Console.WriteLine("baned : " + i * j);
                        continue;
                    }


                }
            }
            Console.WriteLine("Loop ended");
        }

        public void CheckLabel()
        {
            l1:
            Console.WriteLine("The number is Less than 5");


            int i = Convert.ToInt32(Console.ReadLine());
            if (i < 5)
            {
                goto l1;
            }
            else
            {
                Console.WriteLine("The number is gretter than 5");
            }


        }
    }
}