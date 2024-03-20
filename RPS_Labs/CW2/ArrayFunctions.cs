// Модуль, содержащий функцию для нахождения в массиве значения, встречающегося чаще всего



namespace RPS_Labs.CW2 {
    public class ArrayFunctions {
        public static List<double> FindMostCommonValues(double[] array) {
            if (array.Length == 0) {
                return new List<double>(); // возвращаем пустой список для пустого массива
            }

            Dictionary<double, int> countDictionary = new Dictionary<double, int>();

            // Считаем количество встреч каждого значения
            foreach (double value in array) {
                if (countDictionary.ContainsKey(value)) {
                    countDictionary[value]++;
                }
                else {
                    countDictionary[value] = 1;
                }
            }

            // Находим максимальное количество повторений
            int maxCount = countDictionary.Values.Max();

            // Находим все значения, которые встречаются максимальное количество раз
            List<double> mostCommonValues = countDictionary
                .Where(pair => pair.Value == maxCount)
                .Select(pair => pair.Key)
                .ToList();

            return mostCommonValues;
        }
    }
}
