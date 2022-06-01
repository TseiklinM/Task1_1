using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Начальный вклад в банке равен 10000 грн. Через каждый месяц размер вклада увеличивается 
            на P процентов от имеющейся суммы (P — вещественное число, 0 < P < 25). Значение Р программа 
            должна получать у пользователя. По данному P определить через сколько месяцев размер вклада 
            превысит 11000 грн., и вывести найденное количество месяцев K (целое число) и итоговый 
            размер вклада S (вещественное число).
             */

            // 1.Ввод данных
            Console.Write(" Начальный вклад в банке составляет 10.000 грн. " + "\n" +
               " Введите на какой процент ежемесячно увеличивается вклад: ");
            double procent = Convert.ToDouble(Console.ReadLine());
            double deposit = 10000;
            int month = 0;
            bool flag = false;

            // 2.Проверка условий ввода
            if (procent <= 0)
            {
                procent = 0;
                Console.WriteLine($" Размер процентной ставки равен нулю. \n " +
                            $"Вклад в банке находится на беспроцентной ставке." );
                Process.GetCurrentProcess().Kill();
            } else if (procent > 25)
                 {
                    procent = 25;
                    Console.WriteLine(" Размер процентной ставки равен 25%. \n");
                }

            // 3.Решение 
            while (!flag)
            {
                deposit += deposit * (procent / 100);
                month++;
                if (deposit > 11000)
                {
                    flag = true;
                }
            } 

            // 4.Вывод результата
            Console.WriteLine($"\n Размер вклада составил {Math.Round(deposit, 2)} грн. за {month} месяцев. ");


        }
    }
}
