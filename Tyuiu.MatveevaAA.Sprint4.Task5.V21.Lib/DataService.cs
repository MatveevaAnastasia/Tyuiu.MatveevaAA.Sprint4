using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MatveevaAA.Sprint4.Task5.V21.Lib;

public class DataService : ISprint4Task5V21
{
    public int[,] Calculate(int[,] matrix)
    {
        int s = 0;
        int rows = matrix.GetUpperBound(0) + 1;
        int stolb = matrix.Length / rows;      
        //int minzn = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                if (matrix[i, j] > 0)
                {
                    matrix[i, j] = 1;
                }
            }
        }
        return matrix;
    }
}