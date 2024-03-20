namespace RPS_Labs.CW1
{
    partial class Work1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label3 = new Label();
            a_in = new TextBox();
            b_in = new TextBox();
            trapezoidal_result = new Label();
            parabolic_result = new Label();
            bigA_in = new TextBox();
            label4 = new Label();
            bigB_in = new TextBox();
            label5 = new Label();
            c_in = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            decimal_places_in = new TextBox();
            label13 = new Label();
            label14 = new Label();
            n_in = new TextBox();
            Btn_calc = new Button();
            Btn_save_initial = new Button();
            Btn_save_result = new Button();
            Btn_input_initial = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 302);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(427, 25);
            label1.TabIndex = 1;
            label1.Text = "Интеграл, вычисленный методом трапеций";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 60);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 63);
            label3.TabIndex = 3;
            label3.Text = "∫";
            // 
            // a_in
            // 
            a_in.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a_in.Location = new Point(32, 140);
            a_in.Margin = new Padding(4, 3, 4, 3);
            a_in.Name = "a_in";
            a_in.PlaceholderText = "a";
            a_in.Size = new Size(44, 38);
            a_in.TabIndex = 4;
            a_in.TextAlign = HorizontalAlignment.Center;
            // 
            // b_in
            // 
            b_in.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b_in.Location = new Point(32, 23);
            b_in.Margin = new Padding(4, 3, 4, 3);
            b_in.Name = "b_in";
            b_in.PlaceholderText = "b";
            b_in.Size = new Size(44, 38);
            b_in.TabIndex = 5;
            b_in.TextAlign = HorizontalAlignment.Center;
            // 
            // trapezoidal_result
            // 
            trapezoidal_result.AutoSize = true;
            trapezoidal_result.BackColor = SystemColors.Menu;
            trapezoidal_result.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trapezoidal_result.Location = new Point(480, 302);
            trapezoidal_result.Margin = new Padding(4, 0, 4, 0);
            trapezoidal_result.Name = "trapezoidal_result";
            trapezoidal_result.Size = new Size(27, 25);
            trapezoidal_result.TabIndex = 6;
            trapezoidal_result.Text = "...";
            // 
            // parabolic_result
            // 
            parabolic_result.AutoSize = true;
            parabolic_result.BackColor = SystemColors.Menu;
            parabolic_result.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parabolic_result.Location = new Point(480, 346);
            parabolic_result.Margin = new Padding(4, 0, 4, 0);
            parabolic_result.Name = "parabolic_result";
            parabolic_result.Size = new Size(27, 25);
            parabolic_result.TabIndex = 7;
            parabolic_result.Text = "...";
            // 
            // bigA_in
            // 
            bigA_in.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigA_in.Location = new Point(91, 81);
            bigA_in.Margin = new Padding(4, 3, 4, 3);
            bigA_in.Name = "bigA_in";
            bigA_in.PlaceholderText = "A";
            bigA_in.Size = new Size(44, 38);
            bigA_in.TabIndex = 8;
            bigA_in.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(142, 83);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 31);
            label4.TabIndex = 9;
            label4.Text = "x +";
            // 
            // bigB_in
            // 
            bigB_in.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigB_in.Location = new Point(193, 81);
            bigB_in.Margin = new Padding(4, 3, 4, 3);
            bigB_in.Name = "bigB_in";
            bigB_in.PlaceholderText = "B";
            bigB_in.Size = new Size(44, 38);
            bigB_in.TabIndex = 10;
            bigB_in.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(244, 83);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 31);
            label5.TabIndex = 11;
            label5.Text = "x +";
            // 
            // c_in
            // 
            c_in.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c_in.Location = new Point(297, 81);
            c_in.Margin = new Padding(4, 3, 4, 3);
            c_in.Name = "c_in";
            c_in.PlaceholderText = "C";
            c_in.Size = new Size(44, 38);
            c_in.TabIndex = 12;
            c_in.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(158, 70);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(20, 22);
            label6.TabIndex = 13;
            label6.Text = "2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(347, 83);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 31);
            label7.TabIndex = 14;
            label7.Text = ") dx";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(60, 81);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(23, 31);
            label8.TabIndex = 15;
            label8.Text = "(";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 346);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(414, 25);
            label2.TabIndex = 16;
            label2.Text = "Интеграл, вычисленный методом парабол";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(435, 346);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(24, 25);
            label9.TabIndex = 17;
            label9.Text = "=";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(435, 302);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(24, 25);
            label10.TabIndex = 18;
            label10.Text = "=";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(13, 207);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(241, 25);
            label11.TabIndex = 19;
            label11.Text = "Округлить результат до";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(302, 207);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(206, 25);
            label12.TabIndex = 20;
            label12.Text = "знака после запятой";
            // 
            // decimal_places_in
            // 
            decimal_places_in.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            decimal_places_in.Location = new Point(250, 198);
            decimal_places_in.Margin = new Padding(4, 3, 4, 3);
            decimal_places_in.Name = "decimal_places_in";
            decimal_places_in.Size = new Size(44, 38);
            decimal_places_in.TabIndex = 21;
            decimal_places_in.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(13, 254);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(356, 25);
            label13.TabIndex = 22;
            label13.Text = "Количество интервалов разбиения n";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(377, 254);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(24, 25);
            label14.TabIndex = 23;
            label14.Text = "=";
            // 
            // n_in
            // 
            n_in.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n_in.Location = new Point(409, 245);
            n_in.Margin = new Padding(4, 3, 4, 3);
            n_in.Name = "n_in";
            n_in.Size = new Size(44, 38);
            n_in.TabIndex = 24;
            n_in.TextAlign = HorizontalAlignment.Center;
            // 
            // Btn_calc
            // 
            Btn_calc.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Btn_calc.Location = new Point(305, 393);
            Btn_calc.Name = "Btn_calc";
            Btn_calc.Size = new Size(203, 33);
            Btn_calc.TabIndex = 25;
            Btn_calc.Text = "Произвести расчёт";
            Btn_calc.UseVisualStyleBackColor = true;
            Btn_calc.Click += Btn_calc_Click;
            // 
            // Btn_save_initial
            // 
            Btn_save_initial.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Btn_save_initial.Location = new Point(442, 23);
            Btn_save_initial.Name = "Btn_save_initial";
            Btn_save_initial.Size = new Size(362, 32);
            Btn_save_initial.TabIndex = 26;
            Btn_save_initial.Text = "Сохранить исходные данные в файл";
            Btn_save_initial.UseVisualStyleBackColor = true;
            Btn_save_initial.Click += Btn_save_initial_Click;
            // 
            // Btn_save_result
            // 
            Btn_save_result.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Btn_save_result.Location = new Point(442, 70);
            Btn_save_result.Name = "Btn_save_result";
            Btn_save_result.Size = new Size(362, 32);
            Btn_save_result.TabIndex = 27;
            Btn_save_result.Text = "Сохранить результат в файл";
            Btn_save_result.UseVisualStyleBackColor = true;
            Btn_save_result.Click += Btn_save_result_Click;
            // 
            // Btn_input_initial
            // 
            Btn_input_initial.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Btn_input_initial.Location = new Point(442, 123);
            Btn_input_initial.Name = "Btn_input_initial";
            Btn_input_initial.Size = new Size(362, 32);
            Btn_input_initial.TabIndex = 28;
            Btn_input_initial.Text = "Ввести исходные данные из файла";
            Btn_input_initial.UseVisualStyleBackColor = true;
            Btn_input_initial.Click += Btn_input_initial_Click;
            // 
            // Work1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 438);
            Controls.Add(Btn_input_initial);
            Controls.Add(Btn_save_result);
            Controls.Add(Btn_save_initial);
            Controls.Add(Btn_calc);
            Controls.Add(n_in);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(decimal_places_in);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(c_in);
            Controls.Add(label5);
            Controls.Add(bigB_in);
            Controls.Add(label4);
            Controls.Add(bigA_in);
            Controls.Add(parabolic_result);
            Controls.Add(trapezoidal_result);
            Controls.Add(b_in);
            Controls.Add(a_in);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Work1";
            Text = "Work1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox a_in;
        private System.Windows.Forms.TextBox b_in;
        private System.Windows.Forms.Label trapezoidal_result;
        private System.Windows.Forms.Label parabolic_result;
        private TextBox bigA_in;
        private Label label4;
        private TextBox bigB_in;
        private Label label5;
        private TextBox c_in;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox decimal_places_in;
        private Label label13;
        private Label label14;
        private TextBox n_in;
        private Button Btn_calc;
        private Button Btn_save_initial;
        private Button Btn_save_result;
        private Button Btn_input_initial;
    }
}