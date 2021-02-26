using System;

namespace projedeneme
{
    class Program
    {

        public static char[,,] board = new char[8, 8, 2];
        public static char[,,] bluePieces = new char[2, 8, 2];
        public static char[,,] redPieces = new char[2, 8, 2];
        static ConsoleKeyInfo cki, cki2, nightKey1, nightKey2, nightKey3;

        static int cursorx = 30, cursory = 11;
        static Boolean condition = true, conditionR = true;
        /* mavi ve kırmızı için ayrı arrayler yap  parçaları arraylere at  */
        static void Main(string[] args)
        {


            printBoardArray();

            Console.SetCursorPosition(cursorx, cursory);
            move();

        }
        public static void move()
        {
            while (true)
            {
                /* hareket için mavi ve kırmızılar için array yap .
                düşman taş varsa onu ye gibi bir şey yapılabilir*/

                cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.RightArrow)
                {


                    if (board[cursory / 2, (cursorx / 5) - 1, 0] == '.')
                    {

                        cursorx += 5;
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.SetCursorPosition(cursorx - 5, cursory);
                        Console.Write('.');
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                    else if (board[cursory / 2, (cursorx / 5) - 1, 0] != '.')
                    {
                        cursorx += 5;
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.SetCursorPosition(cursorx - 5, cursory);
                        if (board[cursory / 2, ((cursorx / 5) - 1) - 1, 1] == 'r')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[cursory / 2, ((cursorx / 5) - 1) - 1, 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[cursory / 2, ((cursorx / 5) - 1) - 1, 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.SetCursorPosition(cursorx, cursory);
                    }

                }
                if (cki.Key == ConsoleKey.LeftArrow)
                {

                    if (board[cursory / 2, (cursorx / 5) - 1, 0] == '.')
                    {

                        cursorx -= 5;
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.SetCursorPosition(cursorx + 5, cursory);
                        Console.Write('.');
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                    else if (board[cursory / 2, (cursorx / 5) - 1, 0] != '.')
                    {
                        cursorx -= 5;
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.SetCursorPosition(cursorx + 5, cursory);
                        if (board[cursory / 2, ((cursorx / 5) - 1) + 1, 1] == 'r')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[cursory / 2, ((cursorx / 5) - 1) + 1, 0]);
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[cursory / 2, ((cursorx / 5) - 1) + 1, 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.SetCursorPosition(cursorx, cursory);
                    }



                    //Console.Write("x");
                }
                if (cki.Key == ConsoleKey.UpArrow)
                {

                    if (board[cursory / 2, (cursorx / 5) - 1, 0] == '.')
                    {

                        cursory -= 2;
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.SetCursorPosition(cursorx, cursory + 2);
                        Console.Write('.');
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                    else if (board[cursory / 2, (cursorx / 5) - 1, 0] != '.')
                    {
                        cursory -= 2;
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.SetCursorPosition(cursorx, cursory + 2);
                        // Console.Write(board[(cursory / 2) + 1, (cursorx / 5) - 1]);
                        if (board[(cursory / 2) + 1, (cursorx / 5) - 1, 1] == 'r')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2) + 1, (cursorx / 5) - 1, 0]);
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2) + 1, (cursorx / 5) - 1, 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.SetCursorPosition(cursorx, cursory);
                    }


                }
                if (cki.Key == ConsoleKey.DownArrow)
                {
                    if (board[cursory / 2, (cursorx / 5) - 1, 0] == '.')
                    {

                        cursory += 2;
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.SetCursorPosition(cursorx, cursory - 2);
                        Console.Write('.');
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                    else if (board[cursory / 2, (cursorx / 5) - 1, 0] != '.')
                    {
                        cursory += 2;
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.SetCursorPosition(cursorx, cursory - 2);
                        //Console.Write(board[(cursory / 2) - 1, (cursorx / 5) - 1]);
                        if (board[(cursory / 2) - 1, (cursorx / 5) - 1, 1] == 'r')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2) - 1, (cursorx / 5) - 1, 0]);
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2) - 1, (cursorx / 5) - 1, 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.SetCursorPosition(cursorx, cursory);
                    }

                }/* cursoru hareket ettircek istediği taşa gelince enter a basacak 
                    o taşı seçmiş olacak sonra onu hareket ettircek*/

                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(cursorx, cursory);

                    if (board[cursory / 2, (cursorx / 5) - 1, 0] == 'P')
                    {
                        movePawn();
                    }
                    if (board[cursory / 2, (cursorx / 5) - 1, 0] == 'R')
                    {
                        moveRook();

                    }
                    if (board[cursory / 2, (cursorx / 5) - 1, 0] == 'N')
                    {
                        // possibleMovesNight();
                        moveNight();
                    }
                    if (board[cursory / 2, (cursorx / 5) - 1, 0] == 'B')
                    {
                        moveBishop();
                    }
                    if (board[cursory / 2, (cursorx / 5) - 1, 0] == 'K')
                    {
                        moveKing();
                    }
                    if (board[cursory / 2, (cursorx / 5) - 1, 0] == 'Q')
                    {
                        moveQueen();
                    }

                }


                if (cki.Key == ConsoleKey.Escape)
                {
                    Console.SetCursorPosition(30, 20);
                    Console.Write("do you want to exit y ? n");
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Y)
                        break;
                    if (cki.Key == ConsoleKey.N)
                    {
                        Console.SetCursorPosition(30, 20);
                        Console.Write("                         ");
                    }

                }



            }
        }
        public static void printBoard()
        {
            Console.WriteLine("    +-----------+-----------+---------+");

            for (int i = 9; i > 1; i--)
            {
                if (i == 9)
                {

                    Console.Write(i - 1 + "   |");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("  R   N   B   Q   K   B   N   R  ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("|");
                }
                else if (i == 2)
                {
                    Console.Write(i - 1 + "   |");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("  R   N   B   Q   K   B   N   R  ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("|");
                }
                else if (i == 8)
                {
                    Console.Write(i - 1 + "   |");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("  P   P   P   P   P   P   P   P  ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("|");
                }
                else if (i == 3)
                {
                    Console.Write(i - 1 + "   |");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("  P   P   P   P   P   P   P   P  ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("|");
                }
                else
                    Console.WriteLine(i - 1 + "   |  .   .   .   .   .   .   .   .  |");
                if (i != 2)
                    Console.WriteLine("    |                                 |");
            }
            Console.WriteLine("    +-----------+-----------+---------+");
            Console.WriteLine("       a   b   c   d   e   f   g   h ");
        }

        public static void printBoardArray()
        {
            bluePieces[0, 0, 0] = 'R';
            bluePieces[0, 1, 0] = 'N';
            bluePieces[0, 2, 0] = 'B';
            bluePieces[0, 3, 0] = 'Q';
            bluePieces[0, 4, 0] = 'K';
            bluePieces[0, 5, 0] = 'B';
            bluePieces[0, 6, 0] = 'N';
            bluePieces[0, 7, 0] = 'R';

            for (int i = 0; i < 8; i++)
            {
                bluePieces[1, i, 0] = 'P';

                bluePieces[0, i, 1] = 'b';
                bluePieces[1, i, 1] = 'b';
            }


            redPieces[0, 0, 0] = 'R';
            redPieces[0, 1, 0] = 'N';
            redPieces[0, 2, 0] = 'B';
            redPieces[0, 3, 0] = 'Q';
            redPieces[0, 4, 0] = 'K';
            redPieces[0, 5, 0] = 'B';
            redPieces[0, 6, 0] = 'N';
            redPieces[0, 7, 0] = 'R';

            for (int i = 0; i < 8; i++)
            {
                redPieces[1, i, 0] = 'P';

                redPieces[0, i, 1] = 'r';
                redPieces[1, i, 1] = 'r';
            }

            board[0, 0, 0] = 'R';
            board[0, 1, 0] = 'N';
            board[0, 2, 0] = 'B';
            board[0, 3, 0] = 'Q';
            board[0, 4, 0] = 'K';
            board[0, 5, 0] = 'B';
            board[0, 6, 0] = 'N';
            board[0, 7, 0] = 'R';

            for (int i = 0; i < 8; i++)
            {
                board[1, i, 0] = 'P';
                board[1, i, 1] = 'r';
                board[0, i, 1] = 'r';
            }

            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j, 0] = '.';
                    board[i, j, 1] = 'w';
                }
            }

            for (int i = 0; i < 8; i++)
            {
                board[6, i, 0] = 'P';
                board[6, i, 1] = 'b';
                board[7, i, 1] = 'b';
            }

            board[7, 0, 0] = 'R';
            board[7, 1, 0] = 'N';
            board[7, 2, 0] = 'B';
            board[7, 3, 0] = 'Q';
            board[7, 4, 0] = 'K';
            board[7, 5, 0] = 'B';
            board[7, 6, 0] = 'N';
            board[7, 7, 0] = 'R';

            int rowNum = 8;
            Console.WriteLine("    +-----------+-----------+------------+");

            for (int i = 0; i < 8; i++)
            {
                Console.Write(rowNum + "   |");
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0 || i == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (j != 7)
                            Console.Write(board[i, j, 0] + "    ");
                        else
                            Console.Write(board[i, j, 0] + "|");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (i == 6 || i == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        if (j != 7)
                            Console.Write(board[i, j, 0] + "    ");
                        else
                            Console.Write(board[i, j, 0] + "|");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        if (j != 7)
                            Console.Write(board[i, j, 0] + "    ");
                        else
                            Console.Write(board[i, j, 0] + "|");
                    }
                }
                // Console.Write("|");
                if (i != 7)
                    Console.WriteLine("\n");
                else
                    Console.WriteLine();

                rowNum--;
            }
            Console.WriteLine("    +-----------+-----------+------------+");
            Console.WriteLine("     a    b    c    d    e    f    g    h");

        }

        public static void movePawn()
        {
            while (condition)
            {
                cki = Console.ReadKey();
                cki2 = Console.ReadKey();

                if (cki.Key == ConsoleKey.RightArrow && cki2.Key == ConsoleKey.RightArrow)
                {
                    Console.SetCursorPosition(cursorx, cursory);
                    Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                    Console.SetCursorPosition(cursorx, cursory);
                }
                if (cki.Key == ConsoleKey.LeftArrow && cki2.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(cursorx, cursory);
                    Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                    Console.SetCursorPosition(cursorx, cursory);
                }
                if (cki.Key == ConsoleKey.DownArrow && cki2.Key == ConsoleKey.DownArrow)
                {
                    //cursory = 3
                    if (cursory != 3)
                    {
                        if (board[(cursory / 2) + 1, ((cursorx / 5) - 1), 0] == '.')
                        { // aşağısında nokta varsa
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'P';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else if (board[(cursory / 2) + 1, ((cursorx / 5) - 1), 0] != '.') // nokta değil ama çaprazında düşman varsa hareket et çapraza
                        {
                            // sol alt çaprazı
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                    }
                    if (board[(cursory / 2) + 1, ((cursorx / 5) - 1), 0] == '.')
                    { // aşağısında nokta varsa
                        cursory += 2;
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.SetCursorPosition(cursorx, cursory - 2);
                        Console.Write('.');
                        Console.SetCursorPosition(cursorx, cursory);
                        cursory -= 2;
                        board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                        board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                        cursory += 2;
                        board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'P';
                        board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(cursorx, cursory);

                    }
                    else if (board[(cursory / 2) + 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }
                if (cki.Key == ConsoleKey.UpArrow && cki2.Key == ConsoleKey.UpArrow)
                {
                    if (cursory != 13)
                    {

                        if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] == '.')
                        { // yukarısında nokta varsa
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'P';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);

                            break;


                        }
                        else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] != '.')
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                    }
                    if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] == '.')
                    { // yukarısında nokta varsa
                        cursory -= 2;
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.SetCursorPosition(cursorx, cursory + 2);
                        Console.Write('.');
                        Console.SetCursorPosition(cursorx, cursory);
                        cursory += 2;
                        board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                        board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                        cursory -= 2;
                        Console.SetCursorPosition(cursorx, cursory);
                        board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'P';
                        board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(cursorx, cursory);



                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }

                }
                if (cki.Key == ConsoleKey.UpArrow && cki2.Key == ConsoleKey.LeftArrow)
                { // sol çapraza hareket. sol çapraz noktaysa ilerle --- 1 üst 1 sol ---.
                    if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'P';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'P';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }


                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 1, 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                        break;
                    }

                }
                if (cki.Key == ConsoleKey.UpArrow && cki2.Key == ConsoleKey.RightArrow)
                { // sağ çapraz. 1 sağ 1 üst
                    if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) + 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) - 1, ((cursorx / 5) - 1) + 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'P';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'P';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }


                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) + 1, 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }

                if (cki.Key == ConsoleKey.DownArrow && cki2.Key == ConsoleKey.LeftArrow)
                { // sol alt çapraz 1 alt 1 sol
                    if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) - 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) + 1, ((cursorx / 5) - 1) - 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'P';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'P';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }


                    }
                    else if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) - 1, 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }

                if (cki.Key == ConsoleKey.DownArrow && cki2.Key == ConsoleKey.RightArrow)
                { // sağ alt çapraz 1 alt 1 sağ
                    if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) + 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) + 1, ((cursorx / 5) - 1) + 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'P';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'P';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }


                    }
                    else if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) + 1, 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }


                if (cki.Key == ConsoleKey.Spacebar)
                {
                    Console.SetCursorPosition(cursorx, cursory);
                    break;
                }


            }
        }
        public static void moveRook()
        {
            while (conditionR)
            {
                cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.RightArrow)
                {
                    if (board[(cursory / 2), ((cursorx / 5) - 1) + 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2), ((cursorx / 5) - 1) + 1, 1]))
                    { // burası modifiye edilecek daha sonra düşman taşa göre
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {

                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx - 5, cursory);
                            Console.Write('.');
                            cursorx -= 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursorx += 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'R';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;


                        }
                        else
                        {
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx - 5, cursory);
                            Console.Write('.');
                            cursorx -= 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursorx += 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'R';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            //Console.SetCursorPosition(cursorx, cursory);
                        }
                        Console.SetCursorPosition(cursorx, cursory);


                    }
                    else
                    {

                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }
                if (cki.Key == ConsoleKey.LeftArrow)
                {

                    if (board[(cursory / 2), ((cursorx / 5) - 1) - 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2), ((cursorx / 5) - 1) - 1, 1]))
                    {
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write('.');
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursorx -= 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'R';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write('.');
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursorx -= 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'R';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }

                if (cki.Key == ConsoleKey.DownArrow)
                {
                    if (board[(cursory / 2) + 1, ((cursorx / 5) - 1), 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) + 1, ((cursorx / 5) - 1), 1]))
                    { // aşağısında nokta varsa

                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'R';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'R';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            //Console.SetCursorPosition(cursorx, cursory);
                        }
                        Console.SetCursorPosition(cursorx, cursory);


                    }
                    else if (board[(cursory / 2) + 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }
                if (cki.Key == ConsoleKey.UpArrow)
                {
                    if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) - 1, ((cursorx / 5) - 1), 1]))
                    { // yukarısında nokta varsa

                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'R';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'R';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            //Console.SetCursorPosition(cursorx, cursory);
                        }
                        Console.SetCursorPosition(cursorx, cursory);




                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }

                }
                if (cki.Key == ConsoleKey.Spacebar)
                {
                    Console.SetCursorPosition(cursorx, cursory);
                    break;
                }

            }
        }

        public static void moveNight()
        {
            while (conditionR)
            {

                nightKey1 = Console.ReadKey();
                nightKey2 = Console.ReadKey();
                nightKey3 = Console.ReadKey();

                if (nightKey1.Key == ConsoleKey.UpArrow && nightKey2.Key == ConsoleKey.UpArrow && nightKey3.Key == ConsoleKey.LeftArrow)
                { // 2 üst 1 sol hareketi
                    if (board[(cursory / 2) - 2, ((cursorx / 5) - 1) - 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) - 2, ((cursorx / 5) - 1) - 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory -= 4;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 4);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 4;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 4;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else
                        {
                            cursory -= 4;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 4);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 4;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 4;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }


                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                        break;
                    }

                }
                if (nightKey1.Key == ConsoleKey.UpArrow && nightKey2.Key == ConsoleKey.UpArrow && nightKey3.Key == ConsoleKey.RightArrow)
                { // 2 üst 1 sağ
                    if (board[(cursory / 2) - 2, ((cursorx / 5) - 1) + 1, 0] == '.' || ((board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) - 2, ((cursorx / 5) - 1) + 1, 1])))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory -= 4;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 4);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 4;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 4;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else
                        {
                            cursory -= 4;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 4);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 4;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 4;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }


                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                        break;
                    }
                }
                if (nightKey1.Key == ConsoleKey.LeftArrow && nightKey2.Key == ConsoleKey.LeftArrow && nightKey3.Key == ConsoleKey.UpArrow)
                { // 1 üst 2 sol
                    if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 2, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 2, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx -= 10;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx -= 10;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }


                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                        break;
                    }
                }
                if (nightKey1.Key == ConsoleKey.RightArrow && nightKey2.Key == ConsoleKey.RightArrow && nightKey3.Key == ConsoleKey.UpArrow)
                { // 1 üst 2 sağ
                    if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) + 2, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) - 1, ((cursorx / 5) - 1) + 2, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx += 10;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx += 10;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }


                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                        break;
                    }
                }
                if (nightKey1.Key == ConsoleKey.DownArrow && nightKey2.Key == ConsoleKey.DownArrow && nightKey3.Key == ConsoleKey.LeftArrow)
                {// 2 aşağı 1 sol
                    if (board[(cursory / 2) + 2, ((cursorx / 5) - 1) - 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) + 2, ((cursorx / 5) - 1) - 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory += 4;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 4);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 4;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 4;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else
                        {
                            cursory += 4;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 4);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 4;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 4;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }


                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                        break;
                    }
                }
                if (nightKey1.Key == ConsoleKey.DownArrow && nightKey2.Key == ConsoleKey.DownArrow && nightKey3.Key == ConsoleKey.RightArrow)
                { // 2 aşağı bir sağ
                    if (board[(cursory / 2) + 2, ((cursorx / 5) - 1) + 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) + 2, ((cursorx / 5) - 1) + 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory += 4;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 4);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 4;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 4;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else
                        {
                            cursory += 4;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 4);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 4;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 4;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }


                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                        break;
                    }
                }
                if (nightKey1.Key == ConsoleKey.LeftArrow && nightKey2.Key == ConsoleKey.LeftArrow && nightKey3.Key == ConsoleKey.DownArrow)
                { // 1 aşağı 2 sol
                    if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 2, 0] == '.' || ((board[(cursory / 2), ((cursorx / 5) - 1), 1]) != (board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 2, 1])))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {

                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx -= 10;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx -= 10;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }

                    }
                    else
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                        break;
                    }
                }
                if (nightKey1.Key == ConsoleKey.RightArrow && nightKey2.Key == ConsoleKey.RightArrow && nightKey3.Key == ConsoleKey.DownArrow)
                {// 1aşağı 2 sağ
                    if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) + 2, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) + 1, ((cursorx / 5) - 1) + 2, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx += 10;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx += 10;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'N';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }


                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                        break;
                    }
                }
                if (nightKey1.Key == ConsoleKey.Spacebar && nightKey2.Key == ConsoleKey.Spacebar && nightKey3.Key == ConsoleKey.Spacebar)
                {
                    Console.SetCursorPosition(cursorx, cursory);
                    break;
                }
                //cki = Console.ReadKey();
                if (nightKey1.Key == ConsoleKey.Spacebar)
                {
                    Console.SetCursorPosition(cursorx, cursory);
                    break;
                }

            }
        }
        /*
                    public static void possibleMovesNight() // 35 15
                    {   // cursory = 15 , 1 ve cursorx = 40 , 5

                        // 2 üst bi sol 
                        // cursor arttırmak yerine hesaptan sonra +1 -1 diyerek array indexini arttır ve eğer 
                        if (((cursory / 2) - 2 <= 7 && (cursory / 2) - 2 >= 0) && (((cursorx / 5) - 1) - 1 <= 7 && ((cursorx / 5) - 1) - 1 >= 0))
                            if (board[(cursory / 2) - 2, ((cursorx / 5) - 1) - 1] == '.')
                            {
                                Console.SetCursorPosition(cursorx - 5, cursory - 4);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Write(".");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        // 2 üst bi sağ 
                        ////////////////
                        if (((cursory / 2) - 2 <= 7 && (cursory / 2) - 2 >= 0) && (((cursorx / 5) - 1) + 1 <= 7 && ((cursorx / 5) - 1) + 1 >= 0))
                            if (board[(cursory / 2) - 2, ((cursorx / 5) - 1) + 1] == '.')
                            {
                                Console.SetCursorPosition(cursorx + 5, cursory - 4);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Write(".");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        ////////////////
                        // 1 üst 2 sol
                        if (((cursory / 2) - 1 <= 7 && (cursory / 2) - 1 >= 0) && (((cursorx / 5) - 1) - 2 <= 7 && ((cursorx / 5) - 1) - 2 >= 0))
                            if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 2] == '.')
                            {
                                Console.SetCursorPosition(cursorx - 10, cursory - 2);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Write(".");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        ////////////////
                        // 1 üst 2 sağ
                        if (((cursory / 2) - 1 <= 7 && (cursory / 2) - 1 >= 0) && (((cursorx / 5) - 1) + 2 <= 7 && ((cursorx / 5) - 1) + 2 >= 0))
                            if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) + 2] == '.')
                            {
                                Console.SetCursorPosition(cursorx - 10, cursory - 2);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Write(".");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        ////////////////
                        // 2 aşağı 1 sol
                        if (((cursory / 2) + 2 <= 7 && (cursory / 2) + 2 >= 0) && (((cursorx / 5) - 1) - 1 <= 7 && ((cursorx / 5) - 1) - 1 >= 0))

                            if (board[(cursory / 2) + 2, ((cursorx / 5) - 1) - 1] == '.')
                            {
                                Console.SetCursorPosition(cursorx - 5, cursory + 4);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Write(".");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        ////////////////
                        // 2 aşağı 1 sağ
                        if (((cursory / 2) + 2 <= 7 && (cursory / 2) + 2 >= 0) && (((cursorx / 5) - 1) + 1 <= 7 && ((cursorx / 5) - 1) + 1 >= 0))

                            if (board[(cursory / 2) + 2, ((cursorx / 5) - 1) + 1] == '.')
                            {
                                Console.SetCursorPosition(cursorx + 5, cursory + 4);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Write(".");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        ////////////////
                        //  1 aşağı 2 sol
                        if (((cursory / 2) + 1 <= 7 && (cursory / 2) + 1 >= 0) && (((cursorx / 5) - 1) - 2 <= 7 && ((cursorx / 5) - 1) - 2 >= 0))

                            if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) - 2] == '.')
                            {
                                Console.SetCursorPosition(cursorx - 10, cursory + 2);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Write(".");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        ////////////////
                        // 1 aşağı 2 sağ
                        if (((cursory / 2) + 1 <= 7 && (cursory / 2) + 1 >= 0) && (((cursorx / 5) - 1) + 2 <= 7 && ((cursorx / 5) - 1) + 2 >= 0))

                            if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) + 2] == '.')
                            {
                                Console.SetCursorPosition(cursorx + 10, cursory + 2);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.Write(".");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        Console.SetCursorPosition(cursorx, cursory);
                    }
 */

        public static void moveBishop()
        {
            while (conditionR)
            {

                nightKey1 = Console.ReadKey();
                nightKey2 = Console.ReadKey();
                // nightKey3 = Console.ReadKey();

                if (nightKey1.Key == ConsoleKey.UpArrow && nightKey2.Key == ConsoleKey.LeftArrow)
                { // sol çapraza hareket. sol çapraz noktaysa ilerle --- 1 üst 1 sol ---.
                    if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'B';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'B';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }


                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 1, 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }

                }

                if (nightKey1.Key == ConsoleKey.UpArrow && nightKey2.Key == ConsoleKey.RightArrow)
                { // sağ çapraz. 1 sağ 1 üst
                    if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) + 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) - 1, ((cursorx / 5) - 1) + 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'B';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'B';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }


                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) + 1, 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }

                if (nightKey1.Key == ConsoleKey.DownArrow && nightKey2.Key == ConsoleKey.LeftArrow)
                { // sol alt çapraz 1 alt 1 sol
                    if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) - 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) + 1, ((cursorx / 5) - 1) - 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'B';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'B';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }


                    }
                    else if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) - 1, 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }

                if (nightKey1.Key == ConsoleKey.DownArrow && nightKey2.Key == ConsoleKey.RightArrow)
                { // sağ alt çapraz 1 alt 1 sağ
                    if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) + 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) + 1, ((cursorx / 5) - 1) + 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'B';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'B';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }


                    }
                    else if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) + 1, 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }


                //  cki = Console.ReadKey();
                if (nightKey1.Key == ConsoleKey.Spacebar)
                {
                    Console.SetCursorPosition(cursorx, cursory);
                    break;
                }

            }
        }


        public static void moveKing()
        {
            while (condition)
            {
                cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.RightArrow)
                {
                    if (board[(cursory / 2), ((cursorx / 5) - 1) + 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2), ((cursorx / 5) - 1) + 1, 1]))
                    {
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx - 5, cursory);
                            Console.Write('.');
                            cursorx -= 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursorx += 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'K';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else
                        {
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx - 5, cursory);
                            Console.Write('.');
                            cursorx -= 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursorx += 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'K';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }

                    }
                    else
                    {
                        // şu anlık taş yeme yapmıyor
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                        break;
                    }
                }
                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    if (board[(cursory / 2), ((cursorx / 5) - 1) - 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2), ((cursorx / 5) - 1) - 1, 1]))
                    {
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write('.');
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursorx -= 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'K';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write('.');
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursorx -= 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'K';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }

                        //Console.Write(cursorx + " " + cursory);
                    }
                    else
                    {
                        // şu anlık taş yeme yapmıyor
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                        break;
                    }
                }
                if (cki.Key == ConsoleKey.DownArrow)
                {
                    if (board[(cursory / 2) + 1, ((cursorx / 5) - 1), 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) + 1, ((cursorx / 5) - 1), 1]))
                    { // aşağısında nokta varsai
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'K';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'K';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }


                    }
                    else if (board[(cursory / 2) + 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                        break;
                    }
                }
                if (cki.Key == ConsoleKey.UpArrow)
                {
                    if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) - 1, ((cursorx / 5) - 1), 1]))
                    { // yukarısında nokta varsa
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'K';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }
                        else
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'K';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                            break;
                        }



                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                        break;
                    }

                }
                if (cki.Key == ConsoleKey.Spacebar)
                {
                    Console.SetCursorPosition(cursorx, cursory);
                    break;
                }


            }
        }


        public static void moveQueen()
        {
            // fil ve kale karışımı
            while (conditionR)
            {
                cki = Console.ReadKey();
                cki2 = Console.ReadKey();

                if (cki.Key == ConsoleKey.RightArrow && cki2.Key == ConsoleKey.RightArrow)
                {
                    if (board[(cursory / 2), ((cursorx / 5) - 1) + 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2), ((cursorx / 5) - 1) + 1, 1]))
                    { // burası modifiye edilecek daha sonra düşman taşa göre
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx - 5, cursory);
                            Console.Write('.');
                            cursorx -= 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursorx += 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx - 5, cursory);
                            Console.Write('.');
                            cursorx -= 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursorx += 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }

                    }
                    else
                    {
                        // şu anlık taş yeme yapmıyor
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }
                if (cki.Key == ConsoleKey.LeftArrow && cki2.Key == ConsoleKey.LeftArrow)
                {
                    if (board[(cursory / 2), ((cursorx / 5) - 1) - 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2), ((cursorx / 5) - 1) - 1, 1]))
                    {
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write('.');
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursorx -= 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.Write('.');
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursorx -= 5;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        //Console.Write(cursorx + " " + cursory);
                    }
                    else
                    {
                        // şu anlık taş yeme yapmıyor
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }

                if (cki.Key == ConsoleKey.DownArrow && cki2.Key == ConsoleKey.DownArrow)
                {
                    if (board[(cursory / 2) + 1, ((cursorx / 5) - 1), 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) + 1, ((cursorx / 5) - 1), 1]))
                    { // aşağısında nokta varsa
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {

                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }

                    }
                    else if (board[(cursory / 2) + 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }
                if (cki.Key == ConsoleKey.UpArrow && cki2.Key == ConsoleKey.UpArrow)
                {
                    if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) - 1, ((cursorx / 5) - 1), 1]))
                    { // yukarısında nokta varsa
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1), 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }

                }
                if (cki.Key == ConsoleKey.UpArrow && cki2.Key == ConsoleKey.LeftArrow)
                {
                    if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }


                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) - 1, 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }
                if (cki.Key == ConsoleKey.UpArrow && cki2.Key == ConsoleKey.RightArrow)
                { // sağ çapraz. 1 sağ 1 üst
                    if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) + 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) - 1, ((cursorx / 5) - 1) + 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursory -= 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory + 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory += 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory -= 2;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }


                    }
                    else if (board[(cursory / 2) - 1, ((cursorx / 5) - 1) + 1, 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }
                if (cki.Key == ConsoleKey.DownArrow && cki2.Key == ConsoleKey.LeftArrow)
                { // sol alt çapraz 1 alt 1 sol
                    if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) - 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) + 1, ((cursorx / 5) - 1) - 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx -= 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }


                    }
                    else if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) - 1, 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }
                if (cki.Key == ConsoleKey.DownArrow && cki2.Key == ConsoleKey.RightArrow)
                { // sağ alt çapraz 1 alt 1 sağ
                    if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) + 1, 0] == '.' || (board[(cursory / 2), ((cursorx / 5) - 1), 1] != board[(cursory / 2) + 1, ((cursorx / 5) - 1) + 1, 1]))
                    { // 
                        if (board[(cursory / 2), ((cursorx / 5) - 1), 1] == 'r')
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'r';
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }
                        else
                        {
                            cursory += 2;
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.SetCursorPosition(cursorx, cursory - 2);
                            Console.Write('.');
                            Console.SetCursorPosition(cursorx, cursory);
                            cursory -= 2;
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = '.';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'w';
                            cursory += 2;
                            cursorx += 5;
                            Console.SetCursorPosition(cursorx, cursory);
                            board[(cursory / 2), ((cursorx / 5) - 1), 0] = 'Q';
                            board[(cursory / 2), ((cursorx / 5) - 1), 1] = 'b';
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(cursorx, cursory);
                        }


                    }
                    else if (board[(cursory / 2) + 1, ((cursorx / 5) - 1) + 1, 0] != '.')
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.Write(board[(cursory / 2), ((cursorx / 5) - 1), 0]);
                        Console.SetCursorPosition(cursorx, cursory);
                    }
                }
                if (cki.Key == ConsoleKey.Spacebar)
                {
                    Console.SetCursorPosition(cursorx, cursory);
                    break;
                }

            }
        }
    }
}
