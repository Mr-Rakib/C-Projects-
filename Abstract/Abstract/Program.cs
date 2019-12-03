using System;

namespace Abstract
{
    /// <summary>
    /// We can not create a object of an abstract class
    /// The Abstract methods has n body 
    /// When its implements anyone can override the method
    /// </summary>


    // Abstract Class
    public abstract class A
    {
        public abstract void add();
        public void substract(int a, int b)
        {
            Console.WriteLine( "The result is : "+ (a-b));
        }
    }

    public class B : A
    {
        // Abstract Methods
        public override void add()
        {
            Console.WriteLine("This is the abstract add from Class B");
        }

        
    }

    class Program : B
    {
        public Program()
        {
            add();
            substract(5,3);
        }
       
        public static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }

        
    }
}
