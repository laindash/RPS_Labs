namespace RPS_Labs.CW1
{
    public partial class Work1 : Form {
        public Work1() {
            InitializeComponent();
        }

        private void Btn_calc_Click(object sender, EventArgs e) {
            bool all_good = true;

            if (!double.TryParse(a_in.Text, out double a)) {
                MessageBox.Show("Введено некорректное значение a", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }
            if (!double.TryParse(b_in.Text, out double b)) {
                MessageBox.Show("Введено некорректное значение b", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }
            if (b <= a) {
                MessageBox.Show (
                    "Введены некорректные пределы интегрирования, нижний предел (a) должен быть меньше чем верхний предел (b)",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error 
                    );
                all_good = false;
            }


            if (!double.TryParse(bigA_in.Text, out double A)) {
                MessageBox.Show("Введено некорректное значение A", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }
            if (A == 0) {
                MessageBox.Show(
                    "Введите значение A не равное 0, для того, чтобы функция оставалась квадратичной", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                all_good = false;
            }

            if (!double.TryParse(bigB_in.Text, out double B)) {
                MessageBox.Show("Введено некорректное значение B", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }
            if (!double.TryParse(c_in.Text, out double C)) {
                MessageBox.Show("Введено некорректное значение C", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }


            if (!int.TryParse(decimal_places_in.Text, out int decimal_places)) {
                MessageBox.Show("Введено некорректное значение числа знаков после запятой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }
            if (decimal_places < 0) {
                decimal_places = Math.Abs(decimal_places);
                MessageBox.Show("Введенное значение числа знаков после запятой было взято по модулю", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!int.TryParse(n_in.Text, out int n) || n == 0) {
                MessageBox.Show("Введено некорректное значение интервалов разбиения n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                all_good = false;
            }
            if (n < 0) {
                n = Math.Abs(n);
                MessageBox.Show("Введенное значение интервалов разбиения n было взято по модулю", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (n % 2 != 0) {
                n = Math.Abs(n);
                MessageBox.Show(
                    "Так как введённое количество интервалов имеет нечётное значение, " +
                    "расчёт интеграла с помощью метода парабол (Симпсона) выполнен не будет", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if (all_good) {
                trapezoidal_result.Text = IntegralFunctions.TrapezoidalMethod(a, b, A, B, C, decimal_places, n).ToString();

                if (n % 2 == 0) {
                    parabolic_result.Text = IntegralFunctions.ParabolicMethod(a, b, A, B, C, decimal_places, n).ToString();
                }
                else {
                    parabolic_result.Text = "...";
                }
            }
        }
    }
}
