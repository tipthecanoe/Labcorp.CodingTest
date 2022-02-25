<%@ Page Title="" Language="C#" MasterPageFile="~/PagesPostAuth/Default.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Labcorp.CodingTest.Web.PagesPostAuth.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="menu" runat="server">
    <span class="text-125-percent bold">Employee Index</span>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <table class="layout full-width">
        <tr>
            <td class="align-center">
                <asp:GridView ID="gridEmployees" AutoGenerateColumns="false"
                    CssClass="material full-width" OnRowCommand="gridEmployees_RowCommand" runat="server">
                    <Columns>
                        <asp:BoundField HeaderText="Employee ID:" DataField="Id" ItemStyle-CssClass="align-center" />
                        <asp:BoundField HeaderText="Employee Type:" DataField="Type" />
                        <asp:BoundField HeaderText="Days Worked:" DataField="WorkDays" ItemStyle-CssClass="align-center" />
                        <asp:BoundField HeaderText="Vacation Days Accrued:" DataField="AccruedVacationDays" DataFormatString="{0:F2}" ItemStyle-CssClass="align-center" />
                        <asp:BoundField HeaderText="Vacation Days Taken:" DataField="TakenVacationDays" ItemStyle-CssClass="align-center" />
                        <asp:ButtonField HeaderText="Action:" ButtonType="Button" CommandName="Edit" Text="Edit" ItemStyle-CssClass="flat" ControlStyle-CssClass="flat" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>