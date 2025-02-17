using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
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

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (string.IsNullOrWhiteSpace(default)) ;
                else
                    _middleName = value;
            }
        }


        /// <summary>
        /// gets or sets salary with validation 
        /// </summary>
        public double Salary
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
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="salary"></param>
        public Employee(string EmployeeId, string FirstName, string MiddleName, string LastName, double Salary)
        {
            _employeeId = EmployeeId;
            _firstName = FirstName;
            _middleName = MiddleName;
            _lastName = LastName;
            _salary = Salary;
        }



        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            PrintFullnName();
            Console.WriteLine($"Salary: {Salary:C}\n");
        }

        public void PrintFullnName()
        {
            Console.WriteLine($"Name: {FirstName} {MiddleName} {LastName}");
        }
    }
}
