<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebFormApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    <p>
        hello</p>
  
        <asp:Label ID="Label1" runat="server" Text="1"></asp:Label>
        &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="加算" OnClick="Button1_Click" /> 
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="97px" ></asp:TextBox>
        &nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="21px">
            <asp:ListItem>＋</asp:ListItem>
            <asp:ListItem>－</asp:ListItem>
            <asp:ListItem>×</asp:ListItem>
            <asp:ListItem>÷</asp:ListItem>
        </asp:DropDownList>
&nbsp; <asp:TextBox ID="TextBox2" runat="server" Height="21px" Width="97px"></asp:TextBox>
&nbsp; =<asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <asp:Button ID="Button2" runat="server" Text="計算" OnClick="Button2_Click" /> 
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <asp:Button ID="Button3" runat="server" Text="一覧表示" OnClick="Button3_Click" /> 
        <div id="pa">
        </div>
    </form>

    <a href="/WebForm2.aspx">削除画面へ</a>
     

</body>
</html>
