using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lecturer_Scheduler.Models
{
    //Properties of AvailabilityType and get/set functions for each property
    public class AvailabilityType
    {
        public int AvailabilityTypeId { get; set; }
        public String Description { get; set; }

       
    }
}