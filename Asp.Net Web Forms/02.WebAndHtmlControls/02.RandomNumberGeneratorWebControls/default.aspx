<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_02.RandomNumberGeneratorWebControls._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Random Number Generator</title>
    </head>
    <body>
        <form id="formMain" runat="server">
        <div>
            <h1>Radnom Number Generator</h1>
            Range from:
            <asp:TextBox type="number" id="startNumber" runat="server" />
            To:
            <asp:TextBox type="number" id="endNumber" runat="server" />
            <asp:Button type="button" id="btnGetNumber" runat="server" Text="Get Random Number" 
                OnClick="btnGetNumber_ServerClick"/>
            <br />
            <asp:Label id="lbResult" runat="server"></asp:Label>
        </div>
        </form>
    </body>
</html>
