using System;
using IbangCreationActivities.Controllers.Entities;
using Microsoft.EntityFrameworkCore;
namespace IbangCreationActivities.Contexts
{
    public class AppDbContext : DbContext
    { 
        public AppDbContext(DbContextOptions<AppDbContext> context): base(context)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<ReportTime> Time { get; set; }
    }
}
