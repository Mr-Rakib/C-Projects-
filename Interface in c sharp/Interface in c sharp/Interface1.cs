using Interface_in_c_sharp.Model;
using System.Collections.Generic;


namespace Interface_in_c_sharp
{
    interface StudentDAO
    {
        List<Student> student();
        Student studentById(int id);
        void createStudent();
    }
}
