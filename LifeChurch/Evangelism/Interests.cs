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

namespace LifeChurch.Evangelism
{
    public partial class Interests : Form
    {
        public Interests()
        {
            InitializeComponent();
        }

        private void Interests_Load(object sender, EventArgs e)
        {
            BindGridData();
        }

        private void BindGridData()
        {
            InterestDAO i = new InterestDAO();
            var interests = i.GetInterests();
            gvInterests.DataSource = interests;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            InterestDAO i = new InterestDAO();
            int interestId = i.AddInterest(txtInterest.Text);
            if (interestId != 0)
            {
                MessageBox.Show("Interest Added");
            }
            txtInterest.Text = "";
            BindGridData();
            
        }
    }
}
