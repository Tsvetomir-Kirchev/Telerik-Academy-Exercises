using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device
{
    public class Call
    {
        public DateTime Date { get; set; }

        public string DialedPhoneNumber { get; set; }

        public int Duration { get; set; }

        public Call(DateTime date, string phNumber, int duration)
        {
            this.Date = date;
            this.DialedPhoneNumber = phNumber;
            this.Duration = duration;
        }
    }
}
