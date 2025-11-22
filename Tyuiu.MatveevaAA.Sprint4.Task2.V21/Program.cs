using Tyuiu.MatveevaAA.Sprint4.Task2.V21.Lib;

namespace Tyuiu.MatveevaAA.Sprint4.Task2.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Матвеева Анастасия Андреевна | ПКТБ - 25 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4");
            Console.WriteLine("* Тема: Одномернные массивы");
            Console.WriteLine("* Задание #2");
            Console.WriteLine("* Вариант #21");
            Console.WriteLine("* Матвеева Анастасия Андреевна | ПКТБ - 25 - 1                                ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Дан одномерный целочисленный массив на 15 элементов заполненный " +
                "случайными в диапазоне от 1 до 7 подсчитать произведение четных элементов массива.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 8);
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine(res);
        }
    }
}