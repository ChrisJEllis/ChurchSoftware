using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LifeChurch.Evangelism;

namespace LifeChurch
{
    public partial class MainForm : Form
    {
        //DataAccess.lifechurchEntities LifeChurchContext = new DataAccess.lifechurchEntities();

        public MainForm()
        {
            InitializeComponent();
            
            

        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var att = new Attendance();
            att.ShowDialog();
        }

        private void addRemoveInterestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var interests = new Interests();
            interests.ShowDialog();
        }
    }
}
