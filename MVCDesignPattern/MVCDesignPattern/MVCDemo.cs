using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignPattern
{
    class MVCDemo
    {
        static void Main(string[] args)
        {
            EmployeeModel model = getEmployee();

            EmployeeView view = new EmployeeView();

            EmployeeController controller = new EmployeeController(model, view);

            controller.updateView();

            controller.setEmployeeIdNumber("456");

            controller.updateView();
        }

        public static EmployeeModel getEmployee()
        {
            EmployeeModel employee = new EmployeeModel();
            employee.setName("Dragana");
            employee.setIdNumber("123");
            return employee;
        }
    }
}
