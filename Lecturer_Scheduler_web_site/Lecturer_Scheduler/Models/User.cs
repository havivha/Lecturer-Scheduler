using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lecturer_Scheduler.Models
{
    //Properties of User and get/set functions for each property
    public class User
    {

        public int UserID { get; set; }

        public int LecturerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public int? PhoneNumber { get; set; }
        public int? NumberEntrance { get; set; }
        public DateTime? LastUpdate { get; set; }
        public virtual ICollection<Scheduler>Schedulers { get; set; }


        
    }
}