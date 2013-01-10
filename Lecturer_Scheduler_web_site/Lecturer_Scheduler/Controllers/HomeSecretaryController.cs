using System.Web.Mvc;

namespace Lecturer_Scheduler.Controllers
{
    public class HomeSecretaryController : Controller
    {
        //
        // GET: /HomeSecretary/

        //responsible for processing incoming requests for index from the user
        public ActionResult Index()
        {
            return RedirectToAction("index", "User");
        }

    }
}
