<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminhome.aspx.cs" Inherits="ProjectAsp.adminhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 229px;
        }
        .auto-style3 {
            width: 273px;
        }
        .auto-style4 {
            width: 146px;
        }
        .auto-style5 {
            width: 264px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td colspan="3">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" Text="Category"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Add "></asp:Label>
            </td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style3" colspan="2">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Edit"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="120px" ImageUrl="~/p_image1.jpg" OnClick="ImageButton1_Click" Width="180px" />
            </td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style3" colspan="2">
                <asp:ImageButton ID="ImageButton2" runat="server" Height="120px" ImageUrl="~/p_image2.jpeg" OnClick="ImageButton2_Click" Width="180px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td colspan="4">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" Text="Product"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Add"></asp:Label>
            </td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style3" colspan="2">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" Text="Edit"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">
                <asp:ImageButton ID="ImageButton3" runat="server" Height="120px" ImageUrl="~/p_image3.jpg" OnClick="ImageButton3_Click" Width="180px" />
            </td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style3" colspan="2">
                <asp:ImageButton ID="ImageButton4" runat="server" Height="120px" ImageUrl="~/p_image4.jpg" OnClick="ImageButton4_Click" Width="180px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">
                <asp:Label ID="Label7" runat="server" Text="View Feedback" Font-Bold="True"></asp:Label>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">
                <asp:ImageButton ID="ImageButton5" runat="server" Height="101px" ImageUrl="~/p_image-feedback-admin.jpg" OnClick="ImageButton5_Click" Width="101px" />
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3" colspan="2">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
