using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    //represents HRDepartment derived from Departments

    class HRDepartment : Departments, IDepartmentOperations
    {
        public HRDepartment()
        {
            DepartmentName = "Human Resources";
            detail = "Details: Handles employee relations and recruitment.";
        }

        public void Operate()
        {

            Console.WriteLine("Performing HR Operations ..\n");
        }
    }
}
