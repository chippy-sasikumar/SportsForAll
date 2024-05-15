<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewbill.aspx.cs" Inherits="ProjectAsp.viewbill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            width: 155px;
        }
        .auto-style3 {
            width: 92px;
        }
        .auto-style4 {
            height: 26px;
            width: 92px;
        }
        .auto-style5 {
            width: 155px;
            height: 45px;
        }
        .auto-style6 {
            height: 45px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td colspan="4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td colspan="4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td colspan="4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td colspan="4">
                <table class="w-100">
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Invoice" BorderStyle="Groove" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                        </td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="2">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td colspan="4">&nbsp;</td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td colspan="2">
                            <asp:Label ID="Label2" runat="server" Text="Bill No:"></asp:Label>
                            <asp:Label ID="lblbillno" runat="server"></asp:Label>
                        </td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td colspan="2">
                            <asp:Label ID="Label3" runat="server" Text="Date"></asp:Label>
                            :<asp:Label ID="lbldate" runat="server"></asp:Label>
                        </td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td colspan="2">
                            <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Shipping Address :"></asp:Label>
                        </td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td colspan="4">
                            <asp:Label ID="lblshipadr" runat="server"></asp:Label>
                        </td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td colspan="4">
                            <asp:Label ID="lbladr" runat="server"></asp:Label>
                        </td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td colspan="4">
                            <asp:Label ID="lblpin" runat="server"></asp:Label>
                        </td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td colspan="4">&nbsp;</td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td colspan="7">
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="551px">
                                <Columns>
                                    <asp:BoundField DataField="ProName" HeaderText="Product Name" />
                                    <asp:BoundField DataField="ProPrice" HeaderText="Unit Price" />
                                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                                    <asp:BoundField DataField="TotalPrice" HeaderText="Total Amount" />
                                </Columns>
                                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                <RowStyle BackColor="White" ForeColor="#330099" />
                                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                                <SortedDescendingHeaderStyle BackColor="#7E0000" />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Grand Total" Font-Bold="True"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblgtotal" runat="server" Font-Bold="True"></asp:Label>
                        </td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5"></td>
                        <td class="auto-style6">
                            <asp:Label ID="Label5" runat="server" Text="Account Number"></asp:Label>
                        </td>
                        <td class="auto-style6">
                            <asp:TextBox ID="txtaccno" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style6" colspan="2">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtaccno" ErrorMessage="Enter Account number"></asp:RequiredFieldValidator>
                        </td>
                        <td class="auto-style6" colspan="3"></td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="btnpay" runat="server" Text="Pay" OnClick="btnpay_Click" />
                        </td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>
                <asp:Label ID="Label6" runat="server"></asp:Label>
                        </td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="lblstatus" runat="server"></asp:Label>
                        </td>
                        <td colspan="2">&nbsp;</td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style1" colspan="2">
                &nbsp;</td>
            <td class="auto-style1" colspan="2">
                &nbsp;</td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td colspan="4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td colspan="4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
