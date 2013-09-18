<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_03.ShowEnteredText._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="formMain" runat="server">
        <div>
            <asp:TextBox ID="TbText" runat="server"></asp:TextBox>
            <asp:Button ID="BtnShowText" runat="server" Text="Show Text"
                OnClick="BtnShowText_Click" />
            <h3>Result:</h3>
            <asp:TextBox ID="TbResult" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LblResult" runat="server"></asp:Label>
        </div>
        </form>
    </body>
</html>
