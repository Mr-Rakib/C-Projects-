using System;
using System.Collections.Generic;

namespace Some_Collection
{
    class Program
    { 
        /// <summary>
        /// HashSet is a updated version of list
        /// SorrtedSet is the sorted version of HashSet
        /// Where it not duplicate the items
        /// 
        /// LinkList support Duplicate entry 
        /// But it can add and remove items in 
        /// very fast time period
        /// 
        /// Sorted List, Sorted Dictionary & Dictionary are
        /// in same data type 
        /// holding the key according to value 
        /// 
        /// </summary>


        Program()
        {
            Call_HashSet();
            Call_SortedSet();
            Call_LinkList();
            Call_Dictionary();
            Call_SortedDictionary();
            Call_SortedList();

        }

        private void Call_SortedList()
        {
            Console.WriteLine("\nCall Sorted List : ");
            SortedList<int, string> student = new SortedList<int, string>();
            student.Add(1, "RAKIB");
            student.Add(2, "HASAN");
            student.Add(3, "MOTIN");

            foreach (KeyValuePair<int, string> kv in student)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            Console.Write("Enter the Index : ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("The name of this index is : " + student[i] + "\n");

            student.Remove(i);
            foreach (KeyValuePair<int, string> kv in student)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

        }

        private void Call_SortedDictionary()
        {
            Console.WriteLine("\nCall Sorted  Dictionary : ");
            SortedDictionary<int, string> student = new SortedDictionary<int, string>();
            student.Add(1, "RAKIB");
            student.Add(2, "HASAN");
            student.Add(3, "MOTIN");

            foreach (KeyValuePair<int, string> kv in student)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            Console.Write("Enter the Index : ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("The name of this index is : " + student[i] + "\n");

            student.Remove(i);
            foreach (KeyValuePair<int, string> kv in student)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }

        private void Call_Dictionary()
        {
            Console.WriteLine("\nCall Dictionary : ");
            Dictionary<int, string> student = new Dictionary<int, string>();
            student.Add(1,"RAKIB");
            student.Add(2,"HASAN");
            student.Add(3,"MOTIN");

            foreach(KeyValuePair<int,string> kv in student)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }

            Console.Write("Enter the Index : ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("The name of this index is : " + student[i] +"\n");

            student.Remove(i);
            foreach (KeyValuePair<int, string> kv in student)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }

        private void Call_LinkList()
        {
            Console.WriteLine("\nCall Linked List");
            

            LinkedList<string> student = new LinkedList<string>();
            student.AddLast("RAKIB");
            student.AddFirst("HRIDOY");
            student.AddFirst("MONIR");
            student.AddLast("RITA");

            foreach(string n in student)
            {
                Console.WriteLine(n);
            }

            student.Remove("RAKIB");

            Console.WriteLine("\nAfter removing");
            foreach (string n in student)
            {
                Console.WriteLine(n);
            }


            LinkedListNode<string> node = student.Find("HRIDOY");
            student.AddAfter(node , "RAKIB");
            student.AddBefore(node , "MINA");

            Console.WriteLine("\nAfter Adding Middle");
            foreach (string n in student)
            {
                Console.WriteLine(n);
            }

        }

        private void Call_SortedSet()
        {
            Console.WriteLine("\nCall Sorted Set");
            SortedSet<string> sorted = new SortedSet<string>();
            sorted.Add("Md Rakibul Hasan");
            sorted.Add("Md Nahidul Hasan");
            sorted.Add("Md Rohan Hasan");

            foreach (string h in sorted)
            {
                Console.WriteLine(h);
            }

            sorted.Remove("Md Rakibul Hasan");
            Console.WriteLine("\nAfter removing ");
            foreach (string h in sorted)
            {
                Console.WriteLine(h);
            }
        }

        private void Call_HashSet()
        {

            Console.WriteLine("Call Hash Set");
            HashSet<string> hash = new HashSet<string>();
            hash.Add("Md Rakibul Hasan");
            hash.Add("Md Nahidul Hasan");
            hash.Add("Md Rohan Hasan");
            
            foreach(string h in hash)
            {
                Console.WriteLine(h);
            }

            hash.Remove("Md Rakibul Hasan");
            Console.WriteLine("\nAfter removing ");
            foreach (string h in hash)
            {
                Console.WriteLine(h);
            }
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }
    }
}
