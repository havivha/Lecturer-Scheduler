using System.Web.Mvc;
using Lecturer_Scheduler.DAL;

namespace Lecturer_Scheduler.Controllers
{
    public class HomeController : Controller
    {
        private LecturerSchedulerContext Db = new LecturerSchedulerContext();

        //responsible for processing incoming requests for index from the user
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Lecturer Scheduler Web!";
            return RedirectToAction("index", "Scheduler");
        }

        //responsible for processing incoming requests for about from the user
        public ActionResult About()
        {
            return View();
        }
    }
}
