namespace WhereMeeting.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WhereMeeting.DataModels;

    internal sealed class Configuration : DbMigrationsConfiguration<DataModels.Context.WhereMeeting>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DataModels.Context.WhereMeeting context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Booking.RemoveRange(context.Booking);
            context.Room.RemoveRange(context.Room);
            Room room1 = new Room() { Name = "Meeting Room 4A", Location = "B4F MS", Size = 5 };
            Room room2 = new Room() { Name = "Meeting Room 4B", Location = "B4F MS", Size = 10 };
            Room room3 = new Room() { Name = "Meeting Room 5A", Location = "B5F MS", Size = 20 };
            Room room4 = new Room() { Name = "Meeting Room 5B", Location = "B5F MS", Size = 10 };
            context.Room.Add(room1);
            context.Room.Add(room2);
            context.Room.Add(room3);
            context.Room.Add(room4);
            context.SaveChanges();
        }
    }
}
