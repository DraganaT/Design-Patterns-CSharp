using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignPattern
{
    class EmployeeView
    {
        public void printEmployeeDetails(String name, String idNumber)
        {
            Console.Out.WriteLine("Employee name: " + name);
            Console.Out.WriteLine("Employee number: " + idNumber);
        }
    }
}
