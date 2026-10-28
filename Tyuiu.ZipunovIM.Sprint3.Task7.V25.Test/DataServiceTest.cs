using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZipunovIM.Sprint3.Task7.V25.Lib;

namespace Tyuiu.ZipunovIM.Sprint3.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            double[] result = ds.GetMassFunction(startValue, stopValue);

            double[] wait = {
                -1.49, -1.38, -1.18, -0.82, -0.15, 0, 2.51, 1.63, 1.28, 1.09, 0.97
            };

            CollectionAssert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetMassFunctionZeroDivision()
        {
            DataService ds = new DataService();

            int startValue = 0;
            int stopValue = 0;
            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Ïðè x = 0 äîëæíî âåðíóòü 0 (äåëåíèå íà íîëü)
            double[] wait = { 0 };
            CollectionAssert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetMassFunctionRange()
        {
            DataService ds = new DataService();

            int startValue = -2;
            int stopValue = 2;
            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Ïðîâåðÿåì äëèíó ìàññèâà
            Assert.AreEqual(5, result.Length);

            // Ïðîâåðÿåì, ÷òî ïðè x=0 âîçâðàùàåòñÿ 0
            Assert.AreEqual(0, result[2]);
        }

        [TestMethod]
        public void ValidGetMassFunctionSingleValue()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 1;
            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Ðó÷íîé ðàñ÷åò äëÿ x=1
            double numerator = Math.Cos(1) + 4 * 1;
            double denominator = 2 - Math.Sin(1) * 3 * 1;
            double manualResult = Math.Round(numerator / denominator, 2);

            Assert.AreEqual(manualResult, result[0]);
        }

        [TestMethod]
        public void ValidGetMassFunctionRounding()
        {
            DataService ds = new DataService();

            int startValue = 3;
            int stopValue = 3;
            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Ïðîâåðÿåì îêðóãëåíèå äî 2 çíàêîâ
            string resultString = result[0].ToString("F2");
            Assert.IsTrue(resultString.EndsWith(".00") || resultString.EndsWith(".25") ||
                         resultString.EndsWith(".50") || resultString.EndsWith(".75"));
        }
    }
}