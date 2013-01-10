using System;

namespace Lecturer_Scheduler.Models
{
    //Properties of Scheduler and get/set functions for each property
    public class Scheduler
    {
        public int SchedulerId { get; set; }

        //ForeignKey -- the ID of the user
        public int UserId { get; set; }

        public String Day { get; set; }
        public int AvailabilityTypeId {get; set;}
        public int StartTime { get; set; }
        public  int EndTime { get; set; }
        public int Year { get; set; }
        public string Semester { get; set; }

   

    }
}