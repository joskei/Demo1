<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Demo1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Hello GTT!</h1>
        <asp:Label ID="lblQuestion" runat="server" Text="1+1+1x0+1 = "></asp:Label>
        <asp:Label ID="lblAnswer" runat="server" Text="?"></asp:Label><br/>
        <asp:Button ID="btnAnswer" runat="server" Text="Answer" OnClick="btnAnswer_Click" />

    </div>
    </form>
</body>
</html>
