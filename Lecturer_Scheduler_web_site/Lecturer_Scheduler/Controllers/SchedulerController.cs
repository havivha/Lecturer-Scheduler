using System.Linq;
using System.Web.Mvc;
using Lecturer_Scheduler.DAL;

namespace Lecturer_Scheduler.Controllers
{
    public class SchedulerController : Controller
    {

        //creating a "link" to the DBs
        private LecturerSchedulerContext db = new LecturerSchedulerContext();

        //responsible for processing incoming requests for index from the user
        public ViewResult Index()
        {
            return View(db.Schedulers.ToList());
        }
    }
}
