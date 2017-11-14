using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereMeeting
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            SetDefaultStartEndTime();
        }

        private void SetDefaultStartEndTime()
        {
            DateTime now = DateTime.Now;
            this.timeStart.Value = now.AddMinutes(now.Minute > 30 ? (60 - now.Minute) : (30 - now.Minute));
            this.timeEnd.Value = this.timeStart.Value.AddHours(1);
        }
    }
}
