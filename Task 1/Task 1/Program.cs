using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_1
{
    class Program
    {

        Program()
        {
            Task1();

            Console.WriteLine();

            Task2();
            Console.WriteLine();
        }

           

        private void Task2()
        {
                List<int> numberList = new List<int>() { 3, 1, 5, 7, 5, 9, 5, 9, 2, 8, 4, 6 };
                //            numberList=numberList.Distinct().ToList();

                int sumValue = 10;

                

                List<Tuple<int, int>> findingSum = FindTwoSum(numberList, sumValue);
                findingSum = findingSum.Distinct().ToList();
                foreach (Tuple<int, int> fs in findingSum)
                {
                    Console.WriteLine(fs.ToString());
                }
            
        }

        private void Task1()
        {
            string[] arr1, arr2, sortedArray;
            arr1 = new string[] { "Ava", "Emma", "Olivia" };
            arr2 = new string[] { "Olivia", "Sophia", "Emma" };



            sortedArray = UniqueNames(arr1, arr2);

            foreach (String sa in sortedArray)
            {
                Console.WriteLine(sa);
            }
        }

        public string[] UniqueNames(String[] arr1, String[] arr2 )
        {
            Console.WriteLine("TASK : 1");
            Console.WriteLine("The Sorted and Distinct List : ");

            string[] sortedArray = new string[arr1.Length + arr2.Length] ;

            string[] combined = new string[arr1.Length + arr2.Length];
            

            Array.Copy(arr1, combined, arr1.Length);
            Array.Copy(arr2, 0, combined, arr2.Length, arr2.Length);


            //manually Distinct the array
            /*
                        int count = 0;
                        int number = 0;

                        

                                    for(int x= 0;x<combined.Length;x++)
                                    {
                                        string duplicate = combined[x];

                                        for (int y = x + 1; y < combined.Length; y++)
                                        {
                                            if (duplicate.Equals(combined[y]))
                                            {
                                                count++;
                                            }

                                        }
                                        if (count == 0 )
                                        {

                                            sortedArray[number] = combined[x];
                                            number ++;
                                        }
                                        count = 0;
                                    }
                   */

            sortedArray = combined.Distinct().ToArray();
           
            return sortedArray;

            

        }

        public List<Tuple<int, int>> FindTwoSum(List<int> numberList,int sumValue )
        {

            Console.WriteLine("TASK : 2");
            Console.WriteLine("Finding the sum of  : " + sumValue);
            int [] allnumber = numberList.ToArray();
            int currentValue = 0;


            List<Tuple<int, int>> findingSum = new List<Tuple<int, int>>();
            
            for (int x = 0; x < allnumber.Length; x++)
            { 
                currentValue = allnumber[x];
                for(int y = x+1; y < allnumber.Length; y++)
                {
                   
                    if ((currentValue+allnumber[y]) == sumValue)
                    {
                        findingSum.Add(Tuple.Create(currentValue, allnumber[y] ));
                        //Console.WriteLine(currentValue + " " + allnumber[y] + "  10 ");
                    }
                }

            }

            return findingSum;

        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();

        }
    }
}
