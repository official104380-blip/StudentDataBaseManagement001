using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentDataBaseManagement001.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext() :
            base("StudentMVC001")
        { }
        public DbSet<Models.Student> Students { get; set; }
    }
}