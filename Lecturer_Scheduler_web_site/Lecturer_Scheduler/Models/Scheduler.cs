using System;

namespace Lecturer_Scheduler.Models
{
    //Properties of Scheduler and get/set functions for each property
    public class Scheduler
    {
        public int SchedulerId { get; set; }

        //ForeignKey -- the ID of the user
        public int LecturerID { get; set; }
        public int Year { get; set; }
        public string Semester { get; set; }

        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public String Sunday { get; set; }
        public String Monday { get; set; }
        public String Tuesday { get; set; }
        public String Wednesday { get; set; }
        public String Thursday { get; set; }
        public String Friday { get; set; }

             
    }
}