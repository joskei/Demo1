<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repeater.aspx.cs" Inherits="DataViewingControl.Repeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sample Repeater Control</title>
    <link rel="stylesheet" href="StyleSheet1.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>                
                <div class="rTableRow">
                    <div class="rTableHeadDesc">desc</div>
                    <div class="rTableHeadName">name</div>
                </div>                
            </HeaderTemplate>
            <ItemTemplate>                
                <div class="rTableRow">
                    <div class="rTableCellDesc"><%# XPath("desc") %></div>
                    <div class="rTableCellName"><%# XPath("@name") %></div>
                </div>                
            </ItemTemplate>            
        </asp:Repeater>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Data.xml" XPath="AccessModifiers/modifier"></asp:XmlDataSource>
    </form>
</body>
</html>
