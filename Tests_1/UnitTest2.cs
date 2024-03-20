using RPS_Labs.CW2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_1 {
    [TestClass]
    public class UnitTest2 {
        [TestMethod]
        public void FindMostCommonValues_OneValue_ReturnsSingleValue() {
            double[] array = { 1.0 };
            List<double> expected = new List<double> { 1.0 };
            List<double> actual = ArrayFunctions.FindMostCommonValues(array);         
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMostCommonValues_AllValuesDifferent_ReturnsAllValuesDifferentMessage() {
            double[] array = { 1.0, 2.0, 3.0, 4.0 };
            string result = "Ошибка";
            const string expected = "Все значения разные";
            List<double> actual = ArrayFunctions.FindMostCommonValues(array);
            if (actual.Count == array.Length) {
                result = "Все значения разные";
            }
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindMostCommonValues_MultipleValuesWithSameFrequency_ReturnsMultipleValues() {
            double[] array = { 1.0, 2.0, 2.0, 3.0, 3.0, 4.0, 4.0, 5.0 };
            List<double> expected = new List<double> { 2.0, 3.0, 4.0 };
            List<double> actual = ArrayFunctions.FindMostCommonValues(array);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMostCommonValues_EmptyArray_ReturnsEmptyList() {
            double[] array = { };
            List<double> expected = new List<double> { };
            List<double> actual = ArrayFunctions.FindMostCommonValues(array);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMostCommonValues_NullArray_ReturnsEmptyList() {
            double[] array = { 0, 0 };
            List<double> expected = new List<double> { 0 };
            List<double> actual = ArrayFunctions.FindMostCommonValues(array);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}