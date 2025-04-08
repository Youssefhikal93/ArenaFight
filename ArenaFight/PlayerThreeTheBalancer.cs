using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    class PlayerThreeTheBalancer:Fighter
    {
        public PlayerThreeTheBalancer():base("The Balancer")
        {
            this.AttackPower = 60;
            this.DefencePower= 60; 
        }
    }
}
