using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.Greeting
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string name = this.TbName.Text;
            this.TbGreeting.Text = "Hello, " + name + "!";
            this.TbGreeting.Visible = true;
        }
    }
}