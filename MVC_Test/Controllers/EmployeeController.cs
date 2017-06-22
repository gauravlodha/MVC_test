using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Test.Models;

namespace MVC_Test.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee e1 = new Employee()
            {
                Id = 1,
                Name = "Roopali",
                Gender = "Female",
                City = "Mumbai"
            };
            return View(e1);
        }
    }
}