using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    class PLayerOneTheDestroyer: Fighter
    {
        public PLayerOneTheDestroyer() : base("The Destroyer")
        {
            this.AttackPower = 60;
            this.DefencePower = 20;
           
        }
    }
    
}
