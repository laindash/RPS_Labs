// Модуль, содержащий функции для вычисления интегралов методом трапеций и методом парабол (Симпсона)


namespace RPS_Labs.CW1 {
    public class IntegralFunctions {
        private static double Func(double x, double A, double B, double C) {
            return A * x * x + B * x + C;
        }

        public static double TrapezoidalMethod(double a, double b, double A, double B, double C, int decimal_places, int n) {
            double 
                result, 
                sum = 0, 
                x = a, 
                h = (b - a) / n;

            while (n > 1) {
                x += h;
                sum += Func(x, A, B, C);
                n--;
            }
            
            result = h * ((Func(a, A, B, C) + Func(b, A, B, C)) / 2 + sum);
            result = Math.Round(result, decimal_places);

            return result;
        }
        
        public static double ParabolicMethod(double a, double b, double A, double B, double C, int decimal_places, int n) {
            double 
                result, 
                sum = 0, 
                x = a, 
                h = (b - a) / n;
            int k = 1;

            while (n > 1) {
                x += h;

                if (k % 2 == 0) {
                    sum += Func(x, A, B, C) * 2;
                }
                else {
                    sum += Func(x, A, B, C) * 4;
                }

                k++;
                n--;
            }
            
            result = h / 3 * (Func(a, A, B, C) + Func(b, A, B, C) + sum);
            result = Math.Round(result, decimal_places);

            return result;
        }
    }
}
