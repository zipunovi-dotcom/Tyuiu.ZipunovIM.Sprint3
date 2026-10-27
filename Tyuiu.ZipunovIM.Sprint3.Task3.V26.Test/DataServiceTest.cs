using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZipunovIM.Sprint3.Task3.V26.Lib;

namespace Tyuiu.ZipunovIM.Sprint3.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string value = "have a nice time";
            char item = 'e';
            int result = ds.GetCharCount(value, item);

            int wait = 2; // Â ñòðîêå "have a nice time" 2 áóêâû 'e'
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetCharCountUpperCase()
        {
            DataService ds = new DataService();

            string value = "Have A Nice Time";
            char item = 'e';
            int result = ds.GetCharCount(value, item);

            int wait = 2; // Âñå ðàâíî 2 áóêâû 'e' (ðåãèñòð íå ó÷èòûâàåòñÿ)
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetCharCountNoMatches()
        {
            DataService ds = new DataService();

            string value = "have a nice time";
            char item = 'z';
            int result = ds.GetCharCount(value, item);

            int wait = 0; // Áóêâû 'z' íåò â ñòðîêå
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetCharCountEmptyString()
        {
            DataService ds = new DataService();

            string value = "";
            char item = 'e';
            int result = ds.GetCharCount(value, item);

            int wait = 0; // Â ïóñòîé ñòðîêå íåò ñèìâîëîâ
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetCharCountMultipleOccurrences()
        {
            DataService ds = new DataService();

            string value = "eeeeee";
            char item = 'e';
            int result = ds.GetCharCount(value, item);

            int wait = 6; // 6 áóêâ 'e'
            Assert.AreEqual(wait, result);
        }
    }
}