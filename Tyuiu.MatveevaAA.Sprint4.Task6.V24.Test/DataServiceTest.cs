using Tyuiu.MatveevaAA.Sprint4.Task6.V24.Lib;

namespace Tyuiu.MatveevaAA.Sprint4.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            string[] array = { "Êîìïüþòåð", "Òåëåôîí", "Ïëàíøåò", "Ïðèíòåð", "Ñêàíåð", "Ìîíèòîð", "Êëàâèàòóðà" };
            string[] wait = { "Êîìïüþòåð", "Êëàâèàòóðà" };
            string[] res = ds.Calculate(array);
            CollectionAssert.AreEqual(wait, res);


        }
    }
}