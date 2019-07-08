using ClairGeng.BellSupportSystem.WebApp.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClairGeng.BellSupportSystem.WebApp.ViewModels
{
    public class TicketVM
    {
        public Ticket Tickets { get; set; }
        public List<Department> Departments { get; set; }
        public List<Employee> Employees { get; set; }
    }
}