using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device
{
    public class Display
    {
        public float Size { get; set; }

        public int NumberOfCollors { get; set; }

        public Display(float size, int numOfCollors)
        {
            this.Size = size;
            this.NumberOfCollors = numOfCollors;
        }
    }
}
