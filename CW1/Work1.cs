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
                MessageBox.Show(
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

        private void Btn_save_initial_Click(object sender, EventArgs e) {
            Btn_save_initial.Enabled = false;

            string a = a_in.Text, b = b_in.Text, A = bigA_in.Text, B = bigB_in.Text, C = c_in.Text,
                decimal_places = decimal_places_in.Text, n = n_in.Text;

            string initial_data =
                a + Environment.NewLine +
                b + Environment.NewLine +
                A + Environment.NewLine +
                B + Environment.NewLine +
                C + Environment.NewLine +
                decimal_places + Environment.NewLine +
                n + Environment.NewLine;

            // Диалог выбора папки
            FolderBrowserDialog folder_browser_dialog = new FolderBrowserDialog();

            if (folder_browser_dialog.ShowDialog() == DialogResult.OK) {
                // Получение пути к выбранной папке
                string folder_path = folder_browser_dialog.SelectedPath;

                try {
                    // Создание пути к файлу в выбранной папке
                    string file_path = Path.Combine(folder_path, "initial_data.txt");

                    // Запись данных в файл
                    File.WriteAllText(file_path, initial_data);
                    MessageBox.Show($"Данные успешно сохранены в файл {file_path}", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Btn_save_initial.Enabled = true;
        }

        private void Btn_save_result_Click(object sender, EventArgs e) {
            Btn_save_initial.Enabled = false;

            double.TryParse(a_in.Text, out double a);
            double.TryParse(b_in.Text, out double b);
            double.TryParse(bigA_in.Text, out double A);
            double.TryParse(bigB_in.Text, out double B);
            double.TryParse(c_in.Text, out double C);
            int.TryParse(decimal_places_in.Text, out int decimal_places);
            int.TryParse(n_in.Text, out int n);

            string result_data = 
                "Интеграл методом трапеций = " + IntegralFunctions.TrapezoidalMethod(a, b, A, B, C, decimal_places, n) + Environment.NewLine +
                "Интеграл методом парабол(Симпсона) = " + IntegralFunctions.ParabolicMethod(a, b, A, B, C, decimal_places, n) + Environment.NewLine;


            // Диалог выбора папки
            FolderBrowserDialog folder_browser_dialog = new FolderBrowserDialog();

            if (folder_browser_dialog.ShowDialog() == DialogResult.OK) {
                // Получение пути к выбранной папке
                string folder_path = folder_browser_dialog.SelectedPath;

                try {
                    // Создание пути к файлу в выбранной папке
                    string file_path = Path.Combine(folder_path, "save_data.txt");

                    // Запись данных в файл
                    File.WriteAllText(file_path, result_data);
                    MessageBox.Show($"Данные успешно сохранены в файл {file_path}", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Btn_save_initial.Enabled = true;
        }

        private void Btn_input_initial_Click(object sender, EventArgs e) {
            Btn_input_initial.Enabled = false;

            // Диалог выбора файла
            OpenFileDialog file_open_dialog = new OpenFileDialog();
            file_open_dialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            file_open_dialog.FilterIndex = 1;
            file_open_dialog.RestoreDirectory = true;

            if (file_open_dialog.ShowDialog() == DialogResult.OK) {
                try {
                    // Чтение данных из файла
                    string file_path = file_open_dialog.FileName;
                    string initial_data = File.ReadAllText(file_path);

                    // Разделение строк
                    string[] lines = initial_data.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                    // Присвоение значений переменным
                    if (lines.Length >= 7) {
                        string a = lines[0];
                        string b = lines[1];
                        string A = lines[2];
                        string B = lines[3];
                        string C = lines[4];
                        string decimal_places = lines[5];
                        string n = lines[6];

                        a_in.Text = a;
                        b_in.Text = b;
                        bigA_in.Text = A;
                        bigB_in.Text = B;
                        c_in.Text = C;
                        decimal_places_in.Text = decimal_places;
                        n_in.Text = n;

                        MessageBox.Show($"Данные успешно загружены из файла {file_path}", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Некорректный формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Произошла ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Btn_input_initial.Enabled = true;
        }
    }
}
