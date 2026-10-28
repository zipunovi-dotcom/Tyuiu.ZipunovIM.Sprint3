using Tyuiu.ZipunovIM.Sprint3.Task4.V10.Lib;

namespace Tyuiu.ZipunovIM.Sprint3.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            Assert.AreEqual(0.014, ds.Calculate(x, y));
        }
    }
}