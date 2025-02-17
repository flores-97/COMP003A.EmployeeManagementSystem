using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    class ITDepartment : Departments, IDepartmentOperations
    {
        public ITDepartment()
        {
            DepartmentName = "IT";
            detail = "Details: Manages technical resources and infrastructure.";

        }

        public void Operate()
        {

            Console.WriteLine("Performing IT Operations ..\n");
        }
    }
}
