using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFight
{
    static class Helpers
    {
        public static void ClearColor()
        {
            Console.ResetColor();
        }

        public static void WarningColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void AcceptingColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void EnemyColor()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

        public static void PlayerColor()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
