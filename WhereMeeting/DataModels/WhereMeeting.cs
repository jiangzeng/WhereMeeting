namespace WhereMeeting.DataModels.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WhereMeeting : DbContext
    {
        public WhereMeeting()
            : base("name=WhereMeeting")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<WhereMeeting>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Room> Room { get; set; }
        public DbSet<Booking> Booking { get; set; }
    }
}
