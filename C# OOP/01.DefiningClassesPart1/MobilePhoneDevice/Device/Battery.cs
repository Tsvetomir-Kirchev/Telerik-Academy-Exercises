using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device
{
    public class Battery
    {
        public string Model { get; set; }

        public BatteryType Type { get; set; }

        public int HoursIdle { get; set; }

        public int HoursTalk { get; set; }

        public Battery(string model, BatteryType type, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }
    }
}
