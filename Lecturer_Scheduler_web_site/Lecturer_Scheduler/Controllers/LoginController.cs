using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Lecturer_Scheduler.DAL;

namespace Lecturer_Scheduler.Controllers
{
    public class LoginController : Controller
    {

        //creating a "link" to the DBs
        private Lecturer_Scheduler.DAL.LecturerSchedulerContext Db = new LecturerSchedulerContext();

        //responsible for processing incoming requests for index from the user
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = Db.Users.Where(i => i.FirstName == model.Username && i.Password == model.Password);

                if (user.Any())  //Simulate data store call where Username/Password
                {
                    //Creates an authentication ticket for the supplied user name and adds it to the cookies collection.
                    //false will log off automatically when browser close.
                    FormsAuthentication.SetAuthCookie(model.Username, false); 

                    // checks if the user is the College Secretary if so then redirect to HomeSecretary
                    if (model.Username == "Secretary" && model.Password == "1111")
                    {
                        return RedirectToAction("index", "HomeSecretary");
                    }
                    else  // else the user is one of the lecturers then redirect to Home
                    {
                        return RedirectToAction("index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                }
            }
            return View();
        }

        public String isUserValid(LoginModel model)
        {
            //Simulate data store call where Username/Password
            if (model.Username == "a" && model.Password == "a")  
            {
                return "User is valid";
            }
            else
            {
                return "User is invalid";
            }
        }

    }
}
