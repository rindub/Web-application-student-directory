using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Zadatak.Models;

namespace Zadatak.DAL
{
    public class SchoolContext:DbContext
    {
        public SchoolContext():base("cs")
        {

        }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}