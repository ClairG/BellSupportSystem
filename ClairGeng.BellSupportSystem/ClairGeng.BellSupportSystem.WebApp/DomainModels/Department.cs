﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClairGeng.BellSupportSystem.WebApp.DomainModels
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        //public virtual Employee Employee { get; set; }
    }
}