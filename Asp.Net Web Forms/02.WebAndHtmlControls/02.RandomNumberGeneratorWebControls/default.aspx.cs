using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.RandomNumberGeneratorWebControls
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
                int firstNumber = Int32.Parse(this.startNumber.Text);
                int seconNumber = Int32.Parse(this.endNumber.Text);
                Random rand = new Random();
                int randNumber = rand.Next(firstNumber, seconNumber);
                this.lbResult.Text = randNumber.ToString();
            }
            catch(FormatException)
            {
                this.lbResult.Text = "Wrong Number Format!";
            }
            catch(ArgumentOutOfRangeException)
            {
                this.lbResult.Text = "Second number must be greater than first!";
            }
        }
    }
}