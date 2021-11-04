using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание № 1");
            Console.WriteLine("Введите первое число: ");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            if (num_1 > num_2)
            {
                Console.WriteLine("Первое число больше второго.");
            }
            else if (num_1 < num_2)
            {
                Console.WriteLine("Второе число больше первого.");
            }
            else {
                Console.WriteLine("Два числа равны.");
            }
        }


    }
}
