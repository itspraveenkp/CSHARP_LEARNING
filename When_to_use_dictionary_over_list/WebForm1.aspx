<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="When_to_use_dictionary_over_list.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Code:</td>
                    <td>
                        <asp:TextBox ID="txtCode" runat="server" AutoPostBack="True" OnTextChanged="txtCode_TextChanged" />
                    </td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Capital:</td>
                    <td>
                        <asp:TextBox ID="txtCapital" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
