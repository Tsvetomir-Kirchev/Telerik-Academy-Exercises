<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_05.TicTacToe._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Tic Tac Toe</title>
        <link href="Content/Site.css" rel="stylesheet" />
    </head>
    <body>
        <form id="formMain" runat="server">
        <div id="game">
            <h2>Scores:</h2>
            <div id="scores">
                <asp:Label ID="LbPlayerScores" runat="server"></asp:Label>
                <asp:Label ID="LbComputerScores" runat="server"></asp:Label>
            </div>
            <asp:Button ID="Btn00" runat="server" OnClick="Btn_Click" />
            <asp:Button ID="Btn01" runat="server" OnClick="Btn_Click" />
            <asp:Button ID="Btn02" runat="server" OnClick="Btn_Click" />
            <br />
            <asp:Button ID="Btn10" runat="server" OnClick="Btn_Click" />
            <asp:Button ID="Btn11" runat="server" OnClick="Btn_Click" />
            <asp:Button ID="Btn12" runat="server" OnClick="Btn_Click" />
            <br />
            <asp:Button ID="Btn20" runat="server" OnClick="Btn_Click" />
            <asp:Button ID="Btn21" runat="server" OnClick="Btn_Click" />
            <asp:Button ID="Btn22" runat="server" OnClick="Btn_Click" />
            <br />
            <asp:Label ID="Winner" runat="server" Visible="false"></asp:Label>
            <asp:Button ID="BtnStartNewGame" runat="server" Text="Start New Game"
                OnClick="BtnStartNewGame_Click" Visible="false" />
        </div>
        </form>
    </body>
</html>
