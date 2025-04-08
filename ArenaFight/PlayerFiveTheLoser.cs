using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    class PlayerFiveTheLoser:Fighter
    {

        public PlayerFiveTheLoser():base("The Loser")
        {
            this.AttackPower = 1;
            this.DefencePower = 1;
        }
    }
}
