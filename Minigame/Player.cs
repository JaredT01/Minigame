using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigame
{
    class Player
    {
        public int playerX;
        public int playerY;
        public int MinPos = 3;
        public int MaxPos = 50;
        public int MaxPosX = 99;
        public bool FiftyFifty = false;
        public bool TenFive = false;


        public Player()
        {
            playerX = 3;
            playerY = 3;
        }

        public void DrawPlayer()
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write("@");
        }
        public void MovePlayer()
        {
            string input = Console.ReadKey(true).Key.ToString(); ;
            if (input == ConsoleKey.W.ToString())
            {
                if(playerY > MinPos)
                {
                    playerY = playerY - 1;
                    
                }
            } else if (input == ConsoleKey.A.ToString())
            {
                if (playerX > MinPos)
                {
                    playerX = playerX - 1;
                    
                }
            }
            else if (input == ConsoleKey.S.ToString())
            {
                if (playerY < MaxPos)
                {
                    playerY = playerY + 1;
                    
                }
            }
            else if (input == ConsoleKey.D.ToString())
            {
                if (playerX < MaxPosX)
                {
                    playerX = playerX + 1;
                    
                }

            }
        }

        public void DetectEvents()
        {
            if (playerX == 50)
            {
                if (playerY == 50)
                {
                    if (FiftyFifty == false)
                    {
                        Console.WriteLine("You discovered a town here!");
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadKey(true);
                        FiftyFifty = true;
                    }
                }
            } else if (playerX == 10)
            {
                if (playerY == 5)
                {
                    if (TenFive == false)
                    {
                        Console.WriteLine("You discovered a dungeon here!");
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadKey(true);
                        TenFive = true;
                    }
                }
            }
        }


    }
}
