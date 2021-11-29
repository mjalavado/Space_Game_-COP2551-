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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        int count = 0;
=======
        
>>>>>>> Stashed changes
=======
        
>>>>>>> Stashed changes
        public low_risk_planet_form()
        {
            InitializeComponent();
        }

<<<<<<< Updated upstream
<<<<<<< Updated upstream
        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            lblResourceMined.Text = count.ToString();

=======
        //create Player object
        Player player = new Player();

        
        private void MineButton(object sender, EventArgs e)
        {
=======
        //create Player object
        Player player = new Player();

        
        private void MineButton(object sender, EventArgs e)
        {
>>>>>>> Stashed changes
            //Player Coin object incremented and added to label
            player.Coin++;
            this.tbResourcesMined.Text = player.Coin.ToString();

            //if coin reaches 10 enable purchase button
            if(player.Coin == 10)
            {
                purchaseButton.Enabled = true;
                player.Coin = 0;
            }
            
        }
        
        private void purchaseButton_Click(object sender, EventArgs e)
        {
            int total;  //local variable to hold total

            //acrew 1 engine part to Player total
            player.EngineParts++;
            total = player.EngineParts;

            //call the parts total function
            player.PartsTotal(total);


            //Display current total
            MessageBox.Show("hello " + player.Name + " You have acquired 1 engine part and you now have "
                + player.TotalParts + " total parts of 8 required.");

            //disable the purchase button after engine part acquired
            purchaseButton.Enabled = false;

            //check to see if 8 engine parts have ben acrewed
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
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        }
    }
}
