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
        int count = 0;
        public low_risk_planet_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            lblResourceMined.Text = count.ToString();

        }
    }
}
