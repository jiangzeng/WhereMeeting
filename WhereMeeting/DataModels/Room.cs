using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereMeeting.DataModels
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Size { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}
