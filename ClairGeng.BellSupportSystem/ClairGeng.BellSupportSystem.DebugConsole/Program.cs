using ClairGeng.BellSupportSystem.WebApp.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClairGeng.BellSupportSystem.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EFDbContext())
            {
                Department d = new Department();
                d.Name = "IT";
                ctx.Departments.Add(d);
                Employee e = new Employee();
                e.Name = "CG";
                ctx.Employees.Add(e);
                Ticket t = new Ticket();
                t.ProjectName = "test";
                t.DateTimeReceived = DateTime.Now;
                t.Description = "teeeest";
                ctx.Tickets.Add(t);
                ctx.SaveChanges();
            }
            Console.WriteLine("ok");
            Console.ReadLine();
        }
    }
}
