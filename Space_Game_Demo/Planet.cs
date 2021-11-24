using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game_Demo
{
    class Planet
    {
        //fields
        private string _name;   
        private string _type;

        //constructor
        public Planet()
        {
            _name = "";
            _type = "";
        }
        //properties
        public string planetName { get; set; }  //name of planets
        public string planetType { get; set; }  //type pf planet (easy / risky)

        public void ChoosePlanet()
        {
            //create instamce of new Planet_Choices_Form
            Planet_Choices_Form planetChoice = new Planet_Choices_Form();

            //open the Planet_Choices_Form
            planetChoice.ShowDialog();
        }
    }
}
