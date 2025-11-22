using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MatveevaAA.Sprint4.Task7.V28.Lib
{
    public class DataService : ISprint4Task7V28
    {

        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            int r = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        r = r * mtrx[i, j];
                    }
                }
            }
            return r;
        }


    }
}