using System.Drawing;
using System.Xml;

namespace ArenaFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            

            //var destroyer = new PLayerOneTheDestroyer();
            //var defender = new PlayerTwoTheDefencer();
            //var balancer = new PlayerThreeTheBalancer();
            //var killer = new PlayerFourKillShot();
            //var loser = new PlayerFiveTheLoser();
            //var randomPlayer = new PlayerSixTheRandomPower();
            var fightActions = new FightActions();

           
            int input;

            Fighter playerOneChoice = new Fighter("");
            Fighter playerTwoChoice = new Fighter("");

            while (true)
            {
                var destroyer = new PLayerOneTheDestroyer();
                var defender = new PlayerTwoTheDefencer();
                var balancer = new PlayerThreeTheBalancer();
                var killer = new PlayerFourKillShot();
                var loser = new PlayerFiveTheLoser();
                var randomPlayer = new PlayerSixTheRandomPower();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("***************************************");
                Console.WriteLine("*       WELCOME TO THE ARENA FIGHT    *");
                Console.WriteLine("***************************************");
                Console.WriteLine("");
                Console.ResetColor();
                
               
                Console.WriteLine("Press any key to get your figher or -1 to exit the game.\n");
                bool isValidInput = int.TryParse(Console.ReadLine(),out input);

                if (input == -1)
                    break;
                

                    Helpers.PlayerColor();
                    Console.WriteLine("Your Player");
                    playerOneChoice = fightActions.AssignPlayerToTheFighter(diceRoll);
                    Console.WriteLine(playerOneChoice);
                    Console.WriteLine();
                    Helpers.ClearColor();

                    //Selecing the player number 2 
                    int anotherDiceRoll = random.Next(1, 7);
                    Helpers.EnemyColor();
                    Console.WriteLine("Your Enemy");
                    playerTwoChoice = fightActions.AssignPlayerToTheFighter(anotherDiceRoll);
                    Console.WriteLine(playerTwoChoice);
                    Helpers.ClearColor();

                    Console.WriteLine("Press any key to start the fight.\n");
                    Console.ReadKey();

                    //Starting the fight
                    while (playerOneChoice.Health > 0 && playerTwoChoice.Health > 0)
                    {
                        int RandomSelection = random.Next(1, 3);
                        Console.WriteLine("Random selection of the players to hit.");

                        if (RandomSelection ==1)
                        {
                            fightActions.PeformAttackForPLayerOne(playerOneChoice,playerTwoChoice);
                        } 
                        else
                        {
                            fightActions.PeformAttackForEnemy(playerOneChoice, playerTwoChoice);

                        }

                        

                    Console.WriteLine("");
                    Console.WriteLine("****************************************");
                    Console.WriteLine("*       Stats After the Attack         *");
                    Console.WriteLine("****************************************\n");

                    Console.WriteLine($"Your Health: {playerOneChoice.Health}  |  Health for the Enemy: {playerTwoChoice.Health}");
                    Console.ResetColor();

                    Console.WriteLine(""); 

                    Console.WriteLine("****************************************");
                    Console.WriteLine("*      Attack and Defense Powers       *");
                    Console.WriteLine("****************************************\n");
                    Console.WriteLine($"Your Attack Power: {playerOneChoice.AttackPower}   |  Your  Defense Power: {playerOneChoice.DefencePower}");
                    Console.WriteLine($"Enemy Attack Power: {playerTwoChoice.AttackPower}  |  Enemy Defense Power: {playerTwoChoice.DefencePower}\n");
                    Console.WriteLine("****************************************");



                    Helpers.ClearColor();

                }

                    //Deciding the winner
                    if (playerOneChoice.Health <= 0)
                    {
                        Helpers.WarningColor();
                        Console.WriteLine("You lost!");
                        Console.ReadKey();
                    }

                    else if (playerTwoChoice.Health <= 0)
                    {
                        Helpers.AcceptingColor();
                        Console.WriteLine("You won, congrats!");
                        Console.ReadKey();

                    }

                    //restarting the game
                    Helpers.ClearColor();
                    Console.WriteLine("Press any key to restart the game ~_~");
                    Console.ReadKey();
                    Console.Clear();


                    
                }
               

                

            }


        }
    }

