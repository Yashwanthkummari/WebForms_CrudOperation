<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product_Create.aspx.cs" Inherits="ProductCrudWebForms.Product_Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 251px;
            font-size:20px;
        }
        .auto-style2 {
            width: 500px;
        }
        .auto-style3 {
            width: 57%;
        }
        #Label1{
            color:royalblue;
            font-size:35px;

        }
        tr{
            margin:10px;
        }
        .auto-style4 {
            width: 659px;
        }
        .gridview-table{
            margin-left: 160px;
        }
        .gridview-table th {
             background-color: #bac2ff;
             color: #333;
             padding: 10px;
             text-align: left;
             border-bottom: 2px solid #ddd;
        }

        .gridview-table td {
             padding: 10px;
             border-bottom: 1px solid #ddd;
             text-align: left;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
</body>
</html>
<table class="auto-style3" style="margin-left:320px;margin-top:50px">
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Create Product"></asp:Label>
        </td>
        <td class="auto-style2"></td>
    </tr>
    <tr>
    <td class="auto-style1">
        <asp:Label ID="Label7" runat="server" Text="ProductId"></asp:Label>
    </td>
    <td class="auto-style2">
        <asp:TextBox ID="txtProdId" runat="server" Height="30px" Width="315px" CssClass="auto-style4"></asp:TextBox>
        </td>
</tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        </td>
        <td class="auto-style2">
            <asp:TextBox ID="txtName" runat="server" Height="30px" Width="315px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label3" runat="server" Text="Brand"></asp:Label>
        </td>
        <td class="auto-style2">
            <asp:TextBox ID="txtBrand" runat="server" Height="30px" Width="315px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label4" runat="server" Text="Category"></asp:Label>
        </td>
        <td class="auto-style2">
            <asp:TextBox ID="txtCat" runat="server" Height="30px" Width="315px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label5" runat="server" Text="Description"></asp:Label>
        </td>
        <td class="auto-style2">
            <asp:TextBox ID="txtDes" runat="server" Height="30px" Width="315px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label6" runat="server" Text="Price"></asp:Label>
        </td>
        <td class="auto-style2">
            <asp:TextBox ID="txtprice" runat="server" Height="30px" Width="315px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
        <td class="auto-style2" style="padding:10px">
            <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" BackColor="royalblue" Height="45px" Width="100px"  style="border:none;color:ghostwhite" />
        &nbsp;
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="update_Click" BackColor="Yellow" Height="45px" Width="100px" style="border:none" />
&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="delete_Click" BackColor="Red" Height="45px" Width="100px" style="border:none" />
        </td>
    </tr>
    
</table>

<asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" 
        Width="900px" style="margin-top:50px" CssClass="gridview-table" >
    <Columns>
       <asp:CommandField ShowSelectButton="True" />
       
    </Columns>
    </asp:GridView>
    
</form>

