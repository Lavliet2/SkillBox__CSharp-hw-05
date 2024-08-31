using System;

namespace Homework_Theme_05
{
    // Домашнее задание
    // Требуется написать несколько методов
    //
    // Задание 1.
    // Воспользовавшись решением задания 3 четвертого модуля
    // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
    // 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
    // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение


    class Program
    {
        /// <summary>
        /// Метод выводит матрицу в консоль
        /// </summary>
        /// <param name="matrix">Двумерный массив(Матрица)</param>
        private static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],5} ");
                }
                Console.WriteLine("");
            }
        }
        /// <summary>
        /// Метод генерирования матрицы
        /// </summary>
        /// <param name="matrixCol">Количество строк в матрице</param>
        /// <param name="matrixRow">Количество колонок в матрице</param>
        /// <returns></returns>
        private static int[,] MatrixCreat(int matrixCol, int matrixRow)
        {
            int[,] matrix = new int[matrixCol, matrixRow];
            Random random = new Random();

            for (int i = 0; i < matrixCol; i++)
            {
                for (int j = 0; j < matrixRow; j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                }
            }
            return matrix;
        }
        /// <summary>
        /// Метод умножения матрицы на число
        /// </summary>
        /// <param name="multi">Множитель матрицы</param>
        /// <param name="matrix">Матрица</param>
        private static int [,] MultiMatrix(int multi, int[,] matrix)
        {
            int [,] resultMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = matrix[i,j] * multi;
                }
            }
            return resultMatrix;
        }
        /// <summary>
        /// Метод умножения матриц
        /// </summary>
        /// <returns></returns>
        private static int[,] MultiMatrix(int[,] matrixA, int[,] matrixB)
        {
            var resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < matrixB.GetLength(0); k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return resultMatrix;
        }
        /// <summary>
        /// Метод сложения матриц
        /// </summary>
        /// <param name="matrixA"></param>
        /// <param name="matrixB"></param>
        /// <returns></returns>
        private static int[,] AdditionMatrix(int[,] matrixA, int[,] matrixB)
        {
            var maRowCount = matrixA.GetLength(0);
            var mbRowCount = matrixB.GetLength(0);
            var maColumnCount = matrixA.GetLength(1);
            var mbColumnCount = matrixB.GetLength(1);
            var result = new int[maColumnCount, maRowCount];

            if (mbColumnCount != maColumnCount || mbRowCount != maRowCount)
            {
                Console.WriteLine("Ошибка! \"Количество столбцов и строк в матрицах должен быть одинаковый\"");
                Console.ReadKey();
                System.Environment.Exit(0);

            }
            else
            {
                for (int i = 0; i < maColumnCount; i++)
                {
                    for (int j = 0; j < maRowCount; j++)
                    {                        
                        result[i, j] = matrixA[i,j] + matrixB[i,j];
                    }
                }                
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Кодировка вывода консоли
            #region // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
            // Генерирование матрицы где первый элимент - строки, второй - столбцы
            var matrix = MatrixCreat(4, 6);
            Console.WriteLine("Матрица");
            Print(matrix);
            // Умножение матрицы на первый элимент
            int multi = 2;
            Console.WriteLine($"Матрица после умнажения на: {multi}");
            Print(MultiMatrix(multi,matrix));
            multi = -10;
            Console.WriteLine($"Матрица после умнажения на: {multi}");
            Print(MultiMatrix(multi, matrix));
            multi = 21;
            Console.WriteLine($"Матрица после умнажения на: {multi}");
            Print(MultiMatrix(multi, matrix));
            #endregion

            #region // 1.2.Создать метод, принимающий две матрицу, возвращающий их сумму
            //var matrixA = MatrixCreat(10, 10);
            //Console.WriteLine("Матриц А");
            //Print(matrixA);

            //var matrixB = MatrixCreat(10, 10);
            //Console.WriteLine("");
            //Console.WriteLine("Матрица B");
            //Print(matrixB);

            //var _result = AdditionMatrix(matrixA, matrixB);
            //Console.WriteLine("");
            //Console.WriteLine("Результат сложения матриц: ");
            //Print(_result);
            #endregion

            #region // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение
            //var matrixA = MatrixCreat(23, 18);
            //Console.WriteLine("Матрица А");
            //Print(matrixA);

            //var matrixB = MatrixCreat(18, 25);
            //Console.WriteLine("");
            //Console.WriteLine("Матрица: B");
            //Print(matrixB);
            //var _result = MultiMatrix(matrixA, matrixB);
            //Console.WriteLine("");
            //Console.WriteLine("Произведение матриц: ");
            //Print(_result);
            #endregion


        }
    }
}
