<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%--<label>Watcho Name</label>--%>
        <asp:Label ID="lblGreeting" runat="server" Text="Watcho Name Boi?" Font-Size="XX-Large"></asp:Label>
        <div>

        </div>
        <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl="~/images/download (1).jpg" Width="382px" />
&nbsp;<asp:Image ID="Image2" runat="server" Height="200px" ImageUrl="~/images/download (2).jpg" Width="312px" />
        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/2010-Kawasaki-Vulcan-1700-Voyager_0211.jpg" />
        <p>
            <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Dis ma Truck, and dat ma Kar, and me Scoot!"></asp:Label>
        </p>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="btnName" runat="server" OnClick="btnName_Click" Text="Button" />
    </form>
</body>
</html>
