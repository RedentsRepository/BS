using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitsauftrag_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Arbeitsauftrag 02 by: JMF";

            int sMenu;

            do
            {
                ConsoleNegativeColor();
                PrintMenu();

                sMenu = LeerControl();

                switch (sMenu)
                {
                    case 1: DrawVLine(); break;
                    case 2: DrawHLine(); break;
                    case 3: DrawRectangle(); break;
                    case 4: DrawGrid(); break;
                    case 5:
                        ConsoleNegativeColor();
                        Console.WriteLine("Good bye!!\nPress any key to exit...");
                        Console.ReadKey(); break;
                    default:
                        Console.WriteLine("\nWrite a number between 1 and 5");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Press any key to try again...");
                        Console.ReadKey(); break;
                }

            } while (sMenu != 5);

           
        }


        #region DrawVLine
        static void DrawVLine()
        {
            Console.Clear();
            Console.WriteLine("Welcome To DrawVLine");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Write Value of Top: ");
            int top = LeerControl();

            Console.Write("Write Value of Left: ");
            int left = LeerControl();

            Console.Write("Write Value of Height: ");
            int height = LeerControl();

            DrawVLine(top, left, height);

            Console.WriteLine();
            Console.WriteLine("Press any Enter to go back on the Menu...");
            Console.ReadLine();
        }

        static void DrawVLine(int top, int left, int height)
        {
            Console.CursorTop = top;

            for (int i = 0; i < height; i++)
            {
                Console.CursorLeft = left;
                Console.WriteLine("X");
            }
        }
        #endregion

        #region DrawHLine
        static void DrawHLine()
        {
            Console.Clear();
            Console.WriteLine("Welcome To DrawHLine");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Write Value of Top: ");
            int top = LeerControl();

            Console.Write("Write Value of Left: ");
            int left = LeerControl();

            Console.Write("Write Value of Width: ");
            int width = LeerControl();

            DrawHLine(top, left, width);

            Console.WriteLine();
            Console.WriteLine("Press any Enter to go back on the Menu...");
            Console.ReadLine();
        }

        static void DrawHLine(int top, int left, int width)
        {
            Console.CursorTop = top;

            Console.CursorLeft = left;

            for (int i = 0; i < width; i++)
            {
                Console.Write("X");
            }
        }

        #endregion

        #region DrawRectangle 
        static void DrawRectangle()
        {
            Console.Clear();
            Console.WriteLine("Welcome To DrawRectangle");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Write Value of Top: ");
            int top = LeerControl();

            Console.Write("Write Value of Left: ");
            int left = LeerControl();

            Console.Write("Write Value of Hight: ");
            int height = LeerControl();

            Console.Write("Write Value of Width: ");
            int width = LeerControl();

            DrawRectangle(top, left, height, width);

            Console.WriteLine();
            Console.WriteLine("Press any Enter to go back on the Menu...");
            Console.ReadLine();
        }

        static void DrawRectangle(int top, int left, int height, int width)
        {
            DrawHLine(top, left, width);
            DrawHLine(top + height - 1, left, width);
            DrawVLine(top, left, height);
            DrawVLine(top, left + width - 1, height);

        }
        #endregion

        #region DrawGrid
        static void DrawGrid()
        {
            Console.Clear();
            Console.WriteLine("Welcome To DrawGrid");
            Console.WriteLine();
            Console.WriteLine();


            Console.Write("Write Value of Top: ");
            int top = LeerControl();

            Console.Write("Write Value of Left: ");
            int left = LeerControl();

            Console.Write("Write Value of CellSize: ");
            int cellSize = LeerControl();

            Console.Write("Write Value of nOfRows: ");
            int nOfRows = LeerControl();

            Console.Write("Write Value of nOfCols: ");
            int nOfCols = LeerControl();

            DrawGrid(top, left, cellSize, nOfRows, nOfCols);

            Console.WriteLine();
            Console.WriteLine("Press any Enter to go back on the Menu...");
            Console.ReadLine();
        }

        static void DrawGrid(int top, int left, int cellSize, int nOfRows, int nOfCols)
        {
            for (int i = 0; i < nOfRows; i++)
            {
                for (int j = 0; j < nOfCols; j++)
                {
                    if (i > 0 || j > 0)
                    {
                        DrawRectangle((top - i) + (cellSize * i), (left - j) + (cellSize * j), cellSize, cellSize);
                    }
                    else
                    {
                        DrawRectangle(top + (cellSize * i), left + (cellSize * j), cellSize, cellSize);
                    }
                }
            }
        }
        #endregion


        static void PrintMenu()
        {
            Console.WriteLine("1. Zeichen einer vertikalen Linie");
            Console.WriteLine("2. Zeichen einer horizontalen Linie");
            Console.WriteLine("3. Zeichen eines Rechtecks");
            Console.WriteLine("4. Zeichen eines Grids");
            Console.WriteLine("5. Programm beenden");
            Console.Write("Write a number: ");
        }

        static void ConsoleNegativeColor()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        static int LeerControl()
        {
            int rNum;
            string sRNum = Console.ReadLine();

            while (!int.TryParse(sRNum, out rNum))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: You need to enter a correct number!!");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Write the correct number: ");
                sRNum = Console.ReadLine();
            }
            return rNum;
        }
    }
}
