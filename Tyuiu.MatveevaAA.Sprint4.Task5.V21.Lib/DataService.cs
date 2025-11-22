using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MatveevaAA.Sprint4.Task5.V21.Lib
{
    public class DataService : ISprint4Task5V21
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] newmat = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        newmat[i, j] = 1;
                    }
                    else
                    {
                        newmat[i, j] = matrix[i, j];
                    }
                }
            }
            return newmat;
        }
    }
}