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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();


        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpList();
        }
        /// <summary>
        /// Makes the team member dropdown show all available team member's first name and las name 
        /// as well as all the selected team members in the list box
        /// </summary>
        private void WireUpList()
        {
            // TODO - see if there is a better way to fix the refreshing of the data binding

            //have to make it null first so that it refreshes every time the wireup method is called
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }
        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateAddMembersForm().Length == 0)
            {
                PersonModel p = new PersonModel();

                p.FirstName = memberFirstNameValue.Text;
                p.LastName = memberLastNameValue.Text;
                p.EmailAddres = memberEmailValue.Text;
                p.CellphoneNumber = memberCellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpList();

                ResetAddNewMemberForm();
            }
            else
            {
                MessageBox.Show(ValidateAddMembersForm());
            }
        }

        /// <summary>
        /// Makes sure all fields in the add member area of the form is filled in correctly
        /// </summary>
        /// <returns>returns all the mistakes made in a string</returns>
        private string ValidateAddMembersForm()
        {
            string output = "Please fill in the following field(s):";

            if (memberFirstNameValue.Text.Length == 0)
            {
                output = String.Concat(output, "\nFirst Name");
            }

            if (memberLastNameValue.Text.Length == 0)
            {
                output = String.Concat(output, "\nLast Name");
            }

            // TODO - check that all email requirements are met
            if (memberEmailValue.Text.Length == 0)
            {
                output = String.Concat(output, "\nEmail");
            }

            // TODO - check if it is only numbers
            if (memberCellphoneValue.Text.Length != 10)
            {
                output = String.Concat(output, "\nCellphone(must be 10 numbers)");
            }

            if (output == "Please fill in the following field(s):")
            {
                output = "";
            }

            return output;
        }

        /// <summary>
        /// resets tha add member part of the form
        /// </summary>
        private void ResetAddNewMemberForm()
        {
            memberFirstNameValue.Text = "";
            memberLastNameValue.Text = "";
            memberEmailValue.Text = "";
            memberCellphoneValue.Text = "";

        }

        /// <summary>
        /// creates sample data to test the form 
        /// </summary>
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "JJ", LastName = "De Kock" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Rapanzel", LastName = "Hellenburg" });
        }

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpList();
            }

        }

        private void removeSelectedMembersButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpList();
            }


        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            
            TeamModel t = new TeamModel();

            // TODO - Make sure the team name is not empty
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t); 
            
            // TODO - if we aren't closing this form after creation, reset the form

        }
    }
}
