using System.Drawing;

namespace ArenaFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int diceRoll = random.Next(1, 7);

            var destroyer = new PLayerOneTheDestroyer();
            var defender = new PlayerTwoTheDefencer();
            var balancer = new PlayerThreeTheBalancer();
            var killer = new PlayerFourKillShot();
            var loser = new PlayerFiveTheLoser();
            var randomPlayer = new PlayerSixTheRandomPower();

            int playerOne;
            int playerTwo;
            int input;

            Fighter playerOneChoice = new Fighter(String.Empty);
            Fighter playerTwoChoice = new Fighter(String.Empty);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n");
                Console.WriteLine("***************************************");
                Console.WriteLine("*                                     *");
                Console.WriteLine("*       WELCOME TO THE ARENA FIGHT    *");
                Console.WriteLine("*                                     *");
                Console.WriteLine("***************************************");
                Console.WriteLine("\n\n\n");
                Console.ResetColor();
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Player one");
                Helpers.ClearColor();
                Console.WriteLine("Press any key to get your figher or -1 to exit the game.\n");
                bool isValidInput = int.TryParse(Console.ReadLine(),out input);

                 playerOne = diceRoll;

                Console.ForegroundColor = ConsoleColor.Cyan;
                if (input != -1)
                {
                    switch (diceRoll)
                    {
                        case 1:
                            Console.WriteLine($"Your Player: {destroyer}");
                            playerOneChoice = destroyer;
                            break;
                        case 2:
                            Console.WriteLine($"Your Player: {defender}");
                            playerOneChoice = defender;
                            break;
                        case 3:
                            Console.WriteLine($"Your Player: {balancer}");
                            playerOneChoice = balancer;
                            break;
                        case 4:
                            Console.WriteLine($"Your Player: {killer}");
                            playerOneChoice = killer;
                            break;
                        case 5:
                            Console.WriteLine($"Your Player: {loser}");
                            playerOneChoice = loser;
                            break;
                        case 6:
                            Console.WriteLine($"Your Player: {randomPlayer}");
                            playerOneChoice = randomPlayer;
                            break;

                    }
                    Console.WriteLine();
                    Helpers.ClearColor();


                    //Selecing the player number 2 

                    Helpers.EnemyColor();
                    Console.WriteLine("Your Enemy");
                    Helpers.ClearColor();
                    Console.WriteLine("Press any key to continue\n");
                    Console.ReadKey();

                    int anotherDiceRoll = random.Next(1, 7);
                    playerTwo = anotherDiceRoll;

                    Helpers.EnemyColor();
                    switch (anotherDiceRoll)
                    {
                        case 1:
                            Console.WriteLine($"Your enemy: {destroyer}");
                            playerTwoChoice = destroyer;
                            break;
                        case 2:
                            Console.WriteLine($"Your enemy: {defender}");
                            playerTwoChoice = defender;
                            break;
                        case 3:
                            Console.WriteLine($"Your enemy: {balancer}");
                            playerTwoChoice = balancer;
                            break;
                        case 4:
                            Console.WriteLine($"Your enemy: {killer}");
                            playerTwoChoice = killer;
                            break;
                        case 5:
                            Console.WriteLine($"Your enemy: {loser}");
                            playerTwoChoice = loser;
                            break;
                        case 6:
                            Console.WriteLine($"Your enemy: {randomPlayer}");
                            playerTwoChoice = randomPlayer;
                            break;

                    }
                    Console.WriteLine();
                    Helpers.ClearColor();

                    Console.ReadKey();

                    while (playerOneChoice.Health > 0 && playerTwoChoice.Health > 0)
                    {
                        int RandomSelection = random.Next(1, 3);
                        Console.WriteLine("Random selection of the players to hit.\n");
                        if (RandomSelection == 1)
                        {
                            Helpers.PlayerColor();
                            Console.WriteLine($"Player 1 {playerOneChoice.Name} starts to hit!");
                            Helpers.ClearColor();

                            Console.WriteLine("Each attack reduce your defence power with 10 points");
                            Console.WriteLine("Start.....\n");
                            Console.ReadKey();


                            if (playerOneChoice.AttackPower >= playerTwoChoice.DefencePower)
                            {
                                playerTwoChoice.Health = playerTwoChoice.Health - (playerOneChoice.AttackPower - playerTwoChoice.DefencePower);
                                playerOneChoice.DefencePower = playerOneChoice.DefencePower <= 0 ? 0 : playerOneChoice.DefencePower -= 10;

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(playerOneChoice);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine(playerTwoChoice);
                                Helpers.ClearColor();
                                Console.ReadKey();

                            }else if(RandomSelection == 2)
                            {
                                playerOneChoice.Health = playerOneChoice.Health - (playerTwoChoice.AttackPower - playerOneChoice.DefencePower);
                                playerOneChoice.DefencePower = playerOneChoice.DefencePower <= 0 ? 0 : playerOneChoice.DefencePower -= 10;

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(playerOneChoice);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine(playerTwoChoice);
                                Helpers.ClearColor();
                                Console.ReadKey();
                            }

                        }
                        else
                        {
                            Helpers.EnemyColor();
                            Console.WriteLine($"Your enemy {playerTwoChoice.Name} starts to hit!");
                            Helpers.ClearColor();
                            Console.WriteLine("Each attack reduce your enemy's defence power with 10 points");
                            Console.WriteLine("Start.....\n");
                            Console.ReadKey();


                            if (playerTwoChoice.AttackPower >= playerOneChoice.DefencePower)
                            {
                                playerOneChoice.Health = playerOneChoice.Health - (playerTwoChoice.AttackPower - playerOneChoice.DefencePower);
                                playerTwoChoice.DefencePower = playerTwoChoice.DefencePower <= 0 ? 0 : playerTwoChoice.DefencePower -= 10;

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(playerOneChoice);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine(playerTwoChoice);
                                Helpers.ClearColor();
                                Console.ReadKey();
                            }else
                            {
                                playerTwoChoice.Health = playerTwoChoice.Health - (playerTwoChoice.DefencePower-playerOneChoice.AttackPower );
                                playerTwoChoice.DefencePower = playerTwoChoice.DefencePower <= 0 ? 0 : playerTwoChoice.DefencePower -= 10;

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(playerOneChoice);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine(playerTwoChoice);
                                Helpers.ClearColor();
                                Console.ReadKey();
                            }

                        }

                        
                    }
                    if (playerOneChoice.Health <= 0)
                    {
                        Helpers.WarningColor();
                        Console.WriteLine("You lost, press any key to play again!");
                        Console.ReadKey();
                    }

                    else if (playerTwoChoice.Health <= 0)
                    {
                        Helpers.AcceptingColor();
                        Console.WriteLine("Your enemy has lost!, press any key to continue");
                        Console.ReadKey();

                    }
                    Helpers.ClearColor();
                    Console.WriteLine("Press any key to restart the game -_______-");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    break;
                }

                

            }


        }
    }
}
