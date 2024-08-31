using System;

namespace Homework_Theme_05_4
{
    // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
    // является заданная последовательность элементами арифметической или геометрической прогрессии
    // 
    // Примечание
    //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
    //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
    //
    class Program
    {
        /// <summary>
        /// Метод преверяет являеся ли последовательность элиментов массива арифметической или геометрической прорессией
        /// </summary>                
        public static void IsArithmeticProgression(int[] array)
        {
            if (array.Length < 2)
            {
                Print($"Число не является арифметической и геометрической прогрессией",array);
            }
            else
            {
                int stepArithmeic = array[1] - array[0]; // Шаг арифметической прогресии
                int stepGeometric = array[1] / array[0]; // Шаг геометрическй прогрессии
                bool isArithmetic = false;               // Булевая переменная арифметической прогресии
                bool isGeometric = false;                // Булевая переменная геометрическй прогресии
                for (int i = 2; i < array.Length; i++)
                {
                    int nextArithmeicStep = array[i - 1] + stepArithmeic; // Определяем следующее число арифметической прогресии
                    int nextGeometricStep = array[i - 1] * stepGeometric; // Определяем следующее число геометрическй прогрессии
                    if (array[i] != nextArithmeicStep) isArithmetic = false;
                    else isArithmetic = true;
                    if (array[i] != nextGeometricStep) isGeometric = false;
                    else isGeometric = true;
                }
                if (isArithmetic) Print($"Данная последовательнасть чисел является арифметической прогрессией c шагом: {stepArithmeic}", array);
                else if (isGeometric) Print($"Данная последовательнасть чисел является геометрической прогрессией с шагом: {stepGeometric}", array);
                else Print("Данная последовательнасть чисел не является арифметической и геометрической прогрессией", array);
            }
        }
        /// <summary>
        /// Метод выводит текст и массив в консоль
        /// </summary>        
        private static void Print(string s, int[] array)
        {
            Console.WriteLine(s);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i],1} ");
            }
            Console.WriteLine("");

        }
        static void Main(string[] args)
        {
            int[] array1 = new[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32 };
            int[] array2 = new[] { 2, 4, 8, 16, 32, 64, 128 };
            int[] array3 = new[] { 2, 4, 8, 16, 32, 64, 128, 23 };
            int[] array4 = new[] { 2 };
            IsArithmeticProgression(array1);
            IsArithmeticProgression(array2);
            IsArithmeticProgression(array3);
            IsArithmeticProgression(array4);

        }
    }
}
