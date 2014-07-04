using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortirovka_z_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int i;
            int N;

            Console.Write("Программа предназначена для выполнения сортировки целочисленного массива челноч-\rным методом.\r\n"+"Введите количество элементов массива  ");
            N = int.Parse(Console.ReadLine());
            int[] F = new int[N];
            //Ввод массива
            Console.WriteLine("Введите элементы массива");
            for (i = 0; i < N; i++)
            {
                Console.Write("Элемент[" + (i + 1) + "]: ");
                F[i] = int.Parse(Console.ReadLine());
            }
            //Сортировка челночным методом
            for (int j = 0; j < N - 1; j++)
            {
                if (F[j] > F[j + 1])
                {
                    F[j] = F[j] + F[j + 1];
                    F[j + 1] = F[j] - F[j + 1];
                    F[j] = F[j] - F[j + 1];
                    for ( i = j; i > 0; i--)
                    {
                        if (F[i] < F[i - 1])
                        {
                            F[i] = F[i] + F[i - 1];
                            F[i - 1] = F[i] - F[i - 1];
                            F[i] = F[i] - F[i - 1];
                        }
                        else break;
                    }
                }
            }
            //Вывод массива отсортированного
            Console.Write("Отсортированный по возрастанию массив :");
            for (int I = 0; I < N; I++)
            {
                Console.Write(F[I] + "  ");
            }
                Console.ReadKey();
        }
    }
}
