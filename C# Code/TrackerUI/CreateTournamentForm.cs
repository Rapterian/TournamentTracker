using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamReqeuster
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpList();
        }

        private void WireUpList()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            tournamentPrizesListBox.DataSource = null;
            tournamentPrizesListBox.DataSource = selectedPrizes;
            tournamentPrizesListBox.DisplayMember = "PlaceName";
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;
            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpList();
            }
        }

        private void createPrize_Click(object sender, EventArgs e)
        {
            //Call CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();


        }

        public void prizeComplete(PrizeModel prize)
        {
            //Get back from the form a PrizeModel
            //Take prizeModel and put it into our list of selected prizes
            selectedPrizes.Add(prize);
            WireUpList();
        }

        public void teamComplete(TeamModel team)
        {
            selectedTeams.Add(team);
            WireUpList();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void removeSelectedPlayersButton_Click(object sender, EventArgs e)
        {

            TeamModel teamModel = (TeamModel)tournamentTeamsListBox.SelectedItem;
            if (teamModel != null)
            {
                selectedTeams.Remove(teamModel);
                availableTeams.Add(teamModel);

                WireUpList();
            }
        }

        private void removeSelectedPrizesButton_Click(object sender, EventArgs e)
        {
            PrizeModel prizeModel = (PrizeModel)tournamentPrizesListBox.SelectedItem;
            if (prizeModel != null)
            {
                selectedPrizes.Remove(prizeModel);

                WireUpList();
            }
        }
    }
}
