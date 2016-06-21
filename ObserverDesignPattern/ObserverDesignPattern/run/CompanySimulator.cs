using ObserverDesignPattern.classes;
using System;

namespace ObserverDesignPattern
{
    class CompanySimulator
    {
        static void Main(string[] args)
        {
            SoftwareCompany company = new SoftwareCompany();

            FirstDepartment firstDepartment = new FirstDepartment(company);
            SecondDepartment secondDepartment = new SecondDepartment(company);
            ThirdDepartment thirdDepartment = new ThirdDepartment(company);

            company.setAssignment(7, "Task 1 of the day ", "1/6/2016");
            Console.Out.WriteLine("\n");
            company.setAssignment(5, "Task 2 of the day", "1/7/2016");
            Console.Out.WriteLine("\n");
            company.setAssignment(8, "Task 3 of the day", "17/7/2016");
        }
    }
}
