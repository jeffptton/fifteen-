using System;
using System.Collections.Generic;
using System.Text;

namespace fifteen
{
    class TombRaider
    {
    
        public string _name { get; set; }
        public string _costume { get; set; }
        public int _power { get; set; }
        public string _ability { get; set; }

        public TombRaider(string name, string costume, int power, string ability)
        {
            _name = name;
            _costume = costume;
            _power = power;
            _ability = ability;
        }
    }
}
