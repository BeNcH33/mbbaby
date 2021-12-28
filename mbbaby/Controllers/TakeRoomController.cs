using LibFor5lab;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mbbaby.Controllers
{
    public class TakeRoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TakeRoom(string Nameroom, string Idteacher)
        {
            int idTeacher = Convert.ToInt32(Idteacher);
            Audit audit = new Audit();
            audit.takeAuditors(Nameroom, idTeacher);


            int counttake = audit.countBusyAuditors();
            ViewBag.name = counttake;
            return View("Index");
        }
    }
}
