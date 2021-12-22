using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Обязательная задача*.
              //Запросить у пользователя целочисленное значение N.
              //Сформировать двумерный массив размера NxN следующего вида:

              1 0 1 0 1

              0 1 0 1 0

              1 0 1 0 1

              0 1 0 1 0

              1 0 1 0 1 */

            //"Решение"
            // 1. Ввести значение N с клавиатуры
            // 2. Создать массив размера NxN
            // 3. Задать массиву конкретные значения 1 и 0
            // * нечетная строка: 1 0 1 0 1  * четная строка 0 1 0 1 0 
            // 4. Пронумеровать их в требуемой последовательности
            Console.Write("Введите значение n, что бы задать кол-во строк и столбцов таблице: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] mas = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("{0,2}", 1);
                        }
                        else
                        {
                            Console.Write("{0,2}", 0);
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("{0,2}", 0);
                        }
                        else
                        {
                            Console.Write("{0,2}", 1);
                        }
                    }
                }
                Console.WriteLine();
                
            }
            Console.WriteLine();
            Console.WriteLine("Cпасибо!");
            Console.ReadKey();

        }
    }
}



