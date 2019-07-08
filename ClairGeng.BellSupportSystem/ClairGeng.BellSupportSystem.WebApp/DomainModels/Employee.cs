using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClairGeng.BellSupportSystem.WebApp.DomainModels
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}