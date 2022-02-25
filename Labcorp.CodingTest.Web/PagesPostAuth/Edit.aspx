<%@ Page Title="" Language="C#" MasterPageFile="~/PagesPostAuth/Default.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Labcorp.CodingTest.Web.PagesPostAuth.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="menu" runat="server">
    <span class="text-125-percent bold">Employee Detail</span>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <table class="layout full-width">
        <tr>
            <td class="half-width"></td>
            <td class="align-center">
                <table class="layout">
                    <tr>
                        <td class="align-right no-wrap">Employee ID:</td>
                        <td class="pad-1-left"><asp:Label ID="labelEmployeeID" runat="server" /></td>
                    </tr>
                    <tr>
                        <td class="align-right no-wrap">Employee Type:</td>
                        <td class="pad-1-left"><asp:Label ID="labelEmployeeType" runat="server" /></td>
                    </tr>
                    <tr>
                        <td class="align-right no-wrap">Days Worked:</td>
                        <td class="pad-1-left"><asp:Label ID="labelDaysWorked" runat="server" /></td>
                    </tr>
                    <tr>
                        <td class="align-right no-wrap">Vacation Days Accrued:</td>
                        <td class="pad-1-left"><asp:Label ID="labelVacationDaysAccrued" runat="server" /></td>
                    </tr>
                    <tr>
                        <td class="align-right no-wrap">Vacation Days Taken:</td>
                        <td class="pad-1-left"><asp:Label ID="labelVacationDaysTaken" runat="server" /></td>
                    </tr>
                </table>
            <td>
            <td class="half-width"></td>
        </tr>
    </table>
    <br />
    <table class="layout full-width">
        <tr>
            <td class="half-width"></td>
            <td><asp:Label ID="labelMessage" CssClass="message-error no-wrap" runat="server" /></td>
            <td class="half-width"></td>
        </tr>
    </table>
    <table class="layout full-width">
        <tr>
            <td class="half-width"></td>
            <td class="align-center">
                <table class="layout">
                    <tr>
                        <td class="align-right no-wrap">Days Worked:</td>
                        <td class="pad-1-left"><asp:TextBox ID="textDaysWorked" Text="0" runat="server" /></td>
                    </tr>
                    <tr>
                        <td class="align-right no-wrap">Vacation Days Taken:</td>
                        <td class="pad-1-left"><asp:TextBox ID="textVacationDaysTaken" Text="0" runat="server" /></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="align-center" colspan="2">
                            <asp:Button ID="buttonApply" CssClass="flat" Text="Apply" OnClick="buttonApply_Click" runat="server" />
                            <asp:Button ID="buttonCancel" CssClass="flat" Text="Cancel" OnClick="buttonCancel_Click" runat="server" />
                            <asp:Button ID="buttonOK" CssClass="flat" Text="OK" OnClick="buttonOK_Click" runat="server" />
                        </td>
                    </tr>
                </table>
            <td>
            <td class="half-width"></td>
        </tr>
    </table>
</asp:Content>