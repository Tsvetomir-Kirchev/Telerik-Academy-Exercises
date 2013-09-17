<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_01.RandomNumberGenerator._default" %>

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
            <input type="number" id="startNumber" runat="server" />
            To:
            <input type="number" id="endNumber" runat="server" />
            <input type="button" id="btnGetNumber" runat="server" value="Get Random Number" 
                onserverclick="btnGetNumber_ServerClick"/>
            <div id="result" runat="server"></div>
        </div>
        </form>
    </body>
</html>
