using NUnit.Framework;
using lab_22_first_test;
using Tests;

namespace Tests
{
    public class NUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10, 10, 10, 1000)]
        [TestCase(10, 11, 12, 1320)]
        [TestCase(10, 15, 20, 3000)]
        public void CubicNumbersTest(int x, int y, int z, int expected)
        {
            // arrange
            var instance = new LabWork();
            // act
            var actual = instance.CubeNumbers(x, y, z);
            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(10, 10, 10, 1000)]
        [TestCase(10, 11, 12, 1320)]
        [TestCase(10, 15, 20, 3000)]
        public void CubicNumbersStaticTest(int x, int y, int z, int expected)
        {
            // arrange
            // act
            var actual = LabWork.CubeNumbersStatic(x, y, z);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 300, 500 }, 5)]
        [TestCase(new int[] { 1, 2, 3, -10, -30, -50 }, 6)]
        public void ArrayLengthTest(int[] testArray, int expected)
        {
            // arrange
            // act
            var actual = LabWork.GetLengthOfArray(testArray);
            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, 20, 30, 40 }, 1012)]
        [TestCase(new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, -2)]
        [TestCase(new int[] { 10, 20, 30, 50, 90, 110, 130, 150, 170, 190 }, -2)]
        [TestCase(new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, -2)]
        public void Mega_Multiple_Coding_Loops_Tests(int[] array, int expected)
        {
            //arrange

            // act
            var actual = Eng35Tests.Mega_Multiple_Coding_Loops(array);

            // assert
            Assert.AreEqual(expected, actual);

          
        }
    }
}