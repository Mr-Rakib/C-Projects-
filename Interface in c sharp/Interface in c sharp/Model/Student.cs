using System;

namespace Interface_in_c_sharp.Model
{
    class Student
    {

        int id;
        String name;
        String department;
        String address;
        DateTime dateofBirth;
        float cgpa;

        static int total;

        public Student() { }

        public Student(int id, string name, string department, string address, DateTime dateofBirth, float cgpa)
        {

            this.id = id;
            this.name = name;
            this.department = department;
            this.address = address;
            this.dateofBirth = dateofBirth;
            this.cgpa = cgpa;
            total = total + 1;
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;
            return student != null &&
                   id == student.id &&
                   name == student.name &&
                   department == student.department &&
                   address == student.address &&
                   dateofBirth == student.dateofBirth &&
                   cgpa == student.cgpa;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name, department, address, dateofBirth, cgpa);
        }

        public void toString()
        {

            Console.WriteLine("id : " + id + " name : " + name + " department : " + department + " address : " + " dateofbirth : " +
                dateofBirth + " cgpa: " + cgpa);
        }

        public int getId() { return id; }
        public String getName() { return name; }
        public String getDepartment() { return department; }
        public String getAddress() { return address; }
        public DateTime getDateOfBirth() { return dateofBirth; }
        public float getCgpa() { return cgpa; }
        public int getTotol() { return total; }

    }
}