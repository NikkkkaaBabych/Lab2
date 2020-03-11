using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2
{
    class Lab_2_2
    {
        static void Main(string[] args)
        {
            int n; int m;  
            Console.WriteLine("Введите количество строк матрицы ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы");
            m = Convert.ToInt32(Console.ReadLine());
            double [,] matr = new double [n, m];
            double [] everageS = new double [n];
            Console.WriteLine("Введите матрицу (по {0} вещественных числа на сточке через пробел)", m);
            for (int i = 0; i < n; i++)
            {
                    string[] elementsofstring = Console.ReadLine().Split(' ');
                    for (int j = 0; j < m; j++)
                    {
                        matr[i, j] = Convert.ToDouble(elementsofstring[j]);
                    }   
            }
            for (int i = 0; i < n; i++)
            {
                everageS[i] = 0.0;
                for (int j = 0; j < m; j++)
                {
                    everageS[i] += matr[i, j];
                }
                everageS[i] /= m;
                for (int j = 0; j < m; j++)
                {
                    matr[i, j] -= everageS[i];
                }
            }
            Console.WriteLine("Результат :");
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    Console.Write("{0} ", matr[j, i]);
                }
            Console.WriteLine();
            }
        Console.ReadLine();
        }
    }
}
