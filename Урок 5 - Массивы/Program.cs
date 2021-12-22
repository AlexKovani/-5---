using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Сформировать одномерный массив из 7 элементов.
            //  Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.

            //"Решение"
            // 1. создаю и инициализирую массив num
            // 2. ввожу 7 элементов массива
            // 3. считаю сумму всех введенных элементов
            // 4. вывожу на экран число ср.арифмет. значения = Сум/7

            //1.
             const int n = 7;
             int[] num = new int[n];
             //2.
             Console.WriteLine("Введите 7 чисел, через Enter :");
             for (int i = 0; i < n; i++)
             {
              num[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine();
             //3.
             int S = 0;
             for (int i = 0; i < n; i++)
             {
                 S += num[i];
             }
             //4.
             Console.WriteLine("Ср. Арифметич. введенных чисел = " + S/n);
             Console.ReadKey();

            }
    }
}

