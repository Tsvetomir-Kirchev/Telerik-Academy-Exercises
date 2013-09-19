<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_04.StudentRegistrationForm._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Registration Form</title>
        <link href="Content/Site.css" rel="stylesheet" />
    </head>
    <body>
        <form id="formMain" runat="server">
        <div id="Registration" runat="server">
            <fieldset>
                <legend>Registration Form</legend>
                <div>
                    <span>First Name:</span>
                    <asp:TextBox ID="TbFirstName" runat="server" />
                </div>
                <div>
                    <span>Last Name:</span>
                    <asp:TextBox ID="TbLastName" runat="server" />
                </div>
                <div>
                    <span>Faculty Number:</span>
                    <asp:TextBox ID="TbFacultyNumber" runat="server" />
                </div>
                <div>
                    <span>University:</span>
                    <asp:DropDownList ID="DropDownUniversities" runat="server">
                        <asp:ListItem>FMI</asp:ListItem>
                        <asp:ListItem>TU</asp:ListItem>
                        <asp:ListItem>NBU</asp:ListItem>
                        <asp:ListItem>Plovdiv FMI</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div>
                    <span>Speciality:</span>
                    <asp:DropDownList ID="DropDownSpecialities" runat="server">
                        <asp:ListItem>Informatics</asp:ListItem>
                        <asp:ListItem>Software Engineering</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div>
                    <span>Courses:</span>
                    <asp:ListBox ID="LbCourses" runat="server" SelectionMode="Multiple">
                        <asp:ListItem>C# Programming</asp:ListItem>
                        <asp:ListItem>Java Programming</asp:ListItem>
                        <asp:ListItem>Mathematics</asp:ListItem>
                        <asp:ListItem>DSA</asp:ListItem>
                        <asp:ListItem>OOP</asp:ListItem>
                    </asp:ListBox>
                </div>
                <asp:Button ID="BtnSubmit" runat="server" Text="Register"
                    OnClick="BtnSubmit_Click" />
            </fieldset>
        </div>
        </form>
    </body>
</html>
