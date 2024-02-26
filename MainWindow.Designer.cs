using System;

namespace RPS_Labs
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Btn_lab1 = new Button();
            Btn_lab2 = new Button();
            Btn_lab3 = new Button();
            Btn_lab4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // Btn_lab1
            // 
            Btn_lab1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_lab1.Location = new Point(187, 466);
            Btn_lab1.Name = "Btn_lab1";
            Btn_lab1.Size = new Size(80, 68);
            Btn_lab1.TabIndex = 0;
            Btn_lab1.Text = "1";
            Btn_lab1.UseVisualStyleBackColor = true;
            Btn_lab1.Click += Btn_lab1_Click;
            // 
            // Btn_lab2
            // 
            Btn_lab2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_lab2.Location = new Point(308, 466);
            Btn_lab2.Name = "Btn_lab2";
            Btn_lab2.Size = new Size(80, 68);
            Btn_lab2.TabIndex = 1;
            Btn_lab2.Text = "2";
            Btn_lab2.UseVisualStyleBackColor = true;
            Btn_lab2.Click += Btn_lab2_Click;
            // 
            // Btn_lab3
            // 
            Btn_lab3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_lab3.Location = new Point(425, 466);
            Btn_lab3.Name = "Btn_lab3";
            Btn_lab3.Size = new Size(80, 68);
            Btn_lab3.TabIndex = 2;
            Btn_lab3.Text = "3";
            Btn_lab3.UseVisualStyleBackColor = true;
            Btn_lab3.Click += Btn_lab3_Click;
            // 
            // Btn_lab4
            // 
            Btn_lab4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_lab4.Location = new Point(545, 466);
            Btn_lab4.Name = "Btn_lab4";
            Btn_lab4.Size = new Size(80, 68);
            Btn_lab4.TabIndex = 3;
            Btn_lab4.Text = "4";
            Btn_lab4.UseVisualStyleBackColor = true;
            Btn_lab4.Click += Btn_lab4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(542, 571);
            label1.Name = "label1";
            label1.Size = new Size(246, 25);
            label1.TabIndex = 4;
            label1.Text = "Семенков Даниил Ильич";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 21);
            label2.Name = "label2";
            label2.Size = new Size(617, 31);
            label2.TabIndex = 5;
            label2.Text = "Разработка программных систем. Работы №1-4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(566, 596);
            label3.Name = "label3";
            label3.Size = new Size(222, 25);
            label3.TabIndex = 8;
            label3.Text = "425 группа, 19 вариант";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 70);
            label4.Name = "label4";
            label4.Size = new Size(623, 40);
            label4.TabIndex = 16;
            label4.Text = "Работа №1. Алгоритмы и структуры данных.\r\nВычислить интеграл заданной функции методом трапеций и методом парабол.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 128);
            label5.Name = "label5";
            label5.Size = new Size(641, 40);
            label5.TabIndex = 17;
            label5.Text = "Работа №2. Процесс проектирования.\r\nНапиcать программу, находящую в массиве значение, встречающееся чаще всего.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 184);
            label6.Name = "label6";
            label6.Size = new Size(532, 80);
            label6.TabIndex = 18;
            label6.Text = "Работа №3. Методология программирования.\r\nНаписать приложение с использованием технологии WinForms для\r\nпостроения графика функции и вывода таблицы значений функции.\r\nСинусоида y = a + bsin(cx + d).";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(35, 275);
            label7.Name = "label7";
            label7.Size = new Size(695, 160);
            label7.TabIndex = 19;
            label7.Text = resources.GetString("label7.Text");
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(811, 648);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_lab4);
            Controls.Add(Btn_lab3);
            Controls.Add(Btn_lab2);
            Controls.Add(Btn_lab1);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RPS_Labs 1-4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Btn_lab1;
        private System.Windows.Forms.Button Btn_lab2;
        private System.Windows.Forms.Button Btn_lab3;
        private System.Windows.Forms.Button Btn_lab4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

