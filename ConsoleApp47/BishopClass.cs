using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodicsTask
{
    class BishopClass : FiguresClass
    {
        public int row;
        public int column;

        public override int[,] WaysOfFigure(int column, int row, int[,] chess)
        {

            for (int i = 1; i <= row; i++)
            {
                try { chess[row - i, column - i]++; } catch { }
            }

            for (int i = 1; i <= 7 - row; i++)
            {
                try { chess[row + i, column + i]++; } catch { }
            }

            for (int i = 1; i <= row; i++)
            {
                try { chess[row - i, column + i]++; } catch { }
            }

            for (int i = 1; i <= 7 - row; i++)
            {
                try { chess[row + i, column - i]++; } catch { }
            }

            return chess;
        }
    }
}
