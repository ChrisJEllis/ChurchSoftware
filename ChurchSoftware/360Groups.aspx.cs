using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChurchSoftware
{
    public partial class _360Groups : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
//            SELECT  dmp.PersonId as DiscipleMakerId, dmp.FirstName + ' ' + dmp.LastName as DiscipleMakerFullName, dp.PersonId as DiscipleId, dp.FirstName + ' ' + dp.LastName as DiscipleFullName
//FROM  360Groups g
//LEFT JOIN PersonBibleStudy ON [360Groups].PersonBibleStudyId = PersonBibleStudy.PersonBibleStudyId 
//LEFT JOIN Person dmp on dmp.PersonId = g.DiscipleMakerPersonId
//LEFT JOIN Person dp on dp.PersonId = g.DisciplePersonId
//LEFT JOIN BibleStudyAttendance bsa on bsa.StudentId = PersonBibleStudy.StudentId
        }
    }
}