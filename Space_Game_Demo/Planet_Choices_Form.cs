using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Game_Demo
{
    public partial class Planet_Choices_Form : Form
    {
        public Planet_Choices_Form()
        {
            InitializeComponent();
        }

        //global variables
        int LowRiskPlanetDie;
        int HighRiskPlanetDie;

        private void btnLowRisk_Click(object sender, EventArgs e)
        {
            //opens up the low risk planet form
            low_risk_planet_form load = new low_risk_planet_form();
            load.ShowDialog();
        }

        private void btnHighRisk_Click(object sender, EventArgs e)
        {
            //opens up the high risk planet form
            high_risk_planet_form load = new high_risk_planet_form();
            load.ShowDialog();
        }

        private void Planet_Choices_Form_Load(object sender, EventArgs e)
        {
            //load the prologue form first. 
            prologue_form prologue = new prologue_form();
            prologue.ShowDialog();

            //load the entry form second
            EntryForm entry = new EntryForm();
            entry.ShowDialog();

            //instantiate dice object  
            Random dice = new Random();

            //roll between 1 to 8
            LowRiskPlanetDie = dice.Next(1, 9);
            HighRiskPlanetDie = dice.Next(1, 9);

            //method to display the planets
            ShowPlanets(LowRiskPlanetDie, HighRiskPlanetDie);
        }

        private void ShowPlanets(int LowRiskPlanetDie, int HighRiskPlanetDie)
        {
            //determines which low risk planet will display
            if (LowRiskPlanetDie == 1)
            {
                this.LowRiskPlanetOne.Visible = true;
                this.LowRiskPlanetTwo.Visible = false;
                this.LowRiskPlanetThree.Visible = false;
                this.LowRiskPlanetFour.Visible = false;
                this.LowRiskPlanetFive.Visible = false;
                this.LowRiskPlanetSix.Visible = false;
                this.LowRiskPlanetSeven.Visible = false;
                this.LowRiskPlanetEight.Visible = false;
            }
            else if (LowRiskPlanetDie == 2)
            {
                this.LowRiskPlanetOne.Visible = false;
                this.LowRiskPlanetTwo.Visible = true;
                this.LowRiskPlanetThree.Visible = false;
                this.LowRiskPlanetFour.Visible = false;
                this.LowRiskPlanetFive.Visible = false;
                this.LowRiskPlanetSix.Visible = false;
                this.LowRiskPlanetSeven.Visible = false;
                this.LowRiskPlanetEight.Visible = false;
            }
            else if (LowRiskPlanetDie == 3)
            {
                this.LowRiskPlanetOne.Visible = false;
                this.LowRiskPlanetTwo.Visible = false;
                this.LowRiskPlanetThree.Visible = true;
                this.LowRiskPlanetFour.Visible = false;
                this.LowRiskPlanetFive.Visible = false;
                this.LowRiskPlanetSix.Visible = false;
                this.LowRiskPlanetSeven.Visible = false;
                this.LowRiskPlanetEight.Visible = false;
            }
            else if (LowRiskPlanetDie == 4)
            {
                this.LowRiskPlanetOne.Visible = false;
                this.LowRiskPlanetTwo.Visible = false;
                this.LowRiskPlanetThree.Visible = false;
                this.LowRiskPlanetFour.Visible = true;
                this.LowRiskPlanetFive.Visible = false;
                this.LowRiskPlanetSix.Visible = false;
                this.LowRiskPlanetSeven.Visible = false;
                this.LowRiskPlanetEight.Visible = false;
            }
            else if (LowRiskPlanetDie == 5)
            {
                this.LowRiskPlanetOne.Visible = false;
                this.LowRiskPlanetTwo.Visible = false;
                this.LowRiskPlanetThree.Visible = false;
                this.LowRiskPlanetFour.Visible = false;
                this.LowRiskPlanetFive.Visible = true;
                this.LowRiskPlanetSix.Visible = false;
                this.LowRiskPlanetSeven.Visible = false;
                this.LowRiskPlanetEight.Visible = false;
            }
            else if (LowRiskPlanetDie == 6)
            {
                this.LowRiskPlanetOne.Visible = false;
                this.LowRiskPlanetTwo.Visible = false;
                this.LowRiskPlanetThree.Visible = false;
                this.LowRiskPlanetFour.Visible = false;
                this.LowRiskPlanetFive.Visible = false;
                this.LowRiskPlanetSix.Visible = true;
                this.LowRiskPlanetSeven.Visible = false;
                this.LowRiskPlanetEight.Visible = false;
            }
            else if (LowRiskPlanetDie == 7)
            {
                this.LowRiskPlanetOne.Visible = false;
                this.LowRiskPlanetTwo.Visible = false;
                this.LowRiskPlanetThree.Visible = false;
                this.LowRiskPlanetFour.Visible = false;
                this.LowRiskPlanetFive.Visible = false;
                this.LowRiskPlanetSix.Visible = false;
                this.LowRiskPlanetSeven.Visible = true;
                this.LowRiskPlanetEight.Visible = false;
            }
            else if (LowRiskPlanetDie == 8)
            {
                this.LowRiskPlanetOne.Visible = false;
                this.LowRiskPlanetTwo.Visible = false;
                this.LowRiskPlanetThree.Visible = false;
                this.LowRiskPlanetFour.Visible = false;
                this.LowRiskPlanetFive.Visible = false;
                this.LowRiskPlanetSix.Visible = false;
                this.LowRiskPlanetSeven.Visible = false;
                this.LowRiskPlanetEight.Visible = true;
            }

            //determines which high risk planet will display
            if (HighRiskPlanetDie == 1)
            {
                this.HighRiskPlanetOne.Visible = true;
                this.HighRiskPlanetTwo.Visible = false;
                this.HighRiskPlanetThree.Visible = false;
                this.HighRiskPlanetFour.Visible = false;
                this.HighRiskPlanetFive.Visible = false;
                this.HighRiskPlanetSix.Visible = false;
                this.HighRiskPlanetSeven.Visible = false;
                this.HighRiskPlanetEight.Visible = false;
            }
            else if (HighRiskPlanetDie == 2)
            {
                this.HighRiskPlanetOne.Visible = false;
                this.HighRiskPlanetTwo.Visible = true;
                this.HighRiskPlanetThree.Visible = false;
                this.HighRiskPlanetFour.Visible = false;
                this.HighRiskPlanetFive.Visible = false;
                this.HighRiskPlanetSix.Visible = false;
                this.HighRiskPlanetSeven.Visible = false;
                this.HighRiskPlanetEight.Visible = false;
            }
            else if (HighRiskPlanetDie == 3)
            {
                this.HighRiskPlanetOne.Visible = false;
                this.HighRiskPlanetTwo.Visible = false;
                this.HighRiskPlanetThree.Visible = true;
                this.HighRiskPlanetFour.Visible = false;
                this.HighRiskPlanetFive.Visible = false;
                this.HighRiskPlanetSix.Visible = false;
                this.HighRiskPlanetSeven.Visible = false;
                this.HighRiskPlanetEight.Visible = false;
            }
            else if (HighRiskPlanetDie == 4)
            {
                this.HighRiskPlanetOne.Visible = false;
                this.HighRiskPlanetTwo.Visible = false;
                this.HighRiskPlanetThree.Visible = false;
                this.HighRiskPlanetFour.Visible = true;
                this.HighRiskPlanetFive.Visible = false;
                this.HighRiskPlanetSix.Visible = false;
                this.HighRiskPlanetSeven.Visible = false;
                this.HighRiskPlanetEight.Visible = false;
            }
            else if (HighRiskPlanetDie == 5)
            {
                this.HighRiskPlanetOne.Visible = false;
                this.HighRiskPlanetTwo.Visible = false;
                this.HighRiskPlanetThree.Visible = false;
                this.HighRiskPlanetFour.Visible = false;
                this.HighRiskPlanetFive.Visible = true;
                this.HighRiskPlanetSix.Visible = false;
                this.HighRiskPlanetSeven.Visible = false;
                this.HighRiskPlanetEight.Visible = false;
            }
            else if (HighRiskPlanetDie == 6)
            {
                this.HighRiskPlanetOne.Visible = false;
                this.HighRiskPlanetTwo.Visible = false;
                this.HighRiskPlanetThree.Visible = false;
                this.HighRiskPlanetFour.Visible = false;
                this.HighRiskPlanetFive.Visible = false;
                this.HighRiskPlanetSix.Visible = true;
                this.HighRiskPlanetSeven.Visible = false;
                this.HighRiskPlanetEight.Visible = false;
            }
            else if (HighRiskPlanetDie == 7)
            {
                this.HighRiskPlanetOne.Visible = false;
                this.HighRiskPlanetTwo.Visible = false;
                this.HighRiskPlanetThree.Visible = false;
                this.HighRiskPlanetFour.Visible = false;
                this.HighRiskPlanetFive.Visible = false;
                this.HighRiskPlanetSix.Visible = false;
                this.HighRiskPlanetSeven.Visible = true;
                this.HighRiskPlanetEight.Visible = false;
            }
            else if (HighRiskPlanetDie == 8)
            {
                this.HighRiskPlanetOne.Visible = false;
                this.HighRiskPlanetTwo.Visible = false;
                this.HighRiskPlanetThree.Visible = false;
                this.HighRiskPlanetFour.Visible = false;
                this.HighRiskPlanetFive.Visible = false;
                this.HighRiskPlanetSix.Visible = false;
                this.HighRiskPlanetSeven.Visible = false;
                this.HighRiskPlanetEight.Visible = true;
            }
        }
    }
}
