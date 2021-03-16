using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab1test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          int a = 4; 
          int b = 5;
          int c = 6;
          int result = Lab_1.Program.swap2(b,c);
            Assert.AreEqual(6,result);

        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 4;
            int b = 5;
            int c = 6;
            int result = Lab_1.Program.swap3(a,c);
            Assert.AreEqual(4, result);

        }
        [TestMethod]
        public void TestMethod3()
        {
            int a = 4;
            int b = 5;
            int c = 6;
            int result = Lab_1.Program.swap1(a,b);
            Assert.AreEqual(5, result);

        }

    }
}
