using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game_Demo
{
    class Player
    {
        //fields
        private string _name;
        private int _coin;
        private int _engine_parts;

        //constructor
        public Player()
        {
            _name = "";
            _coin = 0;
            _engine_parts = 0;
        }

        //properties
        public string Name { get; set; }
        public int Coin { get; set; }
        public int EngineParts { get; set; }
    }
}
