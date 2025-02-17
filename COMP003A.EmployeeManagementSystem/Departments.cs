using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    abstract class Departments
    {
      
        public string DepartmentName { get; set; }
        public string detail { get; set; }

        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department: {DepartmentName}");
        }

        public void GetDisplayDepartmentDetails()
        {
            Console.WriteLine($"{detail}");
        }
    }
}
