using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglosdedosdimensiones 
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableArr = DeclareTable(3, 6);
            foreach (var item in tableArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(ReadTableCell(tableArr, 3, 4));
            Console.WriteLine(WriteTableCell(tableArr, 3, 4, 26));
            foreach (var item in tableArr)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }

        static int[] DeclareTable(int row, int column)
        {
            int size = row * column;
            int[] tableArr = new int[size];
            for (int i = 0; i < size; i++)
            {
                tableArr[i] = i;
            }
            return tableArr;
            
        }

        static int ReadTableCell(int[] array, int row, int column)
        {
            return array[(2 * row) + column];
        }

        static int WriteTableCell(int[] array, int row, int column, int value)
        {
            int placeHolder = array[(2 * row) + column];
            array[(2 * row) + column] = value;
            return placeHolder;
            
        }
    }
}
