using System.Collections.Generic;

namespace Problems
{
    public class ValidSudokuProblem
    {
        // https://leetcode.com/problems/valid-sudoku/
        public static bool IsValidSudoku(char[][] board)
        {
            var rowSet = new HashSet<char>();
            var colSets = new Dictionary<int, HashSet<char>>();
            var boxSets = new Dictionary<int, HashSet<char>>();
            for (var i = 0; i < board.Length; i++)
            {
                rowSet.Clear();
                for (var j = 0; j < board[i].Length; j++)
                {
                    var c = board[i][j];
                    if (c == '.') continue;
                    var g = j / 3;
                    if (!colSets.ContainsKey(j))
                    {
                        colSets.Add(j, new HashSet<char>());
                    }

                    if (!boxSets.ContainsKey(g))
                    {
                        boxSets.Add(g, new HashSet<char>());
                    }

                    if (rowSet.Contains(c) || colSets[j].Contains(c) || boxSets[g].Contains(c))
                    {
                        return false;
                    }

                    rowSet.Add(c);
                    colSets[j].Add(c);
                    boxSets[g].Add(c);
                }

                if ((i + 1) % 3 == 0)
                {
                    boxSets.Clear();
                }
            }

            return true;
        }
    }
}