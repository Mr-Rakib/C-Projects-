using System;

namespace MethodOverLoading
{
    class Program1
    {
        public virtual void add()
        {
            Console.WriteLine("This is add of Program without parameter");
        }

        public void add(int x)
        {
            Console.WriteLine(x+ " is generated the add with parameter");
        }
    }

    class Program2 : Program1
    {
        public override void add()
        {
            Console.WriteLine("This is add with parameter from Program 2");
        }
    }



    class Program : Program2
    {
        Program()
        {
            //Method_Overloading();
            Method_Overriding();
        }

        private void Method_Overriding()
        {
            add();
        }

        private void Method_Overloading()
        {
            add();
            add(5);
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }
    }
}
