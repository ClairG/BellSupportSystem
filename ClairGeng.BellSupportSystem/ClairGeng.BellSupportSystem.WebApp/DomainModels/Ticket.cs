using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClairGeng.BellSupportSystem.WebApp.DomainModels
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Project Name must be required")]
        public string ProjectName { get; set; }
        public DateTime DateTimeReceived { get; set; }

        //[Required(ErrorMessage = "Employee must be required")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        [Required(ErrorMessage = "Description must be required")]
        public string Description { get; set; }
    }
}