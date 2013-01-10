using System.Web.Mvc;

namespace Lecturer_Scheduler.Controllers
{
    public class LogoutOnFailureController : Controller
    {
        //
        // GET: /LogoutOnFailure/

        //responsible for processing incoming requests for index from the user
        public ActionResult Index()
        {
            return View();
        }

    }
}
