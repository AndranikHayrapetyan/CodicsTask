using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class KnightClass : FiguresClass
    {
        public int row;
        public int column;

        public override int[,] WaysOfFigure(int column, int row, int[,] chess)
        {
            try { chess[row + 2, column - 1]++; } catch { };
            try { chess[row - 2, column - 1]++; } catch { };
            try { chess[row + 2, column + 1]++; } catch { };
            try { chess[row - 2, column + 1]++; } catch { };
            try { chess[row + 1, column - 2]++; } catch { };
            try { chess[row - 1, column - 2]++; } catch { };
            try { chess[row + 1, column + 2]++; } catch { };
            try { chess[row - 1, column + 2]++; } catch { };

            return chess;

        }
    }
}
