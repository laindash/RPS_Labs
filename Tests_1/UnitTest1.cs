using RPS_Labs.CW1;

namespace Tests_1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void Test_Trapezoidal_1() {
            double a = 3, b = 5, A = 1, B = 1, C = 1;
            int decimal_places = 2, n = 3;
            const double RESULT = 42.81;
      
            Assert.AreEqual(RESULT, IntegralFunctions.TrapezoidalMethod(a, b, A, B, C, decimal_places, n));
        }

        [TestMethod]
        public void Test_Trapezoidal_2() {
            double a = 0, b = 8, A = 5, B = 0, C = 0;
            int decimal_places = 4, n = 15;
            const double RESULT = 855.2296;
      
            Assert.AreEqual(RESULT, IntegralFunctions.TrapezoidalMethod(a, b, A, B, C, decimal_places, n));
        }

        [TestMethod]
        public void Test_Trapezoidal_3() {
            double a = 3, b = 5, A = 0, B = 1, C = 0;
            int decimal_places = 2, n = 3;
            const double RESULT = 0;
      
            Assert.AreEqual(RESULT, IntegralFunctions.TrapezoidalMethod(a, b, A, B, C, decimal_places, n));
        }

        [TestMethod]
        public void Test_Parabolic_1() {
            double a = -50, b = 125, A = 33, B = 4, C = 21;
            int decimal_places = 2, n = 4;
            const double RESULT = 22889300;
      
            Assert.AreEqual(RESULT, IntegralFunctions.ParabolicMethod(a, b, A, B, C, decimal_places, n));
        }

        [TestMethod]
        public void Test_Parabolic_2() {
            double a = 3, b = 5, A = 5, B = 4, C = 3;
            int decimal_places = 3, n = 8;
            const double RESULT = 201.333;
      
            Assert.AreEqual(RESULT, IntegralFunctions.ParabolicMethod(a, b, A, B, C, decimal_places, n));
        }
    }
}