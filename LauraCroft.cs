using System;
using System.Collections.Generic;
using System.Text;

namespace fifteen
{
    class LauraCroft : TombRaider
    {


        public string _gender { get; set; }

        public LauraCroft(string name, string costume, int power, string ability) : base(name, costume, power, ability)
        {
            _name = name;
            _costume = costume;
            _power = power;
            _ability = ability;
            _gender = _gender;
        }

        public bool Attack(string isAttacking)
        {
            bool BadGuy = true;
            if (isAttacking == "Fighting")
            {
                return false;
            }
            else if (isAttacking == "training")
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}

