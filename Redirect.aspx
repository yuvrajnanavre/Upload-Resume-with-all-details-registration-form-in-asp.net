<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Redirect.aspx.cs" Inherits="xBiz_Assesment.Redirect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>Please Select Option that you want and go</td>
                </tr>
                <tr>
                    <td>&nbsp;<asp:RadioButton ID="RadioButton1" runat="server" GroupName="redirect" OnCheckedChanged="RadioButton1_Checked" Text="Add Employee Details" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" GroupName="redirect" OnCheckedChanged="RadioButton2_Checked" Text="View Employee Details " />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
