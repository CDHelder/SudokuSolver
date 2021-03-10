using SudokuSolver.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace SudokuSolver.Logics
{
    public class Solver
    {
        public int[][] Solve(int[][] sudoku)
        {
            /*
            DONE    Functie die horizontaal checkt
            DONE    Functie die verticaal checkt          
            DONE    Functie die het blokje checkt         
            -       Functie die cijfers controleerd of ze op de juiste plek staan

            Ga met een loop door die checks heen en zodra het klopt vul het getal in

            ~Begin met een functie die checkt of een horizontale as klopt
            ~Daarna een functie die een verticale as checkt of die klopt
            ~Daarna een functie die het blokje checkt
            ~Verbind ze allemaal met elkaar
            ~Uiteindelijk maak een functie die checkt of de vakjes goed ingevuld zijn wanneer 
             er een error komt of een vakje niet goed kan worden ignevuld

            Check voor een goeie tutorial over het gehele project (er zal vast wel wat over zijn)
            Check Youri Zijn GitHub project voor basis en logica van het project

            ~~~~~~~~~~ SOURCES ~~~~~~~~~~
            BESTE
            https://www.youtube.com/watch?v=Pl7mMcBm2b8
            https://codereview.stackexchange.com/questions/179725/sudoku-solver-recursive-solution-with-clear-structure
            https://codereview.stackexchange.com/questions/13677/solving-sudoku-using-backtracking
            https://leetcode.com/problems/valid-sudoku/discuss/15450

            https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1.add?view=net-5.0#System_Collections_Generic_HashSet_1_Add__0_
            https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=net-5.0

            MAYBE
            https://github.com/bryandijkhuizen/SudokuSolver
            https://www.codeproject.com/Articles/227435/Solving-Sudoku
            https://www.c-sharpcorner.com/blogs/sudoku-solver
             */


            return sudoku;
        }

        public int[][] Create(int[][] sudoku)
        {
            return sudoku;
        }

        public bool ValidatePossiblity(int[][] sudoku, int num) //TestMethod om de logica te proberen te vinden
        {
            for (int i = 0; i < 9; i++)
            {
                HashSet<int> rows = new HashSet<int>();
                HashSet<int> colums = new HashSet<int>();
                HashSet<int> cube = new HashSet<int>();
                HashSet<int> possibleNum = new HashSet<int>();

                // ??   Klopt de reference naar sudoku[i][j], laat die het cijfer zien van de cell of laat geeft de waarde van de x en y as     ??
                // ??   Moet de reference niet naar num en bij doos een nieuwe soort verwijzing zodat num daar ook gecheckt kan worden          ??

                for (int j = 0; j < 9; j++)
                {
                    for (int PossibleNum = 0; PossibleNum < 9; PossibleNum++)
                    {
                        int RowIndex = 3 * (i / 3);
                        int ColIndex = 3 * (i % 3);

                        //Checkt row
                        if (sudoku[i][j] != 0 && !rows.Add(sudoku[i][j]))
                            return false;

                        //Checkt colums
                        else if (sudoku[j][i] != 0 && !colums.Add(sudoku[j][i]))
                            return false;

                        //Checkt doos
                        else if (sudoku[RowIndex + j / 3][ColIndex + j % 3] != 0 && !cube.Add(sudoku[RowIndex + j / 3][ColIndex + j % 3]))
                            return false;

                        //Als hij niet in de row, colum of doos zit voegt hij hem toe als mogelijkheid
                        else
                            possibleNum.Add(sudoku[i][j]);

                        //Als er meerdere mogelijkheden zijn kan de cell niet worden ingevuld
                        if (possibleNum.Count() > 1)
                            return false;
                    }
                }
            }
            return true;
        }

        public bool ValidateCellEchte(int[][] sudoku, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                HashSet<int> rows = new HashSet<int>();
                HashSet<int> colums = new HashSet<int>();
                HashSet<int> cube = new HashSet<int>();

                // ??   Klopt de reference naar sudoku[i][j], laat die het cijfer zien van de cell of laat geeft de waarde van de x en y as     ??
                // ??   Moet de reference niet naar num en bij doos een nieuwe soort verwijzing zodat num daar ook gecheckt kan worden          ??

                for (int j = 0; j < 9; j++)
                {
                    int RowIndex = 3 * (i / 3);
                    int ColIndex = 3 * (i % 3);

                    //Checkt row
                    if (sudoku[i][j] != 0 && !rows.Add(sudoku[i][j]))
                        return false;

                    //Checkt colums
                    else if (sudoku[j][i] != 0 && !colums.Add(sudoku[j][i]))
                        return false;

                    //Checkt doos
                    else if (sudoku[RowIndex + j / 3][ColIndex + j % 3] != 0 && !cube.Add(sudoku[RowIndex + j / 3][ColIndex + j % 3]))
                        return false;

                    /*
                    !!~~ Dit moet buiten de method ~~!!

                    //Als hij niet in de row, colum of doos zit voegt hij hem toe als mogelijkheid
                    else
                        possibleNum.Add(sudoku[i][j]);

                    //Als er meerdere mogelijkheden zijn kan de cell niet worden ingevuld
                    if (possibleNum.Count() > 1)
                        return false;
                    */
                }
            }
            return true;
        }
    }
}