using Tyuiu.ZipunovIM.Sprint3.Task2.V23.Lib;
namespace Tyuiu.ZipunovIM.Sprint3.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 1.5;
            int startValue = 1;
            int stopValue = 13;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = -63.727;
            Assert.AreEqual(wait, res);

        }
    }
}