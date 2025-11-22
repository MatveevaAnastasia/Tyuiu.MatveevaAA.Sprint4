using Tyuiu.MatveevaAA.Sprint4.Task5.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();
        Console.WriteLine("Input number of rows and colums:");
        int rows = Convert.ToInt32(Console.ReadLine());
        int cols = rows;
        Console.WriteLine("Input array elements:");
        int[,] array = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rnd.Next(-8, 3);
            }
        }
        Console.WriteLine("Array: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        int[,] result = ds.Calculate(array);
        Console.WriteLine("Array without positive numbers:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}