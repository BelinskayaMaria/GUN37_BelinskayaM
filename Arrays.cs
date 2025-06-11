using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1: Массив из 8 чисел Фибоначчи
            int[] fibonacci = new int[8];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < 8; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            // Задание 2: Массив названий месяцев
            string[] months = {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };

            // Задание 3: Двумерный массив (матрица) 3x3
            int[,] matrix = new int[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    matrix[row, col] = (int)Math.Pow(col + 2, row + 1);
                }
            }

            // Задание 4: Jagged массив (ломанный массив)
            double[][] jaggedArray = new double[3][];
            jaggedArray[0] = new double[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new double[] { Math.E, Math.PI };
            jaggedArray[2] = new double[]
            {
                Math.Log10(1),
                Math.Log10(10),
                Math.Log10(100),
                Math.Log10(1000)
            };

            // Задание 5: Копирование первых 3-х элементов
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            var result = CopyArrays(array, array2, 3);

            Console.WriteLine("Результат копирования:");
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Задание 6: Увеличение размера массива в 2 раза
            Array.Resize(ref array, array.Length * 2);

            Console.WriteLine("Массив после изменения размера:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Метод для копирования элементов одного массива в другой
        static int[] CopyArrays(int[] source, int[] destination, int count)
        {
            Array.Copy(source, destination, count);
            return destination;
        }
    }
}