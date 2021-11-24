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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeginGame_Click(object sender, EventArgs e)
        {
            //instance of Player assigned to textbox
            Player player = new Player();
            player.Name = usernameTextbox.Text;

            //load the planet choice form
            Planet_Choices_Form planetchoice = new Planet_Choices_Form();
            planetchoice.ShowDialog();

            //close current form
            this.Close();
            //doesn't seem to close the form at the moment 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load the prologue form first. 
            prologue_form prologue = new prologue_form();
            prologue.ShowDialog();
        }

        //Dave here! adding a simple note to test the altering of a file 
        // and then creating pull request to merge!

        //Notes
        /*
        1. user must input their name
        2. user must have a minimum amount of money/goods
        3. user must have the minimum requirements to visit a planet (money/equipment to enter planet)
        4. there must be a risk reward system for each planet
        5. there will be scenarios for each planet that gives the player more loot, or lose loot
        6. planets will be rng and the user must choose which planet to go to (3 options max)
        7. the player must build up money and resources to move on to different planets
        8. the further the player goes through multiple planets the more rng events/scenarios will occur on those planet
        9. if the player loses a scenario they will lose a certain amount of money and resources
        10. (optional: not sure if we should include) if they don't have money to get resources, player can return to the previous planet
        11. win condition: player has visited a minimum of 5 planets, and has found a suitable planet for the future
        12. lose condition: player has no money or resources for the ship to go to other planets, or the ship is destroyed/unusable
        13. once the player finds the light engine piece for the ship they beat the game.
        */
    }
}
