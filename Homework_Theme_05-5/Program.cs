using System;

namespace Homework_Theme_05_5
{
    // *Задание 5
    // Вычислить, используя рекурсию, функцию Аккермана:
    // A(2, 5), A(1, 2)
    // A(n, m) = m + 1, если n = 0,
    //         = A(n - 1, 1), если n <> 0, m = 0,
    //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
    // 
    // Весь код должен быть откоммментирован
    class Program
    {
        /// <summary>
        /// Метод вычесления функции Аккермана
        /// </summary>
        /// <returns></returns>
        private static int Akkerman(int n, int m)
        {
            if (n == 0) // Если n равно 0 возвращяем m + 1
            {
                return m + 1;
            }
            else
            {
                // Если n не равно 0 и m равно 0 возвращяем фунцкию Аккермана со значениями n - 1 и 1
                if (n != 0 && m == 0)
                {
                    return Akkerman(n - 1, 1);
                }
                // Иначе возвращяем фунцкию Аккермана со значениями n - 1 и фунцкией Аккермана n, m - 1
                else
                {
                    return Akkerman(n - 1, Akkerman(n, m - 1));
                }

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Akkerman(2, 5));
            Console.WriteLine(Akkerman(1, 2));
            Console.WriteLine(Akkerman(3, 5));
            Console.ReadKey();
        }
    }
}
