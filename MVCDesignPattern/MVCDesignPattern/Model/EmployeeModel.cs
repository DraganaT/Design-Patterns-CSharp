using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignPattern
{
    public class EmployeeModel
    {
        String name;
        String idNumber;

        public EmployeeModel(String name, String idNumber)
        {
            this.name = name;
            this.idNumber = idNumber;
        }

        public EmployeeModel()
        {

        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getIdNumber()
        {
            return idNumber;
        }

        public void setIdNumber(String idNumber)
        {
            this.idNumber = idNumber;
        }
    }
}
