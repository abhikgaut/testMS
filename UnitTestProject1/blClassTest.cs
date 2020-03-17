using System;
using businessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestProject1
{
    [TestClass]
    public class blClassTest
    {
        [TestMethod]
        public void DivideTest1()
        {
            //arrange-Declare actuals and expected
            int numer = 10;
            int denom = 2;
            int expected = 5;
            int actual = 0;

            //act-call the method and pass the actuals as parameter
            blClass b = new blClass();
            actual = b.Divide(numer.ToString(), denom.ToString());

            //assert-check whether actuals are matv=ching with expected
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void DivideTest2()
        {
            //arrange-Declare actuals and expected
            int numer = 0;
            int denom = 2;
            int expected = 0;
            

            //act-call the method and pass the actuals as parameter
            blClass b = new blClass();
            int actual = b.Divide(numer.ToString(), denom.ToString());

            //assert-check whether actuals are matv=ching with expected
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivideTest3()
        {
            //arrange-Declare actuals and expected
            int numer = 10;
            int denom = 0;
            blClass b = new blClass();
            var expected = Assert.ThrowsException<DivideByZeroException>(()=>b.Divide(numer.ToString(),denom.ToString()));
              
            Assert.AreEqual("cannot divide by zero",expected.Message);
        }
        [TestMethod]
        public void DivideTest4()
        {
            //arrange-Declare actuals and expected
            string numer = "abc";
            string denom = "xyz";
            blClass b = new blClass();
            var expected = Assert.ThrowsException<FormatException>(() => b.Divide(numer.ToString(), denom.ToString()));

            Assert.AreEqual("only numbers", expected.Message);
        }
        [TestMethod]
        public void AgeTest1()
        {
            //arrange-Declare actuals and expected
            DateTime age = DateTime.Parse("09/06/2009");
            blClass b = new blClass();
            var expected = Assert.ThrowsException<customException>(() => b.calculate(age));

            Assert.AreEqual("minimum age is 18", expected.Message);
        }
        [TestMethod]
        public void AgeTest2()
        {
            //arrange-Declare actuals and expected
            DateTime age = DateTime.Parse("09/06/1955");
            blClass b = new blClass();
            var expected = Assert.ThrowsException<customException>(() => b.calculate(age));

            Assert.AreEqual("maximum age is 60", expected.Message);
        }
    }
}
