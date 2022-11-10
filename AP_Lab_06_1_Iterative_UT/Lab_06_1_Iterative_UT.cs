/* Lab_06_1_Iterative_UT.cs
 * Якубовський Владислав
 * Unit-test до програми Lab_06_1_Iterative.cs */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using static AP_Lab_06_1_Iterative.Lab_06_1_Iterative;

namespace AP_Lab_06_1_Iterative_UT
{
    [TestClass]
    public class Lab_06_1_Iterative_UT
    {
        [TestMethod]
        public void TestCountElements()
        {
            int[] arrayToCountElements = { -2, 0, 10, -20, 7, -1, -5, -6, 8 };

            int count = CountElements(arrayToCountElements);

            Assert.AreEqual(7, count);
        }

        [TestMethod]
        public void TestSummarizeElements()
        {
            int[] arrayToSummarizeElements = { -2, 0, 10, -20, 7, -1, -5, -6, 8 };

            int sum = SummarizeElements(arrayToSummarizeElements);

            Assert.AreEqual(-19, sum);
        }

        [TestMethod]
        public void TestModifyArray()
        {
            int[] arrayToModify = { -2, 0, 10, -20, 7, -1, -5, -6, 8 },
                expectedModifiedArray = { 0, 0, 10, 0, 0, 0, 0, 0, 0 },
                actualModifiedArray = ModifyArray(arrayToModify);

            Assert.IsTrue(Enumerable.SequenceEqual(expectedModifiedArray, actualModifiedArray));
        }
    }
}
