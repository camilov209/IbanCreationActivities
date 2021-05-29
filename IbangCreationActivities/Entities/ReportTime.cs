using System;
using System.ComponentModel.DataAnnotations;

namespace IbangCreationActivities.Controllers.Entities
{
    public class ReportTime
    {
        [Key]
        public int Id { get; set; }

        public DateTime date { get; set; }

        public int hours { get; set; }

        public Activity activities;
    }
}
