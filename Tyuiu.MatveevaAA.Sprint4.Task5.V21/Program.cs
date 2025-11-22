using Tyuiu.MatveevaAA.Sprint4.Task5.V21.Lib;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Матвеева Анастасия Андреевна | ПКТБ-25-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #4                                                            *");
        Console.WriteLine("* Тема:                                                                *");
        Console.WriteLine("* Задание #5                                                           *");
        Console.WriteLine("* Вариант #21                                                          *");
        Console.WriteLine("* Выполнил: Матвеева Анастасия Андреевна  | ПКТБ-25-1                   *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");
        int s;
        int rows;
        Console.WriteLine("кол строк");
        rows = Convert.ToInt32(Console.ReadLine());
        int columns;
        Console.WriteLine("кол столбцов");
        columns = Convert.ToInt32(Console.ReadLine());


        int[,] matrix = new int[rows, columns];
        Console.WriteLine("************************************************************************");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = rnd.Next(-8, 2);
                Console.WriteLine($"Значение\t" + i + " " + j + " " + $"{matrix[i, j]} ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("************************************************************************");
        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine("\r");
        }
        Console.WriteLine();
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        int[,] m = ds.Calculate(matrix);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}