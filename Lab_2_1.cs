using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_1
{
    class Lab_2_1
    {
        static void Main()
        {
            int n; int result;
            
            Console.WriteLine("Введите размерность матрицы n*n");
            n = Convert.ToInt32(Console.ReadLine());
            int [,] matrA = new int [n, n];
            int [] vektorB = new int [n];
            Console.WriteLine("Введите матрицу (по {0} целых числа на сточке через пробел)", n);
            for (int i = 0; i < n; i++)
            {
                {
                    string [] elementsofstring = Console.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        matrA[i, j] = Convert.ToInt32(elementsofstring [j]);
                    }
                }
            }
            Console.WriteLine("Введите вектор ({0} целых числа через пробел)", n);
            string[] elementsofvector = Console.ReadLine().Split(' ');
            
            for (int j = 0; j < n; j++)
            {
                vektorB [j] = Convert.ToInt32(elementsofvector[j]);
            }
            Console.WriteLine("Результат умножения матрицы на вектор");
            for (int i = 0; i < n; i++)
            {
                result = 0;
                for (int j = 0; j < n; j++)
                {
                    result += matrA[i, j] * vektorB[j];
                }
                Console.Write(result);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}

