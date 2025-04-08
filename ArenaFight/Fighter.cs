using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    class Fighter
    {
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int DefencePower { get; set; }
        public string Name { get; set; } 

        public Fighter(string? name)
        {
            this.Name = name;
            this.Health = 100;
            
        }

        public override string ToString()
        {
            return $"{this.Name}\nHealth: {this.Health}\nAttack Power: {this.AttackPower}\nDefence Power: {this.DefencePower}";
        }
    }
}
