<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="p_viewproducts.aspx.cs" Inherits="ProjectAsp.p_viewproducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="5">
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="167px" ImageUrl='<%# Eval("ProImage") %>' OnCommand="ImageButton1_Command" Width="168px" CommandArgument='<%# Eval("ProId") %>' />
                        <br />
                        <asp:Label ID="lblproname" runat="server" Text='<%# Eval("ProName") %>' Font-Bold="True" Font-Size="X-Large"></asp:Label>
                        <br />
                        <asp:Label ID="lblprice" runat="server" Font-Bold="True" Font-Size="XX-Large" Text='<%# Eval("ProPrice") %>'></asp:Label>
                        <br />
                        <asp:Label ID="lblprodes" runat="server" Text='<%# Eval("ProDescription") %>' Font-Bold="True" Font-Size="Large"></asp:Label>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>
</asp:Content>
