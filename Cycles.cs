using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАНИЕ 1: Первые 10 чисел Фибоначчи
            int a = 0, b = 1;
            Console.WriteLine("Задание 1: Первые 10 чисел Фибоначчи");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a);
                int temp = a + b;
                a = b;
                b = temp;
            }

            // ЗАДАНИЕ 2: Чётные числа от 2 до 20
            Console.WriteLine("\nЗадание 2: Чётные числа от 2 до 20");
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            // ЗАДАНИЕ 3: Таблица умножения от 1 до 5
            Console.WriteLine("\nЗадание 3: Таблица умножения от 1 до 5");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.WriteLine();
            }

            // ЗАДАНИЕ 4: Ввод пароля
            Console.WriteLine("\nЗадание 4: Введите пароль");
            string password = "qwerty";
            string input;
            do
            {
                Console.Write("Введите пароль: ");
                input = Console.ReadLine();
            } while (input != password);
            Console.WriteLine("Пароль верный!");
        }
    }
}