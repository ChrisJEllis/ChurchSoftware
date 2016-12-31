<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AttendanceReport.aspx.cs" Inherits="ChurchSoftware.Attendance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvAttendanceReport" runat="server" 
        DataSourceID="ChurchSqlDataSource" AutoGenerateColumns="False" 
    DataKeyNames="AttendanceId">
        <Columns>
            <asp:BoundField DataField="AttendanceId" HeaderText="AttendanceId" 
                InsertVisible="false" ReadOnly="True" SortExpression="AttendanceId" Visible="false" />
            <asp:BoundField DataField="Name" SortExpression="Name" HeaderText="Name" />
            <asp:BoundField DataField="AttendanceDate" HeaderText="AttendanceDate" SortExpression="AttendanceDate" />
            <asp:BoundField DataField="AttendanceType" HeaderText="AttendanceType" SortExpression="AttendanceType" />
        </Columns>
    </asp:GridView>
<asp:SqlDataSource ID="ChurchSqlDataSource" runat="server" 
    ConnectionString="<%$ ConnectionStrings:ChurchConnectionString %>" 
    ProviderName="<%$ ConnectionStrings:ChurchConnectionString.ProviderName %>" 
    SelectCommand="SELECT a.AttendanceId, p.FirstName + ' ' + p.LastName as Name, a.ServiceDate FROM Attendance a left join Person p on p.PersonId = a.PersonId"></asp:SqlDataSource>
</asp:Content>
