using System;
using ObserverDesignPattern.Interface;

namespace ObserverDesignPattern.classes
{
    class ThirdDepartment : Observer, ShowTaskInfo
    {
        private string nameOfTask;
        private int numOfEmployees = 20;
        private SoftwareCompany company;
        private string deadlineOfCurrentTasks;
        private int tasksPriority;

        public ThirdDepartment(SoftwareCompany company)
        {
            this.company = company;
            company.registerObserver(this);
        }

        public void show()
        {
            Console.Out.WriteLine("THIRD DEPARTMENT - The task for today is: " + nameOfTask + " assign to "
                 + numOfEmployees + " employees. Task priority is: " + tasksPriority
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
