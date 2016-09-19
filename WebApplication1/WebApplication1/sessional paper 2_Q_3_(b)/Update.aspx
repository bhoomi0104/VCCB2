<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="WebApplication1.sessional_paper_2_Q_3__b_.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table runat="server">
      <tr><td>  ID:</td><td><asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
   </td></tr><br/>
            <tr><td> Marks:</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        
                </td></tr><br/>
            <tr><td>
        <asp:Button ID="Button1" runat="server" Text="update" OnClick="Button1_Click" /></td></tr>

    </table>
        <br/>
<asp:Label runat="server" ID="l1" Text="label"/>
            </div>
    </form>
</body>
</html>
