<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="LifeChurchWeb.Person" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Button ID="btnAddPerson" runat="server" Text="Add Person" />
    <%--DataSourceID="ChurchSqlDataSource"--%>
    <asp:GridView ID="gvAttendanceReport" runat="server" 
        DataKeyNames="PersonId" OnRowEditing="gvAttendanceReport_RowEditing" OnRowDeleting="gvAttendanceReport_RowDeleting">
        <Columns>
            <asp:BoundField DataField="PersonId" ItemStyle-CssClass="invisible" HeaderStyle-CssClass="invisible" />
            <asp:ButtonField CommandName="Edit" ButtonType="Button" Text="Edit"/>
            <asp:ButtonField CommandName="Delete" ButtonType="Button" Text="Delete" />
<%--            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" CommandName="Edit" Text="Edit" />
                </ItemTemplate>
            </asp:TemplateField>--%>

            <asp:TemplateField HeaderText="First Name">
                <ItemTemplate>
                    <asp:Label ID="lblFirstName" runat="server" Text='<%# Eval("First_Name") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtFirstName" runat="server" Text='<%# Bind("First_Name") %>' ></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Middle Initial">
                <ItemTemplate>
                    <asp:Label ID="lblMiddleInitial" runat="server" Text='<%# Eval("Middle_Initial") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtMiddleInitial" runat="server" Text='<%# Bind("Middle_Initial") %>' ></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Last Name">
                <ItemTemplate>
                    <asp:Label ID="lblLastName" runat="server" Text='<%# Eval("Last_Name") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtLastName" runat="server" Text='<%# Bind("Last_Name") %>' ></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
<%--            <asp:TemplateField HeaderText="Gender">
                <ItemTemplate>
                    <asp:Label ID="lblGender" runat="server" Text='<%# Eval("Gender") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="txtGender" runat="server" SelectedValue='<%# Bind("Gender") %>' >
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Unknown</asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>
            </asp:TemplateField>--%>
           <%-- <asp:TemplateField HeaderText="Member?">
                <ItemTemplate>
                    <asp:CheckBox ID="cbIsMember" runat="server" Checked='<%# Eval("ChurchMember") %>' Enabled="false"></asp:CheckBox>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:CheckBox ID="cbEditIsMember" runat="server" Checked='<%# Bind("ChurchMember") %>' Enabled="true"></asp:CheckBox>
                </EditItemTemplate>
            </asp:TemplateField>--%>
            <asp:TemplateField HeaderText="Holy Ghost?">
                <ItemTemplate>
                    <asp:Label ID="lblHolyGhost" runat="server" Text='<%# Eval("Holy_Ghost", "{0:d}") %>' Enabled="false"></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtHolyGhost" runat="server" Text='<%# Bind("Holy_Ghost", "{0:d}") %>' Enabled="true"></asp:TextBox>
                    <asp:CalendarExtender ID="ceHolyGhost" runat="server" TargetControlID="txtHolyGhost" Format="MM/dd/yyyy">
                    </asp:CalendarExtender>
                    <asp:FilteredTextBoxExtender ID="fteHolyGhost" TargetControlID="txtHolyGhost" runat="server" FilterType="Custom" ValidChars="/0123456789"></asp:FilteredTextBoxExtender>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Baptised?">
                <ItemTemplate>
                    <asp:Label ID="lblBaptised" runat="server" Text='<%# Eval("Baptized", "{0:d}") %>' Enabled="false"></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtBaptised" runat="server" Text='<%# Bind("Baptized", "{0:d}") %>' Enabled="true"></asp:TextBox>
                    <asp:CalendarExtender ID="ceBaptised" runat="server" TargetControlID="txtBaptised" Format="MM/dd/yyyy">
                    </asp:CalendarExtender>
                    <asp:FilteredTextBoxExtender ID="fteBaptised" TargetControlID="txtBaptised" runat="server" FilterType="Custom" ValidChars="/0123456789"></asp:FilteredTextBoxExtender>
                </EditItemTemplate>
            </asp:TemplateField>
            <%--<asp:TemplateField HeaderText="Current Disciple Maker">
                <ItemTemplate>
                    <asp:Label ID="lblCurrentDiscipleMakerPersonId" runat="server" Text='<%# Eval("FullName") %>' Enabled="false"></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="ddlCurrentDiscipleMakerPersonId" DataTextField="FullName" DataValueField="PersonId" runat="server" DataSourceID="ChurchSqlDataSource"/>
                </EditItemTemplate>
            </asp:TemplateField>--%>
            <asp:TemplateField HeaderText="Address Line 1">
                <ItemTemplate>
                    <asp:Label ID="lblAddressLine1" runat="server" Text='<%# Eval("AddressLine1") %>' Enabled="false"></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtAddressLine1" runat="server" Text='<%# Bind("AddressLine1") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="City">
                <ItemTemplate>
                    <asp:Label ID="lblCity" runat="server" Text='<%# Eval("City") %>' Enabled="false"></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtCity" runat="server" Text='<%# Bind("City") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="State">
                <ItemTemplate>
                    <asp:Label ID="lblState" runat="server" Text='<%# Eval("State") %>' Enabled="false"></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtState" runat="server" Text='<%# Bind("State") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Zip">
                <ItemTemplate>
                    <asp:Label ID="lblZip" runat="server" Text='<%# Eval("Zip") %>' Enabled="false"></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtZip" runat="server" Text='<%# Bind("Zip") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:ModalPopupExtender TargetControlID="btnAddPerson" runat="server" PopupControlID="pnlAddPerson" BackgroundCssClass="modalBackground" ></asp:ModalPopupExtender>
    <asp:Panel ID="pnlAddPerson" runat="server" CssClass="pnlBackGround">
        <table>
            <tr><td>Add Person</td><td></td></tr>
            <tr><td>First Name: </td><td><asp:TextBox ID="txtfname" runat="server" /></td></tr>
            <tr><td>Middle Initial: </td><td><asp:TextBox ID="txtmInitial" runat="server" /></td></tr>
            <tr><td>Last Name: </td><td><asp:TextBox ID="txtlname" runat="server" /></td></tr>
            <tr><td>Gender: </td><td>
                    <asp:DropDownList ID="txtGender" runat="server" >
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Unknown</asp:ListItem>
                    </asp:DropDownList>
            </td></tr>
            <tr><td>Is this person a member: </td><td><asp:Checkbox ID="chkMember" runat="server" Checked="false" /></td></tr>
            <tr>
                <td>Holy Ghost: </td>
                <td>
                    <asp:TextBox ID="txtHolyGhost" runat="server" />
                    <asp:CalendarExtender ID="CEHolyGhost" TargetControlID="txtHolyGhost" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Baptised: </td>
                <td>
                    <asp:TextBox ID="txtBaptised" runat="server" />
                    <asp:CalendarExtender ID="CEBaptised" TargetControlID="txtBaptised" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Current Discipleship Maker: </td>
                <td>
                    <asp:DropDownList ID="ddlCurrentDiscipleMakerPersonId" DataTextField="FullName" DataValueField="PersonId" runat="server" />
                </td>
            </tr>

            <tr>
                <td>Address Line 1: </td>
                <td>
                    <asp:TextBox ID="txtAddressLine1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Address Line 2: </td>
                <td>
                    <asp:TextBox ID="txtAddressLine2" runat="server" />
                </td>
            </tr>
            <tr>
                <td>City: </td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server" />
                </td>
            </tr>
            <tr>
                <td>State: </td>
                <td>
                    <asp:TextBox ID="txtState" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Zip: </td>
                <td>
                    <asp:TextBox ID="txtZip" runat="server" />
                </td>
            </tr>
        </table>
        <asp:Button ID="btnSavePerson" runat="server" Text="Save" OnClick="btnSavePerson_Click" />
        <asp:Button ID="btnCancelAddPerson" runat="server" Text="Cancel" />
    </asp:Panel>

</asp:Content>
