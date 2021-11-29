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
        private int _total_parts;

        //constructor
        public Player()
        {
            _name = "";
            _coin = 0;
            _engine_parts = 0;
            _total_parts = 0;
        }

        //properties
        public string Name { get; set; }
        public int Coin { get; set; }
        public int EngineParts { get; set; }
        public int TotalParts { get; set; }

        //method to accumulate total engine parts
        public void PartsTotal(int total)
        {
            _total_parts += total;
        }
    }
}
