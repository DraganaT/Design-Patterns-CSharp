using ObserverDesignPattern.Interface;
using System.Collections.Generic;

namespace ObserverDesignPattern.classes
{
    class SoftwareCompany : Company
    {
        List<Observer> observers;
        int taskPriority;
        string nameOfTask;
        string deadline;

        public List<Observer> Observers { get; set; }

        public int TaskPriority { get; set; }

        public SoftwareCompany()
        {
            Observers = new List<Observer>();
        }

        public void notifyObservers()
        {
            for (int i = 0; i < Observers.Count; i++)
            {
                Observer observer = Observers[i];
                observer.updateTasks(taskPriority, nameOfTask, deadline);
            }
        }

        public void registerObserver(Observer o)
        {
            Observers.Add(o);

        }

        public void removeObserver(Observer o)
        {
            int i = Observers.IndexOf(o);
            if (i >= 0)
            {
                Observers.RemoveAt(i);
            }
        }
        public void assignmentChanged()
        {
            notifyObservers();
        }

        public void setAssignment(int taskPriority, string employee, string deadline)
        {
            this.taskPriority = taskPriority;
            this.nameOfTask = employee;
            this.deadline = deadline;
            assignmentChanged();
        }
    }
}
