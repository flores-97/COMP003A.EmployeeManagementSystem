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
            Console.WriteLine($"Department: {myHR_Department.GetDepartmentDetails}");
            ((IDepartmentOperations)myHR_Department).Operate();

            myIT_Department.DisplayDepartmentInfo();
            Console.WriteLine($"Department: {myIT_Department.GetDepartmentDetails}");
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
            Console.Write("Enter Salary: \n");
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
        public abstract string GetDepartmentDetails();
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {Name}");
        }

    }
    //represents HRDepartment derived from Departments

    class HRDepartment : Departments, IDepartmentOperations
    {
        public string HR_Department { get; set; }
        /// <summary>
        /// constructor for getdepartmentdetails
        /// </summary>
        /// <param name="HR_Department"></param>
        public HRDepartment (string HR_Department)
        {
            Name = "HR Department";
        }
        public override string GetDepartmentDetails()
        {
            return HR_Department;
            Console.WriteLine($"Details: Handles employee relations and recruitment.");
        }

        public void Operate()
        {
            
            Console.WriteLine("Performing HR Operations ..");
        }
    }

    class ITDepartment : Departments, IDepartmentOperations
    {
        public string IT_Department { get; set; }
        /// <summary>
        /// constructor for getdepartmentdetails
        /// </summary>
        /// <param name="IT_Department"></param>
        public ITDepartment(string IT_Department)
        {
            Name = "IT Department";

        }
        public override  string GetDepartmentDetails()
        {
            return IT_Department;
            Console.WriteLine($"Details: Manages technical resources and infrasture.");
        }

        public void Operate()
        {
            
            Console.WriteLine("Performing IT Operations ..");
        }
    }

    interface IDepartmentOperations
    {
        void Operate();
    }
}
