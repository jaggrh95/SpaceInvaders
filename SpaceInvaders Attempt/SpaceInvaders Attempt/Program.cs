using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace SpaceInvaders_Attempt
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int locatie;
            int start = Console.WindowWidth / 2;
            locatie = start;
            int laserX = 0;
            int laserY = 24;
            int lasercounter = 0;
            int lasergeschoten = 0;
            int[,] aliens =
            {
               
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
            };



            while (true)
            {
                Console.Clear();

                Console.SetCursorPosition(locatie, 25);
                Console.Write('^');
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        locatie = locatie - 1;
                        if (locatie < 0)
                        {
                            locatie = 0;
                        }

                    }
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        locatie = locatie + 1;
                        if (locatie > 119)
                        {
                            locatie = 119;
                        }

                    }
                    if (keyInfo.Key == ConsoleKey.Spacebar)
                    {
                        if (lasergeschoten == 1)
                        {

                        }
                        else
                        {
                            lasergeschoten = 1;
                            lasercounter = 0;
                        }
                    }
                    
                }
                if (lasergeschoten == 1)
                {
                    if(lasercounter ==0)
                    {
                        laserX = locatie;
                    }
                    
                    Console.SetCursorPosition(laserX, laserY - lasercounter);
                    Console.Write('|');
                    lasercounter++;
                    if (lasercounter == 24)
                    {
                        lasergeschoten = 0;
                    }


                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 119; j++)
                    {
                        Console.SetCursorPosition(j, i*2);
                        if (aliens[i, j] == 0)
                        {
                            Console.Write(" ");
                        }
                        if (aliens[i, j] == 1)
                        {
                            Console.Write("O");
                        }
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                }
                
                System.Threading.Thread.Sleep(20);
            }
        }
    }
}
