namespace RPS_Labs
{
    public partial class MainWindow : Form
    {
        public MainWindow() {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;

            // Запретить открытие на полный экран
            MaximizeBox = false;

            Btn_lab2.Enabled = false;
            Btn_lab3.Enabled = false;
            Btn_lab4.Enabled = false;
        }


        private void Work1_FormClosing(object sender, FormClosingEventArgs e) {
            Btn_lab1.Enabled = true;
        }
        private void Btn_lab1_Click(object sender, EventArgs e) {
        Btn_lab1.Enabled = false;

        CW1.Work1 form_Work1 = new CW1.Work1();

        form_Work1.FormBorderStyle = FormBorderStyle.FixedSingle;

        // Запретить открытие на полный экран
        form_Work1.MaximizeBox = false;

#pragma warning disable CS8622 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует целевому объекту делегирования (возможно, из-за атрибутов допустимости значений NULL).
        form_Work1.FormClosing += Work1_FormClosing;
#pragma warning restore CS8622 // Допустимость значений NULL для ссылочных типов в типе параметра не соответствует целевому объекту делегирования (возможно, из-за атрибутов допустимости значений NULL).
        
        form_Work1.Show();
        form_Work1.Text = "Работа №1. Алгоритмы и структуры данных";
        }
        

        private void Btn_lab2_Click(object sender, EventArgs e) {
        }
        private void Btn_lab3_Click(object sender, EventArgs e) {
        }
        private void Btn_lab4_Click(object sender, EventArgs e) {
        }
    }
}
