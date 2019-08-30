using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_22_first_test;

namespace Tests_MSTest
{
    [TestClass]
    public class MSTests
    {
        [TestMethod]
        public void SumTotalOfArrayTest()
        {
            // arrange
            int[] myArray = { 10, 20, 30 };
            var expected = 60;
            // act
            var actual = LabWork.SumTotalOfArrayMembers(myArray);
            // assert
            Assert.AreEqual(actual, expected);

        }
    }
}
