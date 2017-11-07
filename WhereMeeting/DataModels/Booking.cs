using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereMeeting.DataModels
{
    public class Booking
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public virtual Room Room { get; set; }
    }
}
