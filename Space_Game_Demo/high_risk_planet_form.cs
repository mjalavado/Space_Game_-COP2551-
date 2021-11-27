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
    public partial class high_risk_planet_form : Form
    {
        public high_risk_planet_form()
        {
            InitializeComponent();
        }

        private void btnSalvage_Click(object sender, EventArgs e)
        {
            int parts;

            //instantiate player class
            Player CoinUp = new Player();

            Random dice = new Random();

            parts = dice.Next(1, 4);

            CoinUp.EngineParts += parts;

            MessageBox.Show("Intact Parts Detected: You Have Obtained " +
                CoinUp.EngineParts.ToString() + " Parts", "Results");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
