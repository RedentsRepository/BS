using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitsauftrag_01
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Title = "DrawCharacter";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();



            if (args.Length >= 3)
            {
                int hNum = int.Parse(args[0]);
                int wNum = int.Parse(args[1]);
                string letter = args[2];
                Console.SetWindowSize(hNum * 2, wNum * 2);
                Console.CursorTop = hNum / 2;

                for (int i = 0; i < hNum; i++)
                {
                    Console.CursorLeft = wNum / 2;

                    for (int j = 0; j < wNum; j++)
                    {
                        Console.Write(letter);
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! you need 3 or more parameter!!");
            }

            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }
    }
}
