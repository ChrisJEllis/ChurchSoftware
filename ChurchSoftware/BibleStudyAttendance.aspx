<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="BibleStudyAttendance.aspx.cs" Inherits="ChurchSoftware.BibleStudies" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvBSAttendance" runat="server" DataSourceID="BSSqlDataSource" AutoGenerateColumns="False"
        DataKeyNames="BibleStudyAttendanceId" EmptyDataText="Bla">
        <Columns>
            <asp:BoundField DataField="BibleStudyAttendanceId" HeaderText="BibleStudyAttendanceId"
                SortExpression="BibleStudyAttendanceId" Visible="false" />
            <asp:BoundField ReadOnly="true" DataField="StudentName" SortExpression="Student"
                HeaderText="StudentName" />
            <asp:BoundField ReadOnly="true" DataField="TeacherName" HeaderText="Teacher" SortExpression="TeacherName" />
            <asp:BoundField ReadOnly="true" DataField="BibleStudyYear" HeaderText="Year" SortExpression="BibleStudyYear" />
            <asp:BoundField ReadOnly="true" DataField="WeekNumber" HeaderText="Week Number" SortExpression="WeekNumber" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Label ID="lblNETaught" Text='<%# Eval("Taught")%>' Enabled="false" runat="server" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:CheckBox ID="chkTaught" Checked='<%# Bind("Taught")%>' Enabled="true" runat="server" />
                </EditItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="BSSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ChurchConnectionString %>"
        ProviderName="<%$ ConnectionStrings:ChurchConnectionString.ProviderName %>" SelectCommand="SELECT        bst.BibleStudyAttendanceId, sp.FirstName + ' ' + sp.LastName AS StudentName, tp.FirstName + ' ' + tp.LastName AS TeacherName, bst.BibleStudyYear, 
                         bst.WeekNumber, bst.Taught
FROM            BibleStudyAttendance AS bst LEFT OUTER JOIN
                         PersonBibleStudy AS pbs ON bst.PersonBibleStudyId = pbs.PersonBibleStudyId LEFT OUTER JOIN
                         BibleStudy AS bs ON bs.BibleStudyId = pbs.BibleStudyId LEFT OUTER JOIN
                         Person AS tp ON tp.PersonId = pbs.TeacherId LEFT OUTER JOIN
                         Person AS sp ON sp.PersonId = pbs.StudentId"
        UpdateCommand="Update BibleStudyAttendance set Taught = @Taught where BibleStudyAttendanceId = @BibleStudyAttendanceId" UpdateCommandType="Text">
        </asp:SqlDataSource>
</asp:Content>
