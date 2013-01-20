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
                new User {LecturerID = 300,  FirstName = "Carson",    LastName = "Alexander", Password  ="a",     Email = "Carson@walla.com" },
                new User {LecturerID = 301,  FirstName = "Meredith",  LastName = "Alonso",    Password  ="b",     Email = "Meredith@hotmail.com" },
                new User {LecturerID = 302,  FirstName = "Arturo",    LastName = "Anand",     Password  ="c",     Email = "Arturo@gmail.com"},
                new User {LecturerID = 303,  FirstName = "Gytis",     LastName = "Barzdukas", Password  = "d",    Email= "Gytis@gmail.com" },
                new User {LecturerID = 304,  FirstName = "Einat",     LastName = "Schaefet",  Password  = "1212", Email= "einat2468@walla.com" },
                new User {LecturerID = 305,  FirstName = "Haviv",     LastName = "zada",      Password  = "1212", Email= "haviv2001@walla.com" },
                new User {LecturerID = 306,  FirstName = "Hadas",     LastName = "Shalom",    Password  = "1212", Email= "hadas_shalom3@walla.com" },
                new User {LecturerID = 307,  FirstName = "Secretary", LastName = "College",   Password  = "1111", Email= "Secretary@jce.ac.il" },
                new User {LecturerID = 308,  FirstName = "Shay",      LastName = "Tavor",     Password  = "1212", Email= "shay_tavor@gmail.com" },
                new User {LecturerID = 309,  FirstName = "miri",      LastName = "cohen",     Password  = "1212", Email= "miri_cohen@jce.ac.il" },
                
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var scheduler = new List<Scheduler>
            {
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 1,  EndTime = 1,  Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 2,  EndTime = 2,  Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 3,  EndTime = 3,  Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 4,  EndTime = 4,  Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 5,  EndTime = 5,  Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 6,  EndTime = 6,  Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 7,  EndTime = 7,  Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 8,  EndTime = 8,  Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 9,  EndTime = 9,  Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 10, EndTime = 10, Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 11, EndTime = 11, Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 12, EndTime = 12, Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 13, EndTime = 13, Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 14, EndTime = 14, Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                new Scheduler {LecturerID = 300, Year = 2013, Semester = "A", StartTime = 15, EndTime = 15, Sunday = "white", Monday = "white", Tuesday = "white", Wednesday = "white", Thursday = "white", Friday = "white"},
                
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