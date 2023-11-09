using System;
using System.Collections.Generic;

namespace Task_Manager
{
    public class Project
    {
        public enum Status
        {
            Project,
            Execution,
            Closed
        }
        public Status status = Status.Project;
        public string description;
        public DateTime deadlines;
        public People customer;
        public Employee teamleader;

        public List<Works> tasks = new List<Works>();

        public bool Complete()
        {
            foreach(Works i in tasks)
            {
                if (i.status != Works.Status.Done)
                {
                    Console.WriteLine($"Задача {i} не была закончена");
                    return false;
                }
            }
            return true;
        }

        public void Assigned(Works works)
        {
            if (status == Status.Project)
            {
                tasks.Add(works);
            }
            else
            {
                Console.WriteLine("Статус не находится в Проекте");
            }
        }

        public void AccompleteWork()
        {
            status = Status.Execution;
        }

        public Status GetStatus()
        {
            return status;
        }

        public Project(string description, DateTime deadlines, People customer, Employee teamleader, List<Works> works)
        {
            this.description = description;
            this.deadlines = deadlines;
            this.customer = customer;
            this.teamleader = teamleader;
            this.tasks = tasks;
        }
    }
}
