using LibFor5lab;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mbbaby.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddRoom(string Name, string Count)
        {
            int count = Convert.ToInt32(Count);
            Audit audit = new Audit();
            for (int i = 1; i <= count; i++)
            {
                audit.addRoom(Name);
            }

            int countteacher = audit.countAuditors();
            ViewBag.name = countteacher;
            return View("Index");
        }
    }
}
