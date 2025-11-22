using Tyuiu.MatveevaAA.Sprint4.Task5.V21.Lib;

namespace Tyuiu.MatveevaAA.Sprint4.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[,]
            {
                {3, 4, 0},
                {4, -1, 6},
                {7, 6, 5}
            };
            int[,] wait = new int[,]
            {
                {1, 1, 0},
                {1, -1, 1},
                {1, 1, 1}
            };
            int[,] result = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, result);
        }
    }
}