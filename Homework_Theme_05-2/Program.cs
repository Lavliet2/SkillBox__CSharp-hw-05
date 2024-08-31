using System;
using System.Linq;

namespace Homework_Theme_05_2
{   
    // Задание 2.
    // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
    // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
    // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
    // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
    // 1. Ответ: А
    // 2. ГГГГ, ДДДД
    class Program
    {
        /// <summary>
        /// Метод по поиску самого короткого слова в тексте
        /// </summary>        
        private static void TextMinWord (string s)
        {            
            string min = s.Split(new Char[] { ' ', ',', '.', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).OrderByDescending(x => x.Length).LastOrDefault();
            Console.WriteLine($"Самое короткое слово в тексте: {min}");            
        }
        /// <summary>
        /// /// Метод по поиску самого длинного слова в тексте
        /// </summary>
        /// <param name="s"></param>
        private static void TextMaxWord(string s)
        {            
            string max = s.Split(new Char[] { ' ', ',', '.', ':', '!', '?' }).OrderByDescending(x => x.Length).FirstOrDefault();
            Console.WriteLine($"Самое длинное слово в тексте: {max}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            TextMinWord(Console.ReadLine());

            Console.WriteLine("Введите текст");
            TextMaxWord(Console.ReadLine());
            Console.ReadKey();


        }
    }
}
