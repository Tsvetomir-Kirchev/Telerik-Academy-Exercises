using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.RandomNumberGenerator
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGetNumber_ServerClick(object sender, EventArgs e)
        {
            try
            {
                int firstNumber = Int32.Parse(this.startNumber.Value);
                int seconNumber = Int32.Parse(this.endNumber.Value);
                Random rand = new Random();
                int randNumber = rand.Next(firstNumber, seconNumber);
                this.result.InnerText = randNumber.ToString();
            }
            catch(FormatException)
            {
                this.result.InnerText = "Wrong Number Format!";
            }
            catch(ArgumentOutOfRangeException)
            {
                this.result.InnerText = "Second number must be greater than first!";
            }
        }
    }
}