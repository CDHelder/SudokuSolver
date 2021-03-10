using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SudokuSolver.Logics
{
    public class TrashBinMaybe
    {

                    /*
            bool ValidHorizontal = false;

            foreach (var VerticalNumbers in sudoku)
            {

                
                List<int> NumsHorizontal = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                foreach (var HorizontalNumbers in VerticalNumbers)
                {
                    if (NumsHorizontal.Contains(HorizontalNumbers))
                    {
                        NumsHorizontal.Remove(HorizontalNumbers);
                    }
                    else if (NumsHorizontal.Count() == 0)
                    {
                        ValidHorizontal = true;
                        break;
                    }
                    else if (NumsHorizontal.Contains(HorizontalNumbers) == false)
                    {
                        ValidHorizontal = false;
                        break;
                    }
                }
            }
            */
    }
    public class TrashbinGoeie
    {
        /*
        public Boolean isValidSudoku(int[][] sudoku)
        {
            HashSet<string> NumSeen = new HashSet<string>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int currentNum = sudoku[i][j];
                    if (currentNum != 0)
                    {
                        if (!NumSeen.Add(currentNum + " found in row " + i) ||
                            !NumSeen.Add(currentNum + " found in column " + j) ||
                            !NumSeen.Add(currentNum + " found in box " + i / 3 + "-" + j / 3))
                        {
                            return false;
                        }

                    }
                }
            }
            return true;
        }
        */
    }
}