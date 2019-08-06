using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        private const string TEXT_FILE_NAME= "Employee.txt";
        public String Name { get; set; }
        public String Title { get; set; }

        public static void WriteEmployee(Employee employee)
        {
            var emplyeeData = $"{employee.Name},{employee.Title}";
            FileHelper.WriteTextFile(TEXT_FILE_NAME, emplyeeData);
        }
    }
}
