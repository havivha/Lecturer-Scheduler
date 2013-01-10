using System.Collections.Generic;

namespace Lecturer_Scheduler.Models
{
    public class AllModels
    {
        //גם פה צריך לבדוק איך צריך להגדיר את המשתנים שיעבוד טוב
        // השארתי לכם את הנסיונות מהאינטרנט אולי נצטרך חלק

        
        //public AvailabilityType AvailabilityType { get; set; }
        //public Scheduler Schedulers { get; set; }
        //public User User { get; set; }
       
       // public IEnumerable<AvailabilityType> AvailabilityType { get; set; }
        public IEnumerable<Scheduler> Scheduler { get; set; }
        //public IEnumerable<User> User { get; set; }


     
         public List<User> Users { get; set; } // -- עם זה זה מאפשר לרשום db.User.TOLIST()
        //public List<Scheduler> Schedulers { get; set; }
        //public List<AvailabilityType> AvailabilityTypes { get; set; }

       
    }
}