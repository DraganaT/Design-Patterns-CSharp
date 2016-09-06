using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignPattern
{
    class EmployeeController
    {
        private EmployeeModel model { get; set; }
        private EmployeeView view { get; set; }

        public EmployeeController()
        {

        }

        public EmployeeController(EmployeeModel model, EmployeeView view)
        {
            this.model = model;
            this.view = view;
        }

        public void updateView()
        {
            view.printEmployeeDetails(model.getName(), model.getIdNumber());
        }

        public void setEmployeeName(String name)
        {
            model.setName(name);
        }

        public String getEmployeeName()
        {
            return model.getName();
        }

        public void setEmployeeIdNumber(String number)
        {
            model.setIdNumber(number);
        }

        public String getEmployeeIdNumber()
        {
            return model.getIdNumber();
        }
    }
}
