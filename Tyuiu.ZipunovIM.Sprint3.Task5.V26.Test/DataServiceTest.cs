using Tyuiu.ZipunovIM.Sprint3.Task5.V26.Lib;

namespace Tyuiu.ZipunovIM.Sprint3.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 13;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = 8192.42;

            Assert.AreEqual(wait, res);
        }
    }
}


