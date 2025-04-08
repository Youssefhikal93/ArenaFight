using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    class PlayerTwoTheDefencer : Fighter
    {
        public PlayerTwoTheDefencer() : base("The Defender")
        {
            this.DefencePower = 80;
            this.AttackPower = 20;
        }
    }
}
