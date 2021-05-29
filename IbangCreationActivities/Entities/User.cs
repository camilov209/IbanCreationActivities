using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IbangCreationActivities.Controllers.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string email { get; set; }

        public ICollection<Activity> activities { get; set; }
    }
}
