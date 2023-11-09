using System;
using System.Collections.Generic;

namespace Task_Manager
{
    public class Employee : People
    {
        public Employee(string name) : base(name) { }
        public List<Works> tasks = new List<Works>();

        public bool MarkReport(Reports report)
        {
            if (report.str.Contains("I don't know"))
            {
                return false;
            }

            return true;
        }

        public void MadeReport(string text, Works works)
        {
            Reports report = new Reports(this , text);
            if (works.perk.MarkReport(report))
            {
                works.reports.Add(report);
            }
            else
            {
                Console.WriteLine("Сообщение об ошибке");
            }
        }
        

        public void GiveTask(List<Employee> employees, List<Works> tasks)
        {
            foreach(Works i in tasks)
            {
                foreach(Employee j in employees)
                {
                    if (j.GetWork(i))
                    {
                        break;
                    }
                }
            }
        }
        public virtual bool HasATask()
        {
            return tasks.Count != 0;
        }

        public virtual void CompleteATask(Works works)
        {
            works.status = Works.Status.Done;
        }
        public bool GetWork(Works works)
        {
            if (tasks.Count == 0)
            {
                tasks.Add(works);
                works.status = Works.Status.Assigned;
                works.performer = this;
                Console.WriteLine($"{name}, берет задачу {works}");
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{name} исполнитель - задача: {tasks}";
        }
    }
}
