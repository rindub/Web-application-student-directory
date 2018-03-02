using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadatak.DAL;

namespace Zadatak.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext db=new SchoolContext();
        public ActionResult Directory()
        {
            return View(db.Students.ToList());
        }

        
    }
}