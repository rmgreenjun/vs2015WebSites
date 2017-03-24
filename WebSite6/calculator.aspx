<%@ Page Language="C#" AutoEventWireup="true" CodeFile="calculator.aspx.cs" Inherits="calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1">
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
    </div>
        <div id="div2">
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Subtract" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Multiply" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Divide" OnClick="Button4_Click" />
        </div>
        <div id="div3">
            <asp:Label ID="Label1" runat="server" Text="Results"></asp:Label>
            <asp:Label ID="arithmeticresults" runat="server"></asp:Label>
        </div>
        <div id="div4">
            <asp:Label ID="Label2" runat="server" Text="Errors"></asp:Label>
            <asp:Label ID="errorslabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
