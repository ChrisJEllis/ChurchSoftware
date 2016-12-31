using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.DAO;
using DataAccess.DTO;

namespace LifeChurch
{
    public partial class Guest_Card : Form
    {
        public Guest_Card()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PersonDAO p = new PersonDAO();
            int personId = p.AddPerson(fNametxt.Text, miNametxt.Text, lNametxt.Text, null, false, null, null, null);
            
            //Add address to person
            var zip = Ziptxt.Text == "" ? null : Ziptxt.Text;

            AddressDAO a = new AddressDAO();
            a.AddAddress(Addresstxt.Text, null, (int)ddlCity.SelectedValue, (int)ddlState.SelectedValue, zip, null, 1, 1);

            //Best time to call
            var hours = BestTimeToCalldtp.Value.Hour;
            var minutes = BestTimeToCalldtp.Value.Minute;
            TimeSpan bestTimeToCall = new TimeSpan(hours,minutes,0);

            int? ageGroupId = Under18Cb.Checked ? 1 : EighteenThruTwentyNineCb.Checked ? 2 : ThirtiesCb.Checked ? 3 : FourtiesCb.Checked ? 4 : FiftiesCb.Checked ? 5 : SixtyPlusCb.Checked ? 6 : (int?)null;
            int? maritalStatusId = MarriedCb.Checked ? 1 : SingleCb.Checked ? 2 : OtherCb.Checked ? 3 : (int?)null;

            VisitorInterviewDAO vi = new VisitorInterviewDAO();
            int visitorInterviewId = vi.AddVisitorInterview(personId, false, Convert.ToDateTime(Datedtp.Text), Addresstxt.Text, Convert.ToInt32(ddlCity.SelectedValue), Ziptxt.Text, PhoneCb.Checked, MailCb.Checked, EmailCb.Checked
                , bestTimeToCall, FirstTimeGuestCb.Checked, SecondTimeGuestCb.Checked, ThirdTimeGuestCb.Checked, ageGroupId, maritalStatusId, null);

            //Insert Visitor Interests
            

            //Update Visitor Interview.

        }

        private void Guest_Card_Load(object sender, EventArgs e)
        {
            Datedtp.Value = DateTime.Now;

            LoadDefaultValues();
        }

        private void LoadDefaultValues()
        {
            //Populate City and State ddl
            StateDAO s = new StateDAO();
            List<StateDTO> states = s.GetStates();
            ddlState.DataSource = states;
            ddlState.ValueMember = "StateId";
            ddlState.DisplayMember = "StateName";

            CityDAO c = new CityDAO();
            List<CityDTO> cities = c.GetCities();
            ddlCity.DataSource = cities;
            ddlCity.ValueMember = "CityId";
            ddlCity.DisplayMember = "CityName";
        }

        private void btnLoadPerson_Click(object sender, EventArgs e)
        {

        }
    }
}
