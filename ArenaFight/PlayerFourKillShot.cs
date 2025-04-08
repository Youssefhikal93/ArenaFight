using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    class PlayerFourKillShot:Fighter
    {
        public PlayerFourKillShot():base("The Killer")
        {
            this.AttackPower = 200;
            this.DefencePower = 1;
        }
    }
}
