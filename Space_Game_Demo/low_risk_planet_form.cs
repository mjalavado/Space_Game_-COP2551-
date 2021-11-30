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
    public partial class low_risk_planet_form : Form
    {
        public low_risk_planet_form()
        {
            InitializeComponent();
        }

        Player player = new Player();

        private void btnMine_Click(object sender, EventArgs e)
        {
            //Player Coin object incremented and added to label
            player.Coin++;
            this.tbResourcesMined.Text = player.Coin.ToString();

            //if coin reaches 10 enable purchase button
            if (player.Coin == 10)
            {
                btnPurchase.Enabled = true;
                player.Coin = 0;
            }

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            int total;  //local variable to hold total

            //accrue 1 engine part to Player total
            player.EngineParts++;
            total = player.EngineParts;

            //call the parts total function
            player.PartsTotal(total);

            //Display current total
            MessageBox.Show("hello " + player.Name + " You have acquired 1 engine part and you now have " 
                + player.TotalParts + " total parts of 8 required."
                , "Status Report:");

            //disable the purchase button after engine part acquired
            btnPurchase.Enabled = false;

            //check to see if 8 engine parts have ben accrued
            //if so open up Get Engine button
            if (player.TotalParts == 8)
            {
                //Enable Get Engine Button 
                btnGetEngine.Enabled = true;

            }
            else
            {
                Planet_Choices_Form choice = new Planet_Choices_Form();
                //shift focus to form
                choice.Focus();
                //close this form
                this.Close();
            }

        }

        private void btnGetEngine_Click(object sender, EventArgs e)
        {
            //load Game Won form
            game_won_form winner = new game_won_form();
            winner.ShowDialog();

        }
    }
}

