using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodicsTask
{
    class KingClass : FiguresClass
    {
        public int whiteKingRow;
        public int whiteKingColumn;

        public int blackKingRow;
        public int blackKingColumn;


        public override int[,] WaysOfFigure(int column, int row, int[,] chess)
        {
            try { chess[row + 1, column - 1]++; } catch { };
            try { chess[row + 1, column]++; } catch { };
            try { chess[row + 1, column + 1]++; } catch { };
            try { chess[row, column + 1]++; } catch { };
            try { chess[row - 1, column + 1]++; } catch { };
            try { chess[row - 1, column]++; } catch { };
            try { chess[row - 1, column - 1]++; } catch { };
            try { chess[row, column - 1]++; } catch { };

            return chess;
        }
    }
}
