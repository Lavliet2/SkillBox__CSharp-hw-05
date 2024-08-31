using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Homework_Theme_05_3
{

    // Задание 3. Создать метод, принимающий текст. 
    // Результатом работы метода должен быть новый текст, в котором
    // удалены все кратные рядом стоящие символы, оставив по одному 
    // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
    // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день
    class Program
    {
        /// <summary>
        /// Мутод удаляет все кратные рядом стоящие символы, оставив по одному
        /// </summary>
        public static  void RemoveConsecDuplicates(string s)
        {            
            string newString = "";
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] != s[i - 1])
                {
                    newString += s[i];
                }                
            }
            Console.WriteLine($"Текст после преобразования \n{newString}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string str = Console.ReadLine();
            RemoveConsecDuplicates(str);
        }
    }
}
