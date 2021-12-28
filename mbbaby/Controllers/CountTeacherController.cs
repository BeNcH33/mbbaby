using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibFor5lab;

namespace mbbaby.Controllers
{
    public class CountTeacherController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult AddTeacher(string Name, string Count) 
        {
            int count = Convert.ToInt32(Count);
            Audit audit = new Audit();
            for (int i=1; i <= count; i++)
            {
                audit.addTeacher(Name);
            }           

            int countteacher=audit.countTeachers();
            ViewBag.name = countteacher;
            return View("Index");
        }
    }
}
