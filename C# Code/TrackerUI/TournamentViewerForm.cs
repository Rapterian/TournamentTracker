using System.ComponentModel;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        //BindingSource matchupBinding = new BindingSource();
        //BindingSource roundBinding = new BindingSource();
        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            tournament.OnTournamentComplete += Tournament_OnTournamentComplete;

            LoadFormData();
            LoadRounds();



        }

        private void Tournament_OnTournamentComplete(object? sender, DateTime e)
        {
            this.Close();
        }

        private void LoadFormData()
        {
            tournamentNameLabel.Text = tournament.TournamentName;
        }

        private void WireupRoundsLists()
        {
            //roundBinding.DataSource = rounds;
            //roundDropDown.DataSource = roundBinding;
            roundDropDown.DataSource = rounds;
        }

        private void WireupMatchupsLists()
        {

            //matchupBinding.DataSource = selectedMatchups;
            //matchupListBox.DataSource = matchupBinding;
            //matchupListBox.DisplayMember = "DisplayName";
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
        }


        private void LoadRounds()
        {
            rounds = new BindingList<int>();
            int currRound = 1;
            rounds.Add(1);

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }

            }

            //roundBinding.ResetBindings(false);
            WireupRoundsLists();
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
            //matchupListBox_SelectedIndexChanged(this, null);
        }

        private void LoadMatchups()
        {
            int round = (int)roundDropDown.SelectedItem;
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups = new BindingList<MatchupModel>(matchups);
                }
            }
            // TODO - make sure Unplayed checkbox still works
            var filteredMatchups = selectedMatchups.Where(m => m.Winner == null || !unplayedOnlyCheckBox.Checked).ToList();
            selectedMatchups = new BindingList<MatchupModel>(filteredMatchups);
            //matchupBinding.ResetBindings(false);
            WireupMatchupsLists();

            displayMatchupInfo();

        }

        private void displayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);
            teamOneNameLabel.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;
            teamOneScoreValue.Visible = isVisible;
            teamTwoNameLabel.Visible = isVisible;
            teamTwoScoreLabel.Visible = isVisible;
            teamTwoScoreValue.Visible = isVisible;
            versusLabel.Visible = isVisible;
            scoreButton.Visible = isVisible;
        }

        private void LoadMatchup()
        {

            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneNameLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamOneScoreValue.Value = (decimal)m.Entries[0].Score;

                        teamTwoNameLabel.Text = "<bye>";
                        teamTwoScoreValue.Value = 0;
                    }
                    else
                    {
                        teamOneNameLabel.Text = "Not Yet Set";
                        teamOneScoreValue.Value = 0;
                    }

                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoNameLabel.Text = m.Entries[1].TeamCompeting.TeamName;
                        teamTwoScoreValue.Value = (decimal)m.Entries[1].Score;
                    }
                    else
                    {
                        teamTwoNameLabel.Text = "Not Yet Set";
                        teamTwoScoreValue.Value = 0;
                    }
                }
            }
        }

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }

        private void unplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();
            if (errorMessage.Length > 0)
            {
                MessageBox.Show($"Input Error: {errorMessage}");
                return;
            }

            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneNameLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                        m.Entries[0].Score = (double)teamOneScoreValue.Value;
                    }

                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoNameLabel.Text = m.Entries[1].TeamCompeting.TeamName;
                        m.Entries[1].Score = (double)teamTwoScoreValue.Value;
                    }
                }
            }

            try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The application had the following error: {ex.Message}");
                return;
            }

            LoadMatchups();

            
        }

        private string ValidateData()
        {
            string output = "";

            if (teamOneScoreValue.Value == 0 && teamTwoScoreValue.Value == 0)
            {
                output= "You did not enter a score for either team";
            }else if (teamOneScoreValue.Value == teamTwoScoreValue.Value)
            {
                output= "We do not allow ties in this application";
            }

            return output;
        }
    }
}