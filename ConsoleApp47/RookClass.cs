using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class RookClass : FiguresClass
    {
        public int row;
        public int column;

        public override int[,] WaysOfFigure(int column, int row, int[,] chess)
        {
            for (int i = 0; i < 8; i++)
            {
                if (i != column)
                    chess[row, i]++;
                if (i != row)
                    chess[i, column]++;
            }

            return chess;
        }
    }
}
