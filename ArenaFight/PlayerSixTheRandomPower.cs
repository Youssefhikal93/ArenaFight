using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    class PlayerSixTheRandomPower:Fighter
    {
         Random rnd = new Random();
        public PlayerSixTheRandomPower():base("The Randomly")
        {
            this.AttackPower = rnd.Next(1, 100);
            this.DefencePower = rnd.Next(1, 40);
        }
    }
}
