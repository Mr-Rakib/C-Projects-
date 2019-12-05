using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem_File
{
    /// <summary>
    /// 
    /// Data Source : File Based
    /// Employee Information 
    /// with proper Validation
    /// Also add or remove any employee 
    /// Search any particular employee information by Employee Id
    /// 
    /// </summary>

    class Employee
    {
        public int id { get; }
        public string name { get; }
        public string department { get; set; }
        public string possition { get; set; }
        public string vill { get; set; }
        public string post { get; set; }
        public int postalCode { get; set; }
        public string dist { get; set; }
        private static int totalEmployee = 0;

        public int getTotalemployee() { return totalEmployee; }

        public Employee(int id, string name, string department, string possition, string vill, string post, int postalCode, string dist)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.possition = possition;
            this.vill = vill;
            this.post = post;
            this.postalCode = postalCode;
            this.dist = dist;
        }

        public override string ToString()
        {
            return id + " : " + name + " : " + department + " : " + possition+ " : " + vill + " : " + post + " : " + postalCode + " : " + dist;
        }
        public string ToStringPrint()
        {
            return "Employee { id: "+id + ", name: " + name + ", department: " + department + ", possition: " + possition + ",Address { vill: "
                + vill + ",post: " + post + ",Postal Code: " + postalCode + ",district : " + dist+"}}";
        }

    }

   

    class Program
    {

        private int TotalEmployee = 0;
        List<Employee> employeeList ;

        private string filePath = @"G:\C # Projects\EmployeeManagementSystem File\EmployeeInformation.txt";

        Program()
        {
            // SqlConnection connection =  getDatabaseConnection();

            Linput:
            Console.Clear();
            int input;
            Console.Write("Enter any number to select:\n1) for add employee\n2) for Show all Data\n" +
                            "3) for show data by id\n4) delete data by id\n0) for exit\nSelect your input : ");
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception) { goto Linput; }
            switch (input)
            {
                case 1:
                    AddEmployee();
                    Console.Read();
                    goto Linput;

                case 2:
                    ShowAllData();
                    Console.Read();
                    goto Linput;

                case 3:
                    ShowDataById();
                    Console.Read();
                    goto Linput;

                case 4:
                    deleteDataById();
                    Console.Read();
                    goto Linput;

                case 0:
                    Environment.Exit(0);
                    break;

                default:
                    goto Linput;
            }

        }


        private void deleteDataById()
        {
        Lid_DeleteData:
            Console.Write("Enter the Employee Id : ");
            int id;
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                clearTheCurrentLine(); goto Lid_DeleteData;
            }

                Employee deletetedEmployee = findAllEmployeeList().Find(x => x.id == id);

                if (deletetedEmployee != null)
                {
                    List<Employee> afterDeleted = findAllEmployeeList().FindAll(x => x.id != id);
                    File.WriteAllText(filePath, String.Empty);
                if (afterDeleted.Any() && afterDeleted != null)
                    {
                        foreach (var v in afterDeleted){
                           // Console.WriteLine(v.ToStringPrint());
                            File.AppendAllText(filePath, v.ToString() + Environment.NewLine);
                        }
                    }
                    Console.WriteLine("Employee Deleted !");
                }
                else
                {
                    Console.WriteLine("No Employee Found");
                }
            

            
        }

        private void ShowDataById()
        {

            Lid_ShowData:
            Console.Write("Enter the Employee Id : ");
            int id;

            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException) { clearTheCurrentLine(); goto Lid_ShowData; }

           // Console.WriteLine(findAllEmployeeList().Any()==null);

            if (findAllEmployeeList() != null)
            {
                Employee foundedEmployee = findAllEmployeeList().Find(x => x.id == id);

                if (foundedEmployee != null)
                {
                    //foreach(Employee e in foundedEmployee)
                    Console.WriteLine(foundedEmployee.ToStringPrint());
                }
                else
                {
                    Console.WriteLine("No Employee Found");

                }
            }
            else
            {
                Console.WriteLine("No Employee Found");
            }
        }

        private List<Employee> findAllEmployeeList()
        {
            List<string> allEmployee = File.ReadAllLines(filePath).ToList();
            if (!allEmployee.Any())
            {
                //Console.WriteLine("No Data Available");
                return null;
            }
            else
            {
                employeeList = new List<Employee>();
                foreach (var lines in allEmployee)
                {
                    string[] entries = lines.Split(':');
                    Employee employee = new Employee(Convert.ToInt32(entries[0]), entries[1], entries[2], entries[3],
                       entries[4], entries[5], Convert.ToInt32(entries[6]), entries[7]);
                    employeeList.Add(employee);
                }
                return employeeList.OrderBy( e => e.id).ToList();
            }
        }

        private void clearTheCurrentLine()
        {
            char[] blankline = new char[Console.WindowWidth];

            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
            Console.Write(blankline, 0, Console.WindowWidth);
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
        }

        private void ShowAllData()
        {
            List<Employee> allEmployee = findAllEmployeeList();

            if (allEmployee != null && allEmployee.Any())
            {
                Console.WriteLine("All Employee informations - Total :  " + allEmployee.Count);
                foreach (Employee em in allEmployee)
                {
                    if (em == null) { }
                    Console.WriteLine(em.ToStringPrint());
                }
            }
            else
            {
                Console.WriteLine("No Data Available ");
            }
        }

        private void AddEmployee()
        {
            Employee emp = getEmployee();
            

            File.AppendAllText(filePath, emp.ToString()+Environment.NewLine);
            TotalEmployee = emp.getTotalemployee();
            Console.WriteLine("Successfully Added");
            
        }


        private Employee getEmployee()
        {
            Console.WriteLine("----------Enter the Employee Informations----------");
            int ct = 0;
            Lid:
            
            Console.Write("Id : ");

            int id;

            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException) { clearTheCurrentLine(); goto Lid; }

            if (chackEmployeeAvailability(id))
            {
                if (ct == 0){
                    clearTheCurrentLine();
                }
                else { 
                    clearTheCurrentLine();
                    clearTheCurrentLine();
                }
                ct++;
                Console.WriteLine(id + " Already Available");
                goto Lid;
            }

            Lname:
            Console.Write("Name : ");
            string name = Console.ReadLine();
            if (isValidString(name)) { clearTheCurrentLine(); goto Lname; }

            Ldpt:
            Console.Write("Department : ");
            string department = Console.ReadLine();
            if (isValidString(department)) { clearTheCurrentLine(); goto Ldpt; };

            Lposs:
            Console.Write("Possition : ");
            string possition = Console.ReadLine();
            if (isValidString(possition)) { clearTheCurrentLine(); goto Lposs; };


            Console.WriteLine("Address ");
            Lvill:
            Console.Write("Village : ");
            string vill = Console.ReadLine();
            if (isValidString(vill)) { clearTheCurrentLine(); goto Lvill; };

            Lpost:
            Console.Write("Post-Office: ");
            string post = Console.ReadLine();
            if (isValidString(post)) { clearTheCurrentLine(); goto Lpost; };

            Lcode:
            Console.Write("Postal-Code: ");
            int postalCode;
            try
            { postalCode = Convert.ToInt32(Console.ReadLine()); }
            catch (System.FormatException) { clearTheCurrentLine(); goto Lcode; }

            Ldist:
            Console.Write("District : ");
            string dist = Console.ReadLine();
            if (isValidString(dist)) { clearTheCurrentLine(); goto Ldist; };

            return new Employee(id, name, department, possition, vill, post, postalCode, dist);
        }

        private bool chackEmployeeAvailability(int id)
        {
            Employee compareEmp;
            if (findAllEmployeeList() != null)
            {
                compareEmp = findAllEmployeeList().Find(x => x.id == id);
                if (compareEmp == null)
                {
                    return false;
                }
                else
                {
                    return (id == compareEmp.id) ? true : false;
                }
            }
            else return false;
        }
        

        private Boolean isValidString(string str)
        {
            return (str.Trim().Equals("") || str.Trim().All(char.IsDigit) || str.Trim().Length < 2) ? true : false;
        }
        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();

        }
    }
}
