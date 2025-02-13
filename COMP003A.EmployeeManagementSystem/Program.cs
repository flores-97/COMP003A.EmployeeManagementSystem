//Author: Victor Flores
//Course: COMP-003
//Faculty: Jonathon Cruz
//Purpose: Employee management system demonstrating OOP principles in C#
namespace COMP003A.EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creates new employee
            Employee myEmployee = new Employee("E001", "Alice", "Marie", "Johnson", 75000);
            myEmployee.EmployeeInfo();

            //display fields to enter employee info
            myEmployee.DisplayEmployeeInfo();

            //display department details
            Departments myHR_Department = new HRDepartment();
            Departments myIT_Department = new ITDepartment();

            myHR_Department.DisplayDepartmentInfo();
            Console.WriteLine($"{myHR_Department.detail}");
            ((IDepartmentOperations)myHR_Department).Operate();

            myIT_Department.DisplayDepartmentInfo();
            Console.WriteLine($"{myIT_Department.detail}");
            ((IDepartmentOperations)myIT_Department).Operate();
        }
    }

    class Employee
    {
        //fields 
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        //properties

        ///<summary>
        ///get employee id, first, middle, last names
        /// </summary>
        public string EmployeeId
        {
            get { return _employeeId; }
        }

        public string firstName
        {
            get { return _firstName; } 
            set { _firstName = value; }
        }  

        public string lastName
        { 
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string middleName
        {   
            get { return _middleName; }
            set
            { 
                if ( string.IsNullOrWhiteSpace(default));
                else
                 _middleName = value; 
            }   
        }


        /// <summary>
        /// gets or sets salary with validation 
        /// </summary>
        public double salary
        {
            get { return _salary; }
            set
            {
                if (value <= 0)
                {
                    _salary = value;
                }
            }
        }

        ///<summary>
        ///default constructor
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="salary"></param>
        public Employee(string employeeId, string firstName, string middleName, string lastName, double salary)
        {
            _employeeId = employeeId;
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _salary = salary;
        }


        public void EmployeeInfo()
        {
            Console.Write("Enter Employee ID: ");
            string employeeId = Console.ReadLine();
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Middle Name (Press enter to Skip): ");
            string middleName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Employee created successfully!\n");
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            PrintFullnName();
            Console.WriteLine($"Salary: {salary:C}\n");
        }

        public void PrintFullnName()
        {
            Console.WriteLine($"Name: {firstName} {middleName} {lastName}");
        }
    }

    abstract class Departments
    {
        public string Name{ get; set; }
        public string detail { get; set; }
        
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {Name}");
        }

    }
    //represents HRDepartment derived from Departments

    class HRDepartment : Departments, IDepartmentOperations
    {
        public HRDepartment ()
        {
            Name = "Human Resources";
            detail = "Details: Handles employee relations and recruitment.";
        }

        public void Operate()
        {
            
            Console.WriteLine("Performing HR Operations ..\n");
        }
    }

    class ITDepartment : Departments, IDepartmentOperations
    {
        public ITDepartment()
        {
            Name = "IT";
            detail = "Details: Manages technical resources and infrastructure.";

        }

        public void Operate()
        {
            
            Console.WriteLine("Performing IT Operations ..\n");
        }
    }

    interface IDepartmentOperations
    {
        void Operate();
    }
}
