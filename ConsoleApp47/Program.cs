using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] chess = new int[8, 8];
            Console.WriteLine("Attention.Imput the coordinates according by chess rules");
            Console.WriteLine("At First Imput The Letter Of Coordinate  And Click Enter");
            Console.WriteLine("Then Imput The Number Of Coordinate And Click Enter");
            
            KingClass king = new KingClass();
            Console.Write("White-King's First Coordinate=");
            king.whiteKingColumn = ImportCoordinatesClass.ImportColumnCordinate() - 1;
            Console.Write("White-King's Second Coordinate=");
            king.whiteKingRow = ImportCoordinatesClass.ImportRowCordinate() - 1;
            king.WaysOfFigure(king.whiteKingColumn, king.whiteKingRow, chess);

            QueenClass queen = new QueenClass();
            Console.Write("Queen's First Coordinate=");
            queen.column = ImportCoordinatesClass.ImportColumnCordinate() - 1;
            Console.Write("Queen's Second Coordinate=");
            queen.row = ImportCoordinatesClass.ImportRowCordinate() - 1;
            queen.WaysOfFigure(queen.column, queen.row, chess);

            BishopClass bishop = new BishopClass();
            Console.Write("Bishop's First Coordinate=");
            bishop.column = ImportCoordinatesClass.ImportColumnCordinate() - 1;
            Console.Write("Bishop's Second Coordinate=");
            bishop.row = ImportCoordinatesClass.ImportRowCordinate() - 1;
            bishop.WaysOfFigure(bishop.column, bishop.row, chess);

            RookClass rook = new RookClass();
            Console.Write("Rook's First Coordinate=");
            rook.column = ImportCoordinatesClass.ImportColumnCordinate() - 1;
            Console.Write("Rook's Second Coordinate=");
            rook.row = ImportCoordinatesClass.ImportRowCordinate() - 1;
            rook.WaysOfFigure(rook.column, rook.row, chess);

            KnightClass knight = new KnightClass();
            Console.Write("Knight's First Coordinate=");
            knight.column = ImportCoordinatesClass.ImportColumnCordinate() - 1;
            Console.Write("Knight's Second Coordinate=");
            knight.row = ImportCoordinatesClass.ImportRowCordinate() - 1;
            knight.WaysOfFigure(knight.column, knight.row, chess);

            Console.Write("Black-King's First Coordinate=");
            king.blackKingColumn = ImportCoordinatesClass.ImportColumnCordinate() - 1;
            Console.Write("Black-King's Second Coordinate=");
            king.blackKingRow = ImportCoordinatesClass.ImportRowCordinate() - 1;


            if (IsMate(chess, king.blackKingRow, king.blackKingColumn) == true)
                Console.WriteLine("Mate:Game Over");
            else
                Console.WriteLine("No mate");


            Console.ReadLine();
        }


        static bool IsMate(int[,] chess, int kingRow, int kingColumn)
        {
            bool mate = true; ;
            try { if (chess[kingRow + 1, kingColumn - 1] == 0) mate = false; } catch { };
            try { if (chess[kingRow + 1, kingColumn] == 0) mate = false; } catch { };
            try { if (chess[kingRow + 1, kingColumn + 1] == 0) mate = false; } catch { };
            try { if (chess[kingRow, kingColumn + 1] == 0) mate = false; } catch { };
            try { if (chess[kingRow - 1, kingColumn + 1] == 0) mate = false; } catch { };
            try { if (chess[kingRow - 1, kingColumn] == 0) mate = false; } catch { };
            try { if (chess[kingRow - 1, kingColumn - 1] == 0) mate = false; } catch { };
            try { if (chess[kingRow, kingColumn - 1] == 0) mate = false; } catch { };

            return mate;
        }
    }
}

