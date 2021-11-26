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

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Planet choices = new Planet();
            choices.ChoosePlanet();

            this.Close();
        }
    }
}
