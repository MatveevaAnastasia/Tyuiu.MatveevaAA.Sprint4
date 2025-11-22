using Tyuiu.MatveevaAA.Sprint4.Task3.V23.Lib;

namespace Tyuiu.MatveevaAA.Sprint4.Task3.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Матвеева Анастасия Андреевна | ПКТБ - 25 -1  ";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы (статический вывод)                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Матвеева Анастасия Андреевна | ПКТБ - 25 -1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статичес*");
            Console.WriteLine("*скими значениями в диапазоне от 2 до 8. Подсчитайте количество четных эле*");
            Console.WriteLine("*ементов во всем массиве.                                                 *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array =
            {
                { 7, 5, 5, 6, 7, },
                { 8, 7, 8, 4, 3, },
                { 5, 6, 7, 8, 3, },
                { 4, 2, 3, 6, 4, },
                { 5, 2, 4, 2, 3, },
            };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(array);
            Console.WriteLine("Сумма элементов массива: " + result);
            Console.ReadKey();
        }
    }
}