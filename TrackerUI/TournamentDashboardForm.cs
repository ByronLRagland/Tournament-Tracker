using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        public TournamentDashboardForm()
        {
            InitializeComponent();

            WireUpList();
        }

        private void WireUpList()
        {
            selectTournamentDropDown.DataSource = tournaments;
            selectTournamentDropDown.DisplayMember = "TournamentName";
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm();
            frm.Show();
        }

        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)selectTournamentDropDown.SelectedItem;
            if (tm != null)
            {
                TournamentViewerForm frm = new TournamentViewerForm(tm);
                frm.Show(); 
            }
            else
            {
                MessageBox.Show("Please enter a valid tournament to load.");
                return;
            }
        }

        private void TournamentDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void selectTournamentDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
