﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        private IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel prizeModel = new PrizeModel();

                prizeModel.PlaceNumber = Convert.ToInt32(placeNumberValue.Value);
                prizeModel.PlaceName = placeNameValue.Text;
                prizeModel.PrizeAmount = prizeAmountValue.Value;
                prizeModel.PrizePercentage = prizePercentageValue.Value;

                GlobalConfig.Connection.CreatePrize(prizeModel);


                callingForm.prizeComplete(prizeModel);
                this.Close();

            }
            else
            {
                MessageBox.Show("Please enter a name for the place");
            }
        }

        private bool ValidateForm()
        {

            if (placeNameValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            placeNameValue.Clear();
            placeNumberValue.Value = 0;
            prizeAmountValue.Value = 0;
            prizePercentageValue.Value = 0;
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {
            placeNumberValue.Controls.RemoveAt(0);
            prizeAmountValue.Controls.RemoveAt(0);
            prizePercentageValue.Controls.RemoveAt(0);
        }
    }
}
