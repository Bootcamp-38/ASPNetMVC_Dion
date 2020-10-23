using ASPNETMVC_Dionisius.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace ASPNETMVC_Dionisius.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("ASPNETMVC_Dionisius") { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Division> Divisions { get; set; }
    }
}