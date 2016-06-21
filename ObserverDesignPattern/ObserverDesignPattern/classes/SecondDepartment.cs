using System;
using ObserverDesignPattern.Interface;

namespace ObserverDesignPattern.classes
{
    class SecondDepartment : Observer, ShowTaskInfo
    {
        private string nameOfTask;
        private int numOfEmployees = 40;
        private SoftwareCompany company;
        private string deadlineOfCurrentTasks;
        private int tasksPriority;

        public SecondDepartment(SoftwareCompany company)
        {
            this.company = company;
            company.registerObserver(this);
        }

        public void show()
        {
            Console.Out.WriteLine("SECONT DEPARTMENT - The task is: " + nameOfTask + " for  "
                 + numOfEmployees + " employees. With  priority: " + tasksPriority
                 + " from a scale to 1-10, with deadline " + deadlineOfCurrentTasks);
        }

        public void updateTasks(int priority, string employee, string deadline)
        {
            nameOfTask = employee;
            deadlineOfCurrentTasks = deadline;
            tasksPriority = priority;
            show();
        }
    }
}
