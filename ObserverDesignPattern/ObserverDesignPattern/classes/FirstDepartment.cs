using System;
using ObserverDesignPattern.Interface;

namespace ObserverDesignPattern.classes
{
    class FirstDepartment : Observer, ShowTaskInfo
    {
        int taskPriority;
        string nameOfTask;
        string deadline;
        Company company;

        public FirstDepartment(Company company)
        {
            this.company = company;
            company.registerObserver(this);
        }

        public void show()
        {
            Console.Out.WriteLine("FIRST DEPARTMENT - Task today is : " + nameOfTask + " the priority of this task is: " + taskPriority
                + " with deadline: " + deadline);
        }

        public void updateTasks(int priority, string employee, string deadline)
        {
            taskPriority = priority;
            nameOfTask = employee;
            this.deadline = deadline;
            show();
        }
    }
}
