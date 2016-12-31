using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.DTO;
using DataAccess.DAO;

namespace LifeChurch
{
    public partial class Attendance : Form
    {
        
        public Attendance()
        {
            InitializeComponent();
        }

        private void NewGuestCardMenuItem_Click(object sender, EventArgs e)
        {
            Guest_Card gc = new Guest_Card();
            gc.Show();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            //Load Guests Grid
            PersonDAO personDAO = new DataAccess.DAO.PersonDAO();
            //Load the people into the grid
            gvGuestGrid.DataSource = personDAO.GetPeopleWithAddresses();
        }
    }
}
