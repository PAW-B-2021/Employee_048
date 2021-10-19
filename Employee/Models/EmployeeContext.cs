using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    //File : /Models/EmployeeContext.cs
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public int EmployeeId { get; internal set; }
    }
}
