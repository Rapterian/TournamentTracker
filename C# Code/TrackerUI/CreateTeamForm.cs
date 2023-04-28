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
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm().Length == 0)
            {
                PersonModel p = new PersonModel();

                p.FirstName = memberFirstNameValue.Text;
                p.LastName = memberLastNameValue.Text;
                p.EmailAddres = memberEmailValue.Text;
                p.CellphoneNumber = memberCellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                ResetAddNewMemberForm();
            }
            else
            {
                MessageBox.Show(ValidateForm());
            }
        }

        private string ValidateForm()
        {
            string output="Please fill in the following field(s):";

            if (memberFirstNameValue.Text.Length == 0)
            {
                output=String.Concat(output, "\nFirst Name");
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

            if(output== "Please fill in the following field(s):")
            {
                output = "";
            }

            return output;
        }

        private void ResetAddNewMemberForm()
        {
            memberFirstNameValue.Text = "";
            memberLastNameValue.Text = "";
            memberEmailValue.Text = "";
            memberCellphoneValue.Text = "";

        }
    }
}
