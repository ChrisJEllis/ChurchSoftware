using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataAccess.DAO;

namespace ChurchSoftware
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PersonDAO personDAO = new DataAccess.DAO.PersonDAO();
            //Load the people into the grid
            gvAttendanceReport.DataSource = personDAO.GetPeopleWithAddresses();
            gvAttendanceReport.DataBind();
            
            //Load the Drop Down List
            ddlCurrentDiscipleMakerPersonId.DataSource = personDAO.GetPeople();
            ddlCurrentDiscipleMakerPersonId.DataBind();
        }
        protected void btnSavePerson_Click(object sender, EventArgs e) {
            //ChurchSqlDataSource.Insert();

            PersonDAO personDAO = new DataAccess.DAO.PersonDAO();
            DateTime? holyGhost = CEHolyGhost.SelectedDate;
            DateTime? baptized = CEBaptised.SelectedDate;

            personDAO.AddPerson(txtfname.Text, txtmInitial.Text, txtlname.Text, txtGender.Text, chkMember.Checked, holyGhost, baptized, (int?)null);

            txtfname.Text = "";
            txtmInitial.Text = "";
            txtlname.Text = "";
            txtGender.Text = "";
            chkMember.Checked = false;
            //    , holyGhost, baptised, 0);
        }

        protected void gvAttendanceReport_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvAttendanceReport.EditIndex = e.NewEditIndex;
            gvAttendanceReport.DataBind();
        }
    }
}