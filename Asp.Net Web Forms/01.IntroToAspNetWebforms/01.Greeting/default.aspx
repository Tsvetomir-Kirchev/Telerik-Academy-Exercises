<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_01.Greeting._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="formDefault" runat="server">
        <div>
            Enter your name: 
            <asp:TextBox ID="TbName" runat="server"></asp:TextBox>
            <asp:Button ID="BtnSubmit" runat="server" Text="Greet me" OnClick="BtnSubmit_Click" />
            <br />
            <asp:TextBox ID="TbGreeting" runat="server" Enabled="false" Visible="false"></asp:TextBox>
        </div>
        </form>
    </body>
</html>
