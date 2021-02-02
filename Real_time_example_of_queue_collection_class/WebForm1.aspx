<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Real_time_example_of_queue_collection_class.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="font-family:Arial; border:1px solid black; text-align:center;">
                <tr>
                    <td>
                        <b>Counter 1</b>
                     </td>
                    <td></td>
                    <td>
                       <b> Counter 2</b>
                    </td>
                    <td></td>
                    <td>
                        <b>Counter 3</b>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtCounter1" runat="server" BackColor="Blue" Font-Size="Large"
                            ForeColor="White" Width="150px"></asp:TextBox>
                    </td>
                    <td></td>
                    <td>
                        <asp:TextBox ID="txtCounter2" runat="server" BackColor="Blue" Font-Size="Large"
                            ForeColor="White" Width="150px"></asp:TextBox>
                    </td>
                    <td></td>
                    <td>
                        <asp:TextBox ID="txtCounter3" runat="server" BackColor="Blue" Font-Size="Large"
                            ForeColor="White" Width="150px"></asp:TextBox>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCounter1" runat="server" Text="Next" Width="150px" OnClick="btnCounter1_Click" />
                    </td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnCounter2" runat="server" Text="Next" Width="150px" OnClick="btnCounter2_Click" />
                    </td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnCounter3" runat="server" Text="Next" Width="150px" onclick="btnCounter3_Click"/>
                    </td>
                    <td></td>
                </tr>
                <tr>
                   <td colspan="5">
                       <asp:TextBox ID="txtDisplay" runat="server" BackColor="Green" ForeColor="White" Font-Size="Large" 
                           Width="500px"></asp:TextBox>
                   </td>
                </tr>
                <tr>
                   <td colspan="5">
                       <asp:ListBox ID="listToken" runat="server" Font-Size="Large" Width="100px" ></asp:ListBox>
                   </td>
                </tr>
                <tr>
                   <td colspan="5">
                       <asp:Button ID="btnPrintToken" Text="Print Token" runat="server" OnClick="btnPrintToken_Click"/>
                   </td>
                </tr>
                <tr>
                   <td colspan="5">
                       <asp:Label ID="lblStatus" runat="server" Font-Size="Large" />
                   </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
