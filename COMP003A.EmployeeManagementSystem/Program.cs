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





            Console.Write("Enter Employee ID: ");
            string EmployeeId = Console.ReadLine();

            while (true)
            {
                try
                {
                    Console.Write("Enter First Name: ");
                    string firstName = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(firstName)) throw new Exception("First name cannot be blank.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                }
            }

            while (true)
            {
                if (string.IsNullOrWhiteSpace(default))
                {
                    Console.Write("Enter Middle Name (Press enter to Skip): ");
                    string middleName = Console.ReadLine();
                    break;
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter Last Name: ");
                    string lastName = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(lastName)) throw new Exception("Last name cannot be blank.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter Salary: ");
                    double salary = int.Parse(Console.ReadLine());
                    if (salary <= 0) throw new Exception("Salary cannot be below or 0.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\nPlease try agian.\n");
                }
            }

            Console.WriteLine("\nEmployee created successfully!\n");

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
}
