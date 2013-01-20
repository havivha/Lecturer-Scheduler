using System.Linq;
using System.Web.Mvc;
using Lecturer_Scheduler.DAL;
using Lecturer_Scheduler.Models;

namespace Lecturer_Scheduler.Controllers
{
    public class SchedulerController : Controller
    {

        //creating a "link" to the DBs
        private LecturerSchedulerContext db = new LecturerSchedulerContext();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.flag = 0;
            return View();
        }

        //responsible for processing incoming requests for index from the user
        [HttpPost]
        public ActionResult Index(string semester_group, int year)
        {

            ViewBag.flag = 1; // להציג מערכת
            // get the userId by searching in the Users DB for his name. 
            var temp = db.Users.Single(u => u.FirstName.Equals(User.Identity.Name)).LecturerID;

            var userScheduler =
                db.Schedulers.Where(i => i.LecturerID == temp && i.Year == year && i.Semester.Equals(semester_group));
            /*   var userScheduler = from s in db.Schedulers
                                    where (s.LecturerID == temp) && (s.Year == ViewBag.Year) && s.Semester.Equals(ViewBag.Semester)
                                    select s;  */

            var viewModel = new AllModels()
            {
                Users = db.Users.ToList(),
                Scheduler = userScheduler,
            };

              ViewBag.data = viewModel;

            return View(viewModel);
        }
    }
}