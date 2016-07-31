﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdventureWorks.Demo.Models
{
    public class AdventureWorksDemoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public AdventureWorksDemoContext() : base("name=AdventureWorksDemoContext")
        {
        }

        public System.Data.Entity.DbSet<Ejemplo.Model.Employee> Employee { get; set; }

        public System.Data.Entity.DbSet<Ejemplo.Model.EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }

        public System.Data.Entity.DbSet<Ejemplo.Model.Person> Person { get; set; }

        public System.Data.Entity.DbSet<Ejemplo.Model.PersonPhone> PersonPhone { get; set; }

        public System.Data.Entity.DbSet<Ejemplo.Model.Department> Departament { get; set; }
    }
}
