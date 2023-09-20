using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresidentialEligibilityWinForm
{
    public partial class EligibilityTest : Form
    {
        private bool isNaturalBornCitizen;
        private bool isThirtyFiveYearsOld;
        private bool isResidentOfUSForFourteenYears;
        private bool hasBeenImpeached;
        private bool hasRebelled;
        private bool hasServedTwoTerms;
        public EligibilityTest()
        {
            InitializeComponent();

            isNaturalBornCitizen = IsNaturalBorn.Checked;
            isThirtyFiveYearsOld = AgeSlider.Value >= 35;
            isResidentOfUSForFourteenYears = ResidedSlider.Value >= 14;
            hasBeenImpeached = IsImpeached.Checked;
            hasRebelled = HaveRebelled.Checked;
            hasServedTwoTerms = PresidentSlider.Value >= 2;
        }

        private void IsNaturalBorn_CheckedChanged(object sender, EventArgs e)
        {
            isNaturalBornCitizen = IsNaturalBorn.Checked;
        }

        private void AgeSlider_ValueChanged(object sender, EventArgs e)
        {
            isThirtyFiveYearsOld = AgeSlider.Value >= 35;
        }

        private void PresidentSlider_ValueChanged(object sender, EventArgs e)
        {
            hasServedTwoTerms = PresidentSlider.Value >= 6;
        }

        private void ResidedSlider_ValueChanged(object sender, EventArgs e)
        {
            isResidentOfUSForFourteenYears = ResidedSlider.Value >= 14;
        }

        private void HaveRebelled_CheckedChanged(object sender, EventArgs e)
        {
            hasRebelled = HaveRebelled.Checked;
        }

        private void IsImpeached_CheckedChanged(object sender, EventArgs e)
        {
            hasBeenImpeached = IsImpeached.Checked;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (isNaturalBornCitizen && isThirtyFiveYearsOld && isResidentOfUSForFourteenYears && !hasBeenImpeached &&
                !hasRebelled && !hasServedTwoTerms)
            {
                Elegibility.Text = @"You are eligible to be President of the United States!";
            }
            else
            {
                Elegibility.Text = @"You are not eligible to be President of the United States.";
            }
        }
    }
}
