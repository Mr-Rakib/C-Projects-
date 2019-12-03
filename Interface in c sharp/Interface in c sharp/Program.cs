using System;
using System.Collections.Generic;
using Interface_in_c_sharp.Model;

namespace Interface_in_c_sharp
{

    class DAO : StudentDAO

    {
        public void createStudent()
        {

            Student st = new Student(1,"Md Rakibul Hasan", "Software","Dhaka",new DateTime(1998,05,22), 3.84f);
            Student st1 = new Student(2,"Md Hasan Hridoy", "Software","Dhaka", new DateTime(2000,10,05), 3.84f);
            
            st.toString();
            st1.toString();

            Console.WriteLine("Total Student : "+st.getTotol());
           

        
        }

        public List<Student> student()
        {
            Student st = new Student(1, "Md Rakibul Hasan", "Software", "Dhaka", new DateTime(1998, 05, 22), 3.84f);
            Student st1 = new Student(2, "Md Hasan Hridoy", "Software", "Dhaka", new DateTime(2000, 10, 05), 3.84f);
            List<Student> studentList = new List<Student>();
            studentList.Add(st);
            studentList.Add(st1);

            return studentList;
        }

        public Student studentById(int id)
        {
            throw new NotImplementedException();
        }


    }

    class Program 
    {

        public Program()
        {
            DAO dao = new DAO();
            dao.createStudent();

            List<Student> studentList = dao.student();
            foreach  (Student st in studentList)
            {
                st.toString();
            }
        }
        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }
    }
}
