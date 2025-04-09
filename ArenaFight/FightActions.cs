using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ArenaFight
{
    class FightActions
    {


        public void PeformAttackForPLayerOne(Fighter playerOne , Fighter enemy)
        {

            int damage;
            Helpers.PlayerColor();
            Console.WriteLine($"{playerOne.Name} will attack {enemy.Name}");
            Helpers.ClearColor();

            //this.showPlayerOne(playerOne);

            if (playerOne.AttackPower >= enemy.DefencePower)
            {
                damage = playerOne.AttackPower - enemy.DefencePower;
                playerOne.Health -= damage;

                Helpers.AcceptingColor();
                Console.WriteLine($"Sucsseful hit and it will reduce the Enemy's health with {damage} Hp");
                Helpers.ClearColor();

            }
            else if (enemy.DefencePower > playerOne.AttackPower)
            {
                damage = enemy.DefencePower - playerOne.AttackPower;
                playerOne.Health -= damage;

                Helpers.WarningColor();
                Console.WriteLine($"unucsseful hit and it will reduce your health with {damage} Hp");
                Helpers.ClearColor();

            }


            playerOne.DefencePower -= 10;
            playerOne.DefencePower = playerOne.DefencePower < 0 ? 0 : playerOne.DefencePower;
            Console.WriteLine("Your Defence reduced 10 hp");
            Console.ReadKey();

        }

        public void PeformAttackForEnemy(Fighter playerOne , Fighter enemy)
        {
            int damage;

            Helpers.EnemyColor();
            Console.WriteLine($"{enemy.Name} will attack {playerOne.Name}");
            Helpers.ClearColor();


            if (enemy.AttackPower >= playerOne.DefencePower)
            {
                damage = enemy.AttackPower - playerOne.DefencePower;
                playerOne.Health -= damage;

                Helpers.WarningColor();
                Console.WriteLine($"Sucsseful hit for the enemy and it will reduce your health with {damage} Hp");
                Helpers.ClearColor();

            }
            else if (playerOne.DefencePower > enemy.AttackPower)
            {
                damage = playerOne.DefencePower - enemy.AttackPower;
                enemy.Health -= damage;

                Helpers.AcceptingColor();
                Console.WriteLine($"unsucsseful hit and it will reduct the Enemy's health with {damage} Hp");
                Helpers.ClearColor();

            }

            enemy.DefencePower -= 10;
            enemy.DefencePower = enemy.DefencePower < 0 ? 0 : enemy.DefencePower;
            Console.WriteLine("Enemy Defence reduced 10 hp");
            Console.ReadKey();
        }

        public Fighter AssignPlayerToTheFighter(int diceRoll)
        {
            return diceRoll switch
            {
                1 => new PLayerOneTheDestroyer(),
                2 => new PlayerTwoTheDefencer(),
                3 => new PlayerThreeTheBalancer(),
                4 => new PlayerFourKillShot(),
                5 => new PlayerFiveTheLoser(),
                6 => new PlayerSixTheRandomPower(), 
            };
        }
       


    }

}
