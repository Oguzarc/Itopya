using System;
using GettingStartedLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace İtopyaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestControl()
        {
            var kontrol = new CalculatorService();
            var sonuc = kontrol.Kontrol("1234567890");
            Assert.IsTrue(sonuc);
        }
        [TestMethod]
        public void Testcvv()
        {
            var kontrol = new CalculatorService();
            var sonuc = kontrol.Kontrolcvv("545");
            Assert.IsTrue(sonuc);
        }
        [TestMethod]
        public void TestAy()
        {
            var kontrol = new CalculatorService();
            var sonuc = kontrol.Kontrolay("2");
            Assert.IsTrue(sonuc);
        }
        [TestMethod]
        public void TestDate()
        {
            var kontrol = new CalculatorService();
            var sonuc = kontrol.Kontroldate("19");
            Assert.IsTrue(sonuc);
        }


    }
}
