using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Lecturer_Scheduler.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Lecturer_Scheduler.DAL
{
    public class LecturerSchedulerContext : DbContext
    {


        public DbSet<User> Users { get; set; }
        public DbSet<Scheduler> Schedulers { get; set; }
        public DbSet<AvailabilityType> AvailabilityTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }


}
