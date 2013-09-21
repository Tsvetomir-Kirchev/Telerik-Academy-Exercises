<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_06.Calculator._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Calculator</title>
        <link href="~/Content/Site.css" rel="stylesheet" />
    </head>
    <body>
        <form id="formMain" runat="server">
        <div id="calculator">
            <div>
                <asp:TextBox ID="TbResult" runat="server" Enabled="false"></asp:TextBox>
            </div>
            <div>
                <div>
                    <asp:Button ID="Btn1" runat="server" Text="1" OnClick="Btn_Click" />
                    <asp:Button ID="Btn2" runat="server" Text="2" OnClick="Btn_Click" />
                    <asp:Button ID="Btn3" runat="server" Text="3" OnClick="Btn_Click" />
                    <asp:Button ID="BtnPlus" runat="server" Text="+" OnClick="BtnOperation_Click" />
                </div>
                <div>
                    <asp:Button ID="Btn4" runat="server" Text="4" OnClick="Btn_Click" />
                    <asp:Button ID="Btn5" runat="server" Text="5" OnClick="Btn_Click" />
                    <asp:Button ID="Btn6" runat="server" Text="6" OnClick="Btn_Click" />
                    <asp:Button ID="BtnMinus" runat="server" Text="-" OnClick="BtnOperation_Click" />
                </div>
                <div>
                    <asp:Button ID="Btn7" runat="server" Text="7" OnClick="Btn_Click" />
                    <asp:Button ID="Btn8" runat="server" Text="8" OnClick="Btn_Click" />
                    <asp:Button ID="Btn9" runat="server" Text="9" OnClick="Btn_Click" />
                    <asp:Button ID="BtnMultiply" runat="server" Text="*" OnClick="BtnOperation_Click" />
                </div>
                <div>
                    <asp:Button ID="BtnPI" runat="server" Text="PI" OnClick="Btn_Click" />
                    <asp:Button ID="Btn0" runat="server" Text="0" OnClick="Btn_Click" />
                    <asp:Button ID="BtnDevide" runat="server" Text="/" OnClick="BtnOperation_Click" />
                    <asp:Button ID="BtnSqrt" runat="server" Text="√" OnClick="BtnOperation_Click" />
                </div>
            </div>
            <div>
                <asp:Button ID="BtnClear" runat="server" Text="Clear" OnClick="BtnClear_Click" CssClass="specialBtn" />
                <asp:Button ID="BtnEquals" runat="server" Text="=" OnClick="BtnEquals_Click" CssClass="specialBtn" />
            </div>
        </div>
        </form>
    </body>
</html>
