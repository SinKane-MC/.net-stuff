<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab1_HeatConversion.Conversion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Heat Conversion - Lab 1</title>
    <%-- Author: Wade Grimm --%>
     <meta name="viewport" content="width=device-width, initial-scale=1" />
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="Scripts/popper.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
</head>
<body>

    <div class="container jumbotron">
        <h3>Temperature Conversion by Wade Grimm</h3>
        <form id="form1" class="form-group" runat="server">
            <div class="container-fluid">
                
                <div class="form-row">
                    
                    <div class="form-row col-md-1">
                        
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/thermometer03.png" Height="200px" />
                    </div>
                    <div class="col-xs-2">
                        <asp:Label ID="Label1" runat="server" Text="From:"></asp:Label>
                        <div class="dropdown form-row">
                            <asp:DropDownList ID="ddlFrom" runat="server">
                                <asp:ListItem>Celsius</asp:ListItem>
                                <asp:ListItem>Fahrenheit</asp:ListItem>
                                <asp:ListItem>Kelvin</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <asp:Label ID="Label2" runat="server" Text="To:"></asp:Label>
                        <div class="dropdown form-row">
                            <asp:DropDownList ID="ddlTo" runat="server">
                                <asp:ListItem>Celsius</asp:ListItem>
                                <asp:ListItem Selected="True">Fahrenheit</asp:ListItem>
                                <asp:ListItem>Kelvin</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-row">
                            <asp:TextBox ID="txtInput" class="form-control" runat="server" Width="140px"></asp:TextBox>
                            <asp:Button ID="btnGo" class="btn btn-primary" runat="server" Text="Convert!" OnClick="Button1_Click" />
                            <asp:Button ID="btnClear" class="btn btn-warning" runat="server" Text="Clear" CausesValidation="False" OnClick="btnClear_Click" />
                        </div>
                        <div>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="A value is required" ControlToValidate="txtInput" Display="Dynamic" ForeColor="Red" CssClass="validator"></asp:RequiredFieldValidator>
                        </div>
                        <div>
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Value must be between -1000 and 1000" ForeColor="Red" MaximumValue="1000" MinimumValue="-1000" Type="Double" CssClass="validator" ControlToValidate="txtInput"></asp:RangeValidator>
                        </div>
                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                    </div>
                </div>
            </div>
        </form>
    </div>

</body>
</html>
