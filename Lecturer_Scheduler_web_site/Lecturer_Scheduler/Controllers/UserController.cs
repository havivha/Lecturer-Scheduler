using System.Data;
using System.Linq;
using System.Web.Mvc;
using Lecturer_Scheduler.Models;
using Lecturer_Scheduler.DAL;

namespace Lecturer_Scheduler.Controllers
{ 
    public class UserController : Controller
    {
        //creating a "link" to the DBs
        private LecturerSchedulerContext db = new LecturerSchedulerContext();
   
        
        // GET: /User/
        //responsible for processing incoming requests for index from the user
        public ViewResult Index()
        {
            /// פה צריך לשנות כדי שנוכל לשלוח גם את המסד נתנוים של מערכת השעות וגם את טבלת המשתמש!!!
           
            var viewModel = new AllModels()
            {
                Users = db.Users.ToList(),
                Scheduler = db.Schedulers,
            };
            
            return View(viewModel); // Passed to view as ViewData.Model (or simply Model)
        }

        
        // GET: /User/Details/5
        //responsible for processing incoming requests for Details of specific user 
        public ViewResult Details(int id)
        {
            User user = db.Users.Find(id);
            return View(user);
        }

        
        // GET: /User/Create
        //responsible for processing incoming requests for Create new user 
        public ActionResult Create()
        {
            return View();
        } 

        
        // POST: /User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();

                return RedirectToAction("Index");  
            }

            return View(user);
        }
        
        
        // GET: /User/Edit/5
        //responsible for processing incoming requests for edit the details of specific user 
        public ActionResult Edit(int id)
        {
            User user = db.Users.Find(id);

            return View(user);
        }

        
        // POST: /User/Edit/5
        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        
        // GET: /User/Delete/5
        //responsible for processing incoming requests for Delete of specific user 
        public ActionResult Delete(int id)
        {
            User user = db.Users.Find(id);
            return View(user);
        }

        
        // POST: /User/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //responsible for processing incoming requests to see the Scheduler of specific user 
        public ViewResult Scheduler(int id)
        {
            var userSc = db.Schedulers.Where(i => i.UserId == id);

            return View(userSc);
        }
    }
}