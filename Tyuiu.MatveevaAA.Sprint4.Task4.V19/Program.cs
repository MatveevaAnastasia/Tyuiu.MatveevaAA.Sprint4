using Tyuiu.MatveevaAA.Sprint4.Task4.V19.Lib;

DataService ds = new DataService();
int rows = 5;
int columns = 5;
int[,] mtrx = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"napishi {i}, {j} element");
        mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("\nMassive:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }
    Console.WriteLine();
}
int res = ds.Calculate(mtrx);
Console.WriteLine("summa nechetnih elementov: " + res);
Console.ReadKey();
