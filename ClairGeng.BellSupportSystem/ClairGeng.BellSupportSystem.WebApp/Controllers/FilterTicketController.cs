using ClairGeng.BellSupportSystem.WebApp.DomainModels;
using ClairGeng.BellSupportSystem.WebApp.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClairGeng.BellSupportSystem.WebApp.Controllers
{
    public class FilterTicketController : Controller
    {
        private EFDbContext db = new EFDbContext();
        
        public ActionResult Index(string filterBy, string filter, DateTime? start, DateTime? end, int? page, string sortBy)
        {
            ViewBag.SortName = sortBy == "ProjectName" ? "Name desc" : "ProjectName";
            ViewBag.SortDate = string.IsNullOrEmpty(sortBy) ? "Date desc" : "";
            ViewBag.SortDepartment = sortBy == "DepartmentName" ? "Department desc" : "DepartmentName";
            ViewBag.SortEmployee = sortBy == "EmployeeName" ? "Employee desc" : "EmployeeName";

            var tickets = db.Tickets.AsQueryable();

            if (filterBy == "DateTimeReceived")
            {
                //tickets = tickets.Where(x => x.DateTimeReceived.Equals(filter) || filter == null);
                //tickets = tickets.Where((x => x.DateTimeReceived > start && x.DateTimeReceived < end));
            }
            else if (filterBy == "DepartmentName")
            {
                tickets = tickets.Where(x => x.Employee.Department.Name.Contains(filter) || filter == null);
            }
            else if (filterBy == "EmployeeName")
            {
                tickets = tickets.Where(x => x.Employee.Name.Contains(filter) || filter == null);
            }
            else if (filterBy == "Description")
            {
                tickets = tickets.Where(x => x.Description.Contains(filter) || filter == null);
            }
            else
            {
                tickets = tickets.Where(x => x.ProjectName.Contains(filter) || filter == null);
            }

            switch (sortBy)
            {
                case "Name desc":
                    tickets = tickets.OrderByDescending(x => x.ProjectName);
                    break;
                case "Date desc":
                    tickets = tickets.OrderByDescending(x => x.DateTimeReceived);
                    break;
                case "Department desc":
                    tickets = tickets.OrderByDescending(x => x.Employee.Department.Name);
                    break;
                case "Employee desc":
                    tickets = tickets.OrderByDescending(x => x.Employee.Id);
                    break;
                default:
                    tickets = tickets.OrderBy(x => x.Id);
                    break;
            }

            return View(tickets.ToPagedList(page ?? 1, 3));
        }
    }
}