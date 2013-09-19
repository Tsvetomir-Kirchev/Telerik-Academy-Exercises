using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04.StudentRegistrationForm
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = this.TbFirstName.Text;
            string lastName = this.TbLastName.Text;
            string facultyNumber = this.TbFacultyNumber.Text;
            string university = this.DropDownUniversities.SelectedValue;
            string speciality = this.DropDownSpecialities.SelectedValue;
            List<string> courses = new List<string>();

            for (int i = 0; i < this.LbCourses.GetSelectedIndices().Length; i++)
            {
                courses.Add(this.LbCourses.Items[i].ToString());
            }

            CreateSummary(firstName, lastName, facultyNumber,
                university, speciality, courses);
        }

        private void CreateSummary(string firstName, string lastName, 
            string facultyNumber, string university, string speciality, List<string> courses)
        {
            this.Registration.Visible = false;

            Panel panel = new Panel();
            panel.ID = "Summary";
            panel.Controls.Add(new LiteralControl("<h3>Summary:</h3>"));
            panel.Controls.Add(new Label { Text = "First Name: " });
            panel.Controls.Add(new Label { Text = firstName, CssClass = "float-right" });
            panel.Controls.Add(new LiteralControl("<br />"));
            panel.Controls.Add(new Label { Text = "Last Name: " });
            panel.Controls.Add(new Label { Text = lastName, CssClass = "float-right" });
            panel.Controls.Add(new LiteralControl("<br />"));
            panel.Controls.Add(new Label { Text = "Faculty Number: " });
            panel.Controls.Add(new Label { Text = facultyNumber, CssClass = "float-right" });
            panel.Controls.Add(new LiteralControl("<br />"));
            panel.Controls.Add(new Label { Text = "University: " });
            panel.Controls.Add(new Label { Text = university, CssClass = "float-right" });
            panel.Controls.Add(new LiteralControl("<br />"));
            panel.Controls.Add(new Label { Text = "Speciality: " });
            panel.Controls.Add(new Label { Text = speciality, CssClass = "float-right" });
            panel.Controls.Add(new LiteralControl("<br />"));
            panel.Controls.Add(new Label { Text = "Courses: " });
            panel.Controls.Add(new LiteralControl("<br />"));
            BulletedList ul = new BulletedList();
            foreach (var course in courses)
            {
                ul.Items.Add(new ListItem(course));
            }
            panel.Controls.Add(ul);
            this.formMain.Controls.Add(panel);
        }

    }
}