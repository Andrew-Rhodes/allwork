using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskListADO.Models;
using TaskListADO.Data;

namespace TaskListADO
{
    class Program
    {
        static void Main(string[] args)
        {
            DBRepository repo = new DBRepository();

            List<Task> tasks = repo.GetAll();

            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.DateEntered} {task.Description} {task.DueDate} {task.Notes}");
            }

            Console.WriteLine();


            Task myTask = repo.GetById(3);

            Console.WriteLine($"{myTask.TaskId} {myTask.Description}");
            Console.WriteLine($"{myTask.DateEntered.ToLongDateString()}");
            if (myTask.DueDate != null)
            {
                Console.WriteLine($"This is due on {((DateTime) myTask.DueDate).ToLongDateString()}");

            }
            Console.WriteLine($"{myTask.Notes}");

            Console.WriteLine();

            CallStoredProc(repo);

            Console.ReadLine();
        }

        public static void CallStoredProc(DBRepository repo)
        {
            List<Employee> employees = repo.GetAllEmployees();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.EmpId} - {employee.FirstName} - {employee.LastName}");

                Console.WriteLine("GRANTS");
                foreach (var grant in employee.Grants)
                {
                    Console.WriteLine($"\t{grant.GrantId} - {grant.GrantName} - {grant.GrantName}");
                }

            }
        }
    }
}
