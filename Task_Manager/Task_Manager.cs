using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    class Task_Manager
    {
        public static void Main()
        {
            Console.WriteLine("Создадим заказчика и ТимЛида ");
            People custom = new People("Заказчик");
            Employee teamleader = new Employee("ТимЛид");
            DateTime deadline = DateTime.Today.AddDays(6);

            Console.WriteLine("Создадим задачи");
            List<Works> tasks = new List<Works>
            {
                new Works("Писать историю", deadline, teamleader, Works.Period.Monthly, 0),
                new Works("Приготовить омлет", deadline, teamleader, Works.Period.None, 0),
                new Works("Закажи отпариватель", DateTime.Now.AddDays(1), teamleader, Works.Period.None, 0),
                new Works("Выйти в дверь", deadline, teamleader, Works.Period.None, 0),
                new Works("Заварить чай", deadline, teamleader, Works.Period.None, 0),
                new Works("Выпить протеин", deadline, teamleader, Works.Period.None, 0),
                new Works("Сделать лабораторную по физике", deadline, teamleader, Works.Period.None, 0),
            };

            Console.WriteLine("Создаем проект");
            Project project = new Project("Выпить протеин и выйти в дверь", deadline, custom, teamleader, tasks);

            Console.WriteLine("Создадим список исполнителей");
            List<Employee> EmployeeTeam = new List<Employee>
            {
                new Employee("Ришат"),
                new Employee("Алексей"),
                new Employee("Екатерина"),
                new Employee("Эвелина"),
                new Employee("Валерий"),
                new Employee("Александр"),
            };

            Console.WriteLine("Назначаем уникальные задачи");
            teamleader.GiveTask(EmployeeTeam, tasks);
            project.AccompleteWork();

            foreach (Employee i in EmployeeTeam)
            {
                i.MadeReport("Так вышло, что я", i.tasks[0]);
            }

            foreach (Employee i in EmployeeTeam)
            {
                foreach (Works j in i.tasks)
                {
                    i.CompleteATask(j);
                }
            }

            Console.WriteLine("Проект завершен!");
            project.Complete();
            Console.WriteLine("Нажмите на любую кнопку, чтобы завершить работу программы.");
            Console.ReadKey();

        }
    }
      
}


