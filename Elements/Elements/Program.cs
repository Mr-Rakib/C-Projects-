using System;
using System.Collections.Generic;

namespace Elements
{
    /// <summary>
    /// All of the data-structures 
    /// But all af those can store duplicate entry
    /// </summary>
    

    class Program
    {

        Program()
        {
            Call_List();
            Call_Stack(); 
            Call_Queue();
        }

        private void Call_Queue()
        {
            Console.WriteLine("\nCall Queue of the Students :");
            Queue<string> name = new Queue<string>();
            name.Enqueue("Mostana Khan");
            name.Enqueue("Nazia Srakar");
            name.Enqueue("Marzia Hasan");

            foreach (string n in name)
            {
                Console.WriteLine(n);
            }

            name.Dequeue();

            Console.WriteLine();
            Console.WriteLine("After Dequeue : ");
            foreach (string n in name)
            {
                Console.WriteLine(n);
            }
        }

        private void Call_Stack()
        {
            Console.WriteLine("\nCall Stack of the Students :");
            Stack <string> name = new Stack<string>();
            name.Push("Mostana Khan");
            name.Push("Nazia Srakar");
            name.Push("Marzia Hasan");

            foreach (string n in name)
            {
                Console.WriteLine(n);
            }

            name.Pop();

            Console.WriteLine();
            Console.WriteLine("After Poping : ");
            foreach (string n in name)
            {
                Console.WriteLine(n);
            }
        }

        private void Call_List()
        {
            Console.WriteLine("Call List of the Students :");
            List<string> name = new List<string>();
            name.Add("Rakib Hasan");
            name.Add("Hridoy Hasan");
            name.Add("Monir Hasan");

            foreach(string n in name)
            {
                Console.WriteLine(n);
            }

            name.Remove("Monir Hasan");

            Console.WriteLine();
            Console.WriteLine("After removing : ");
            foreach (string n in name)
            {
                Console.WriteLine(n);
            }
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }
    }
}
