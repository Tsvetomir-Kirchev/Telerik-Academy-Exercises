using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03.ShowEnteredText
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnShowText_Click(object sender, EventArgs e)
        {
            string text = this.TbText.Text;

            this.TbResult.Text = text;
            this.LblResult.Text = Server.HtmlEncode(text);
        }
    }
}