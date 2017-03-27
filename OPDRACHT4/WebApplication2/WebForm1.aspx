<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="color: #000000; background-color: #CCCCCC">
    
        <h1 class="auto-style1">Het aftellen is begonnen.</h1>
        <br />Het is vandaag:<br />
        <asp:Label ID="litVandaag" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        Het is nu:<br />
        <asp:Label ID="litTijd" runat="server"></asp:Label>
        <br />
        <br />
        <br /><strong>Wanneer is het Pasen?</strong><br />
        <br />
        <asp:Label ID="litPasen" runat="server"></asp:Label>
    
        <br />
        <asp:Button ID="btnLaden" runat="server" OnClick="btnLaden_Click" Text="verversen" />
    
    </div>
    </form>
</body>
</html>
