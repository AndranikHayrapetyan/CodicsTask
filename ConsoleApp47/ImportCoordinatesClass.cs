using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class ImportCoordinatesClass
    {
        public static int ImportRowCordinate()
        {
            int rowCoordinate = 0;
            do
            {
                rowCoordinate = int.Parse(Console.ReadLine());
            }
            while (rowCoordinate < 1 || rowCoordinate > 8);

            return rowCoordinate;

        }

        public static int ImportColumnCordinate()
        {
            int columnCoordinate = 0;
            do
            {
                switch (Console.ReadLine())
                {
                    case "a":
                        columnCoordinate = 1;
                        break;
                    case "b":
                        columnCoordinate = 2;
                        break;
                    case "c":
                        columnCoordinate = 3;
                        break;
                    case "d":
                        columnCoordinate = 4;
                        break;
                    case "e":
                        columnCoordinate = 5;
                        break;
                    case "f":
                        columnCoordinate = 6;
                        break;
                    case "g":
                        columnCoordinate = 7;
                        break;
                    case "h":
                        columnCoordinate = 8;
                        break;
                }
            }
            while (columnCoordinate < 1 || columnCoordinate > 8);

            return columnCoordinate;
        }
    }
}
