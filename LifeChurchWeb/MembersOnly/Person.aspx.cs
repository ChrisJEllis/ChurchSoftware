using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataAccess.DAO;

namespace LifeChurchWeb
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                PersonDAO personDAO = new DataAccess.DAO.PersonDAO();
                //Load the people into the grid
                gvAttendanceReport.DataSource = personDAO.GetPeopleWithAddresses();
                gvAttendanceReport.DataBind();

                //Load the Drop Down List
                ddlCurrentDiscipleMakerPersonId.DataSource = personDAO.GetPeople();
                ddlCurrentDiscipleMakerPersonId.DataBind();
            }
            else
                Response.Redirect("~/Account/Login");
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

        protected void gvAttendanceReport_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int indexToDelete;
            if (int.TryParse(gvAttendanceReport.Rows[e.RowIndex].Cells[0].Text,out indexToDelete)) {
                VisitorInterviewDAO viDAO = new VisitorInterviewDAO();
                

                PersonDAO personDAO = new PersonDAO();
                personDAO.DeletePerson(indexToDelete);
            }

        }
    }
}