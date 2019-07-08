using ClairGeng.BellSupportSystem.WebApp.DomainModels;
using ClairGeng.BellSupportSystem.WebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClairGeng.BellSupportSystem.WebApp.Controllers
{
    public class CreateTicketController : Controller
    {
        private EFDbContext db = new EFDbContext();
        
        public ActionResult Index()
        {
                ViewBag.departments = db.Departments.ToList();
                return View();
        }

        public ActionResult loadEmployee(int departmentId)
        {
                return Json(db.Employees.Where(e => e.DepartmentId == departmentId).Select(e => new
                {
                    Id = e.Id,
                    Name = e.Name
                }).ToList(),JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateTickets(Ticket createTickets)
        {
            if (ModelState.IsValid)
            {
                Ticket t = new Ticket();
                t.ProjectName = createTickets.ProjectName;
                t.DateTimeReceived = DateTime.Now;
                t.EmployeeId = createTickets.EmployeeId;
                t.Description = createTickets.Description;

                db.Tickets.Add(t);
                db.SaveChanges();

                return View("Completed");
            }
            else
            {
                return View("Index");
            }            
        }
    }
}