using System.Web.Mvc;
using System.Web.Security;

namespace Lecturer_Scheduler.Controllers
{
    public class LogoutOnSuccessController : Controller
    {
        //
        // GET: /LogoutOnSuccess/

        //responsible for processing incoming requests for index from the user
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            return View();
        }

    }
}
