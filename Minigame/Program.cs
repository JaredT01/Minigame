using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigame
{
    class Program
    {
        static Player player = new Player();
        static void Main(string[] args)
        {
            int Loop = 0;
            while (Loop < 1)
            {
                Console.Clear();
                player.DetectEvents();
                Console.Clear();
                DrawMap();
                player.DrawPlayer();
                player.MovePlayer();

            }
        }
        static void DrawMap()
        {
            for (int x = 0; x < 1;)
            {
                Console.WriteLine("Move: WASD                    Player Position: " + player.playerX + ", " + player.playerY);
                Console.Write("┌");
                for (int y = 0; y < 99; y++)
                {
                    Console.Write("─");
                }
                Console.WriteLine("┐");
                for (int y = 2; y < 51; y++)
                {
                    Console.WriteLine("│");
                    Console.SetCursorPosition(100, y);
                    Console.WriteLine("│");
                }
                Console.Write("└");
                for (int y = 0; y < 99; y++)
                {
                    Console.Write("─");
                }
                Console.WriteLine("┘");
                x = 1;
            }
            if(player.FiftyFifty == true)
            {
                Console.SetCursorPosition(50,50);
                Console.Write("T");
            }
            if (player.TenFive == true)
            {
                Console.SetCursorPosition(10, 5);
                Console.Write("D");
            }
        }
    }
}
