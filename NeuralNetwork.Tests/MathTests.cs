using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NeuralNetwork.Tests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] a = new double[]{1,2,3,4};

            test(a);

        }

        public void test(double[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                b[i] += 1;
            }
        }
    }
}
