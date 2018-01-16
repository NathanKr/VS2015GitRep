using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace small_project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strPlayer1Name, strPlayer2Name,strGameFinishResult="";
            int nZeroBaseRow, nZeroBaseCol;
            bool player1IsPlaying = true;// true -> first player play now , false -> second player play now
            string strError;
            char[,] board = new char[3, 3];

            initBoard(board);
            readPlayerNames(out strPlayer1Name, out strPlayer2Name);
            while (true)
            {
                drawBoard(board);
                if(!readPlayerCellSelection(out nZeroBaseRow, out nZeroBaseCol, out strError))
                {
                    showError(strError);
                    continue;
                }

                if(playerSelectionIsOk(board, nZeroBaseRow, nZeroBaseCol, out strError))
                {
                    board[nZeroBaseRow, nZeroBaseCol] = getPlayerChar(player1IsPlaying);
                    if (gameIsOver(board, player1IsPlaying ? strPlayer1Name : strPlayer2Name, out strGameFinishResult))
                    {
                        break;
                    }
                }
                else
                {
                    showError(strError);
                    continue;
                }
                player1IsPlaying = !player1IsPlaying;
            }
            drawBoard(board);
            showGameFinishResult(strGameFinishResult);
            Console.Read();
        }

        private static char getPlayerChar(bool player1IsPlaying)
        {
            return player1IsPlaying ? getPlayer1() : getPlayer2();
        }

        /// <summary>
        /// simple solution
        /// </summary>
        /// <param name="board"></param>
        private static void drawBoard(char[,] board)
        {
            for (int nRow = 0; nRow < board.GetLength(0); nRow++)
            {
                for (int nCol = 0; nCol < board.GetLength(1); nCol++)
                {
                    Console.Write(board[nRow, nCol]);
                }
                Console.WriteLine();
            }
        }

        private static bool gameIsOver(char[,] board , string strCurrentPlayerName , out string strGameFinishResult)
        {
            bool bRes=false;
            strGameFinishResult = "";
            char player;
            // x or o in row , col or diagonal
            if(gameIsOverByRow(board,out player))
            {
                bRes = true;
                strGameFinishResult = string.Format("{0} is winner", strCurrentPlayerName);
            }
            else if(gameIsOverByCol(board, out player))
            {
                bRes = true;
                strGameFinishResult = string.Format("{0} is winner", strCurrentPlayerName);
            }
            else if (gameIsOverByDiagonal(board, out player))
            {
                bRes = true;
                strGameFinishResult = string.Format("{0} is winner", strCurrentPlayerName);
            }
            else if(boardIsFull(board))
            {
                bRes = true;
                strGameFinishResult = "game is draw";
            }


                return bRes; // fix this
        }

        private static bool boardIsFull(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if((board[i,j] != getPlayer1()) && (board[i, j] != getPlayer1()))
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        private static bool gameIsOverByDiagonal(char[,] board, out char player)
        {
            player = ' ';
            bool bIsSame = (board[0, 0] == board[1, 1]) && (board[0, 0] == board[2, 2]);
            if (bIsSame)
            {
                player = board[0, 0];
                return true;
            }

            bIsSame = (board[0, 2] == board[1, 1]) && (board[0, 2] == board[2 , 0]);
            if (bIsSame)
            {
                player = board[0, 2];
                return true;
            }

            return false;
        }

        private static bool gameIsOverByCol(char[,] board, out char player)
        {
            player = ' ';
            for (int nCol = 0; nCol < 3; nCol++)
            {
                // check all items are same
                bool bIsSame = (board[0, nCol] == board[1, nCol]) && (board[0, nCol] == board[2, nCol]);
                if (bIsSame)
                {
                    player = board[0, nCol];
                    return true;
                }
            }

            return false;
        }

        private static bool gameIsOverByRow(char[,] board, out char player)
        {
            player = ' ';
            for (int nRow = 0; nRow < 3; nRow++)
            {
                // check all items are same
                bool bIsSame = (board[nRow, 0] == board[nRow, 1]) && (board[nRow, 0] == board[nRow, 2]);
                if(bIsSame)
                {
                    player = board[nRow, 0];
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 0 1 2
        /// 3 4 5
        /// 6 7 8
        /// </summary>
        /// <param name="board"></param>
        private static void initBoard(char[,] board)
        {
            int nShowThis = 0;
            for (int nRow = 0; nRow < board.GetLength(0); nRow++)
            {
                for (int nCol = 0; nCol < board.GetLength(1); nCol++)
                {
                    board[nRow, nCol] = nShowThis.ToString()[0];
                    nShowThis++;
                }
            }
        }

        /// <summary>
        /// pre condition row and col are in range it was checked before
        /// </summary>
        /// <param name="board"></param>
        /// <param name="nZeroBaseRow"></param>
        /// <param name="nZeroBaseCol"></param>
        /// <param name="firstPlayerIsPlaying"></param>
        /// <param name="strError"></param>
        /// <returns></returns>
        private static bool playerSelectionIsOk(char[,] board ,int nZeroBaseRow, 
            int nZeroBaseCol, out string strError)
        {
            bool bRes=true;
            strError = "";

            if ( (board[nZeroBaseRow, nZeroBaseCol] == getPlayer1()) ||
                (board[nZeroBaseRow, nZeroBaseCol] == getPlayer2()))
            {
                bRes = false;
                strError = "selection is all ready selected";
            }

            return bRes;
        }

        private static char getPlayer1()
        {
            return 'x';
        }

        private static char getPlayer2()
        {
            return 'o';
        }

        private static void showError(string strError)
        {
            Console.WriteLine(strError);
        }

        private static bool readPlayerCellSelection(out int nZeroBaseRow, out int nZeroBaseCol, out string strError)
        {
            int num;
            nZeroBaseRow = -1;
            nZeroBaseCol = -1;

            strError = "";
            Console.WriteLine("choose an integer number 0 -> 8");
            if(!int.TryParse(Console.ReadLine(),out num))
            {
                strError = "input is not in correct format";
                return false;
            }

            switch (num)
            {
                case 0:
                    nZeroBaseRow = 0;
                    nZeroBaseCol = 0;
                    break;

                case 1:
                    nZeroBaseRow = 0;
                    nZeroBaseCol = 1;
                    break;

                case 2:
                    nZeroBaseRow = 0;
                    nZeroBaseCol = 2;
                    break;

                case 3:
                    nZeroBaseRow = 1;
                    nZeroBaseCol = 0;
                    break;

                case 4:
                    nZeroBaseRow = 1;
                    nZeroBaseCol = 1;
                    break;

                case 5:
                    nZeroBaseRow = 1;
                    nZeroBaseCol = 2;
                    break;

                case 6:
                    nZeroBaseRow = 2;
                    nZeroBaseCol = 0;
                    break;

                case 7:
                    nZeroBaseRow = 2;
                    nZeroBaseCol = 1;
                    break;

                case 8:
                    nZeroBaseRow = 2;
                    nZeroBaseCol = 2;
                    break;


                default:
                    strError = "input is not in correct range";
                    return false;
            }

            return true;
        }

        private static void showGameFinishResult(string strGameFinishResult)
        {
            Console.WriteLine(strGameFinishResult);
        }

        private static void readPlayerNames(out string strPlayer1, out string strPlayer2)
        {
            Console.WriteLine("enter first player name and click enter");
            strPlayer1 = Console.ReadLine();
            Console.WriteLine("enter second player name and click enter");
            strPlayer2 = Console.ReadLine();

        }
    }
}
