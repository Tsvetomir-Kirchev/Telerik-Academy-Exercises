using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.UserProfile
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var url = new[]
            {
                new { Name = "Home", Url = "/default.aspx"},
                new { Name = "Personal Info", Url = "/PersonalInfo.aspx" },
                new {Name = "Additional Info", Url = "/AdditionalInfo.aspx"},
                new { Name = "Friends", Url = "/Friends.aspx"}
            };

            this.RepeaterNavigation.DataSource = url;
            this.RepeaterNavigation.DataBind();
        }
    }
}