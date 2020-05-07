<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebFormApp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="削除するIDを入力してください。"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="削除" OnClick="Button1_Click" /> 
        </div>
  
        <div>
            <br />
            <asp:Label ID="Label6" runat="server" Text="更新する情報を入力してください。"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="name"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="age"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="country"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="更新" OnClick="Button2_Click" /> 
        </div>
    </form>

    <a href="/WebForm1.aspx">ホーム</a>
</body>
</html>
