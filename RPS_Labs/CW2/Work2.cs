using RPS_Labs.CW1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RPS_Labs.CW2 {
    public partial class Work2 : Form {
        public Work2() {
            InitializeComponent();
        }

        private void Btn_find_Click(object sender, EventArgs e) {
            Btn_find.Enabled = false;
            label_result.Text = "...";
            try {
                // Удаление завершающих символов-разделителей (;) справа от строки
                string valuesAsString = string.Join(";", array_input.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));

                // Преобразование строковых значений в массив double
                double[] array = valuesAsString.Split(';').Select(double.Parse).ToArray();

                string originalValuesAsString = string.Join(";", array.Select(num => num.ToString()));

                if (array_input.Text != originalValuesAsString) {
                    array_input.Text = originalValuesAsString;
                    MessageBox.Show("Некорректные данные были исправлены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Нахождение наиболее часто встречающихся значений в массиве
                List<double> mostCommonValues = ArrayFunctions.FindMostCommonValues(array);

                // Если все значения разные, выводим сообщение
                if (mostCommonValues.Count == array.Length && array.Length != 1) {
                    label_result.Text = "Все значения разные";
                }
                else if (mostCommonValues.Count == array.Length && array.Length == 1) {
                    label_result.Text = string.Join("; ", mostCommonValues);
                }
                else {
                    // Вывод результата на метку
                    label_result.Text = string.Join("; ", mostCommonValues);
                }
            }
            catch (FormatException) {
                // Вывод сообщения об ошибке при некорректном вводе
                MessageBox.Show("Ошибка ввода. Пожалуйста, убедитесь, что вводимые данные корректны.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Btn_find.Enabled = true;
        }


        private void array_input_KeyPress(object sender, KeyPressEventArgs e) {
            // Разрешаем вводить только цифры, запятые и точки с запятой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != ';' && e.KeyChar != '-') {
                e.Handled = true;
                return;
            }
            label_result.Text = "...";
        }

        private void Btn_input_initial_Click(object sender, EventArgs e) {
            Btn_input_initial.Enabled = false;
            label_result.Text = "...";

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

                    // Присвоение значений массива
                    array_input.Text = initial_data;

                    MessageBox.Show($"Данные успешно загружены из файла {file_path}", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    MessageBox.Show($"Произошла ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Btn_input_initial.Enabled = true;
        }


        private void Btn_save_original_Click(object sender, EventArgs e) {
            Btn_save_original.Enabled = false;

            try {
                // Преобразование исходного массива в строку
                string initialDataAsString = string.Join(";", array_input.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));

                double[] array = initialDataAsString.Split(';').Select(double.Parse).ToArray();

                // Обратное преобразование массива в строку с исходным разделителем
                string originalValuesAsString = string.Join(";", array.Select(num => num.ToString()));

                if (array_input.Text != originalValuesAsString) {
                    array_input.Text = originalValuesAsString;
                    MessageBox.Show("Некорректные данные были исправлены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Диалог выбора места сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    // Получение пути к выбранному файлу
                    string file_path = saveFileDialog.FileName;

                    // Запись данных в файл
                    File.WriteAllText(file_path, originalValuesAsString);
                    MessageBox.Show($"Данные успешно сохранены в файл {file_path}", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException) {
                // Вывод сообщения об ошибке при некорректном вводе
                MessageBox.Show("Ошибка ввода. Пожалуйста, убедитесь, что вводимые данные корректны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Btn_save_original.Enabled = true;
        }


        private void Btn_save_result_Click(object sender, EventArgs e) {
            Btn_save_result.Enabled = false;

            try {
                // Преобразование исходного массива в строку
                string initialDataAsString = string.Join(";", array_input.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));

                // Преобразование строковых значений в массив double
                double[] array = initialDataAsString.Split(';').Select(double.Parse).ToArray();

                // Обратное преобразование массива в строку с исходным разделителем
                string originalValuesAsString = string.Join(";", array.Select(num => num.ToString()));

                if (array_input.Text != originalValuesAsString) {
                    array_input.Text = originalValuesAsString;
                    MessageBox.Show("Некорректные данные были исправлены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Нахождение наиболее часто встречающихся значений в массиве
                List<double> mostCommonValues = ArrayFunctions.FindMostCommonValues(array);

                string mostCommonValuesAsString;

                // Если все значения разные, выводим сообщение
                if (mostCommonValues.Count == array.Length && array.Length != 1) {
                    label_result.Text = "Все значения разные";
                }
                else if (mostCommonValues.Count == array.Length && array.Length == 1) {
                    label_result.Text = string.Join("; ", mostCommonValues);
                }
                else {
                    // Вывод результата на метку
                    label_result.Text = string.Join("; ", mostCommonValues);
                }

                if (mostCommonValues.Count == array.Length) {
                    mostCommonValuesAsString = "Все значения разные";
                }
                else if (mostCommonValues.Count == array.Length && array.Length == 1) {
                    mostCommonValuesAsString = string.Join("; ", mostCommonValues);
                }
                else {
                    // Преобразование наиболее часто встречающихся значений в строку
                    mostCommonValuesAsString = string.Join("; ", mostCommonValues);
                }

                // Сбор общей строки для сохранения
                string result_data = $"Исходный массив: {originalValuesAsString}{Environment.NewLine}Наиболее часто встречающиеся значения: {mostCommonValuesAsString}";

                // Диалог выбора файла для сохранения
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    try {
                        // Создание пути к файлу
                        string file_path = saveFileDialog.FileName;

                        // Запись данных в файл
                        File.WriteAllText(file_path, result_data);
                        MessageBox.Show($"Данные успешно сохранены в файл {file_path}", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) {
                        MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException) {
                // Вывод сообщения об ошибке при некорректном вводе
                MessageBox.Show("Ошибка ввода. Пожалуйста, убедитесь, что вводимые данные корректны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Btn_save_result.Enabled = true;
        }
    }
}
