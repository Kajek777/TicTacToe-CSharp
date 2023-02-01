using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Tic Tac Toe");
            Table.DrawTable();
            Input.NextMoveX();
        }
    }

    public class Table
    {
        public static string tl = " ";
        public static string tm = " ";
        public static string tr = " ";
        public static string ml = " ";
        public static string mm = " ";
        public static string mr = " ";
        public static string bl = " ";
        public static string bm = " ";
        public static string br = " ";
        public static void DrawTable()
        {
            Console.WriteLine($"\n    |   |   \n  {tl} | {tm} | {tr} \n ___|___|___\n    |   |   \n  {ml} | {mm} | {mr} \n ___|___|___\n    |   |   \n  {bl} | {bm} | {br} \n    |   |");
        }
        
    }
    public class Input
    {
        public static string UserInput = "";
        public static void NextMoveX()
        {
            Console.WriteLine("Where will you put an X?");
            UserInput = Console.ReadLine();
            if (UserInput == "tl" || UserInput == "tm" || UserInput == "tr" || UserInput == "ml" || UserInput == "mm" || UserInput == "mr" || UserInput == "bl" || UserInput == "bm" || UserInput == "br")
            {
                if (UserInput == "tl")
                {
                    if (Table.tl == " ")
                    {
                        Table.tl = "X";
                    }
                    else SpaceTakenX();

                }
                else if (UserInput == "tm")
                {
                    if (Table.tm == " ")
                    {
                        Table.tm = "X";
                    }
                    else SpaceTakenX();

                }
                else if (UserInput == "tr")
                {
                    if (Table.tr == " ")
                    {
                        Table.tr = "X";
                    }
                    else SpaceTakenX();

                }
                else if (UserInput == "ml")
                {
                    if (Table.ml == " ")
                    {
                        Table.ml = "X";
                    }
                    else SpaceTakenX();

                }
                else if (UserInput == "mm")
                {
                    if (Table.mm == " ")
                    {
                        Table.mm = "X";
                    }
                    else SpaceTakenX();

                }
                else if (UserInput == "mr")
                {
                    if (Table.mr == " ")
                    {
                        Table.mr = "X";
                    }
                    else SpaceTakenX();

                }
                else if (UserInput == "bl")
                {
                    if (Table.bl == " ")
                    {
                        Table.bl = "X";
                    }
                    else SpaceTakenX();

                }
                else if (UserInput == "bm")
                {
                    if (Table.bm == " ")
                    {
                        Table.bm = "X";
                    }
                    else SpaceTakenX();

                }
                else if (UserInput == "br")
                {
                    if (Table.br == " ")
                    {
                        Table.br = "X";
                    }
                    else SpaceTakenX();
                }
                Table.DrawTable();
                Score.CheckForWinX();
            }
            else
            {
                Console.WriteLine("Please input one of the following strings: tl, tm, tr, ml, mm, mr, bl, bm, br");
                Input.NextMoveX();
            }
        }
        public static void NextMove0()
        {
            Console.WriteLine("Where will you put a 0?");
            UserInput = Console.ReadLine();
            if (UserInput == "tl" || UserInput == "tm" || UserInput == "tr" || UserInput == "ml" || UserInput == "mm" || UserInput == "mr" || UserInput == "bl" || UserInput == "bm" || UserInput == "br")
            {
                if (UserInput == "tl")
                {
                    if (Table.tl == " ")
                    {
                        Table.tl = "0";
                    }
                    else SpaceTaken0();

                }
                else if (UserInput == "tm")
                {
                    if (Table.tm == " ")
                    {
                        Table.tm = "0";
                    }
                    else SpaceTaken0();
                }
                else if (UserInput == "tr")
                {
                    if (Table.tr == " ")
                    {
                        Table.tr = "0";
                    }
                    else SpaceTaken0();
                }
                else if (UserInput == "ml")
                {
                    if (Table.ml == " ")
                    {
                        Table.ml = "0";
                    }
                    else SpaceTaken0();
                }
                else if (UserInput == "mm")
                {
                    if (Table.mm == " ")
                    {
                        Table.mm = "0";
                    }
                    else SpaceTaken0();
                }
                else if (UserInput == "mr")
                {
                    if (Table.mr == " ")
                    {
                        Table.mr = "0";
                    }
                    else SpaceTaken0();
                }
                else if (UserInput == "bl")
                {
                    if (Table.bl == " ")
                    {
                        Table.bl = "0";
                    }
                    else SpaceTaken0();
                }
                else if (UserInput == "bm")
                {
                    if (Table.bm == " ")
                    {
                        Table.bm = "0";
                    }
                    else SpaceTaken0();
                }
                else if (UserInput == "br")
                {
                    if (Table.br == " ")
                    {
                        Table.br = "0";
                    }
                    else SpaceTaken0();
                }
                Table.DrawTable();
                Score.CheckForWin0();
            }
            else
            {
                Console.WriteLine("Please input one of the following strings: tl, tm, tr, ml, mm, mr, bl, bm, br");
                Input.NextMove0();
            }

        }
        public static void SpaceTakenX()
        {
            Console.WriteLine("That space is already taken, please input another space");
            Input.NextMoveX();
        }
        public static void SpaceTaken0()
        {
            Console.WriteLine("That space is already taken, please input another space");
            Input.NextMove0();
        }
    }

    public class Score
    {
        public static void CheckForWinX()
        {         // top row                                     // middle row                                 // bottom row                               // left column                                 // middle column                             // right column                              // top left - bottom right diagonal            // top right - bottom left diagonal
            if ($"{Table.tl}{Table.tm}{Table.tr}" == "XXX" || $"{Table.ml}{Table.mm}{Table.mr}" == "XXX" || $"{Table.bl}{Table.bm}{Table.br}" == "XXX" || $"{Table.tl}{Table.ml}{Table.bl}" == "XXX" || $"{Table.tm}{Table.mm}{Table.bm}" == "XXX" || $"{Table.tr}{Table.mr}{Table.br}" == "XXX" || $"{Table.tl}{Table.mm}{Table.br}" == "XXX" || $"{Table.tr}{Table.mm}{Table.bl}" == "XXX")
            {
                Console.WriteLine("\nPlayer X won the game!\n");
            }
            else Input.NextMove0();
        }
        public static void CheckForWin0()
        {         // top row                                     // middle row                                 // bottom row                               // left column                                 // middle column                             // right column                              // top left - bottom right diagonal            // top right - bottom left diagonal
            if ($"{Table.tl}{Table.tm}{Table.tr}" == "000" || $"{Table.ml}{Table.mm}{Table.mr}" == "000" || $"{Table.bl}{Table.bm}{Table.br}" == "000" || $"{Table.tl}{Table.ml}{Table.bl}" == "000" || $"{Table.tm}{Table.mm}{Table.bm}" == "000" || $"{Table.tr}{Table.mr}{Table.br}" == "000" || $"{Table.tl}{Table.mm}{Table.br}" == "000" || $"{Table.tr}{Table.mm}{Table.bl}" == "000")
            {
                Console.WriteLine("\nPlayer 0 won the game!\n");
            }
            else Input.NextMoveX();
        }
    }
}
