using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IbangCreationActivities.Controllers.Entities
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<ReportTime> reportTimes;
    }
}
