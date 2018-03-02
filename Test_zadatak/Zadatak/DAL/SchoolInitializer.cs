using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zadatak.Models;

namespace Zadatak.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{ FirstName="Pero",LastName="Peric",DateOfBirth=DateTime.Parse("2002-09-01"),Address="ilica 20",ParentName="Lidija"},
            new Student{ FirstName="Marin",LastName="Maric",DateOfBirth=DateTime.Parse("2003-09-01"),Address="ilica 21",ParentName="Sina"},
            new Student{ FirstName="Mirko",LastName="Miric",DateOfBirth=DateTime.Parse("2004-09-01"),Address="ilica 22",ParentName="Pola"},
            new Student{ FirstName="Ivan",LastName="Ivic",DateOfBirth=DateTime.Parse("2005-09-01"),Address="ilica 23",ParentName="Tana"},
            new Student{ FirstName="Pen",LastName="Penic",DateOfBirth=DateTime.Parse("2006-09-01"),Address="ilica 24",ParentName="Za"},
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{Name="Kemija",ProfessorName="Marko",Summary="proucavanje spojeva"},
            new Course{Name="Biologija",ProfessorName="Un",Summary="proucavanje zivota"},
            new Course{Name="Povijest",ProfessorName="Izmir",Summary="proucavanje povijesti"},
            new Course{Name="Geografija",ProfessorName="Tvrtko",Summary="mape"},
           
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            
        }
    }
}