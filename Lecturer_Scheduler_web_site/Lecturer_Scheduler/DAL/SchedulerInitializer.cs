using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Lecturer_Scheduler.Models;

namespace Lecturer_Scheduler.DAL
{
    public class SchedulerInitializer : DropCreateDatabaseIfModelChanges<LecturerSchedulerContext>
    {
        protected override void Seed(LecturerSchedulerContext context)
        {

            var users = new List<User>
            {
                new User { UserID = 4444, FirstName = "Carson",   LastName = "Alexander",   Password  ="a", Email = "Carson@walla.com" },
                new User { UserID = 1111, FirstName = "Meredith", LastName = "Alonso",      Password  ="b", Email = "Meredith@hotmail.com" },
                new User { UserID = 2222, FirstName = "Arturo",   LastName = "Anand",       Password  ="c", Email = "Arturo@gmail.com"},
                new User {UserID = 3333,  FirstName = "Gytis",    LastName = "Barzdukas",   Password  = "d", Email= "Gytis@gmail.com" },
                new User {UserID = 3333,  FirstName = "Einat",    LastName = "Schaefet",   Password  = "1212", Email= "einat2468@walla.com" },
                new User {UserID = 3333,  FirstName = "Haviv",    LastName = "zada",   Password  = "1212", Email= "haviv2001@walla.com" },
                new User {UserID = 3333,  FirstName = "Hadas",    LastName = "Shalom",   Password  = "1212", Email= "hadas_shalom3@walla.com" },
                new User {UserID = 3333,  FirstName = "Secretary",    LastName = "College",   Password  = "1111", Email= "Secretary@jce.ac.il" },
                
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var scheduler = new List<Scheduler>
            {
                new Scheduler {SchedulerId=1, UserId = 4444, AvailabilityTypeId = 1, Day = "sunday", StartTime = 1600, EndTime = 1700, Year = 2012, Semester = "a"},
                new Scheduler {SchedulerId=2, UserId = 4444, AvailabilityTypeId = 1, Day = "monday", StartTime = 1600, EndTime = 1700, Year = 2012, Semester = "a"},
                new Scheduler {SchedulerId=3, UserId = 1111, AvailabilityTypeId = 1, Day = "tusday", StartTime = 1600, EndTime = 1700, Year = 2012, Semester = "a"},
                new Scheduler {SchedulerId=4, UserId = 3333, AvailabilityTypeId = 1, Day = "friday", StartTime = 1600, EndTime = 1700, Year = 2012, Semester = "a"},
            };
            scheduler.ForEach(s => context.Schedulers.Add(s));
            context.SaveChanges();

            var availabilityTypes = new List<AvailabilityType>
            {
                new AvailabilityType {AvailabilityTypeId = 1, Description = "can"},
                new AvailabilityType {AvailabilityTypeId = 2, Description = "maybe"},
                new AvailabilityType {AvailabilityTypeId = 3, Description = "can't"},
            };
            availabilityTypes.ForEach(s => context.AvailabilityTypes.Add(s));
            context.SaveChanges();

        }

    }
}