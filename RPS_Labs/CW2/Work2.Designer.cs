﻿namespace RPS_Labs.CW2 {
    partial class Work2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            Btn_find = new Button();
            label1 = new Label();
            label_result = new Label();
            array_input = new TextBox();
            label2 = new Label();
            Btn_input_initial = new Button();
            Btn_save_result = new Button();
            Btn_save_original = new Button();
            SuspendLayout();
            // 
            // Btn_find
            // 
            Btn_find.Font = new Font("Microsoft Sans Serif", 15F);
            Btn_find.Location = new Point(12, 187);
            Btn_find.Name = "Btn_find";
            Btn_find.Size = new Size(590, 36);
            Btn_find.TabIndex = 0;
            Btn_find.Text = "Найти в массиве значение, встречающееся чаще всего";
            Btn_find.UseVisualStyleBackColor = true;
            Btn_find.Click += Btn_find_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F);
            label1.Location = new Point(14, 233);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 1;
            label1.Text = "Значение = ";
            // 
            // label_result
            // 
            label_result.AutoSize = true;
            label_result.Font = new Font("Microsoft Sans Serif", 15F);
            label_result.Location = new Point(143, 233);
            label_result.Name = "label_result";
            label_result.Size = new Size(27, 25);
            label_result.TabIndex = 2;
            label_result.Text = "...";
            // 
            // array_input
            // 
            array_input.Font = new Font("Microsoft Sans Serif", 14F);
            array_input.Location = new Point(143, 149);
            array_input.Name = "array_input";
            array_input.PlaceholderText = "Вводите значения таким образом: 0;0;0";
            array_input.Size = new Size(433, 29);
            array_input.TabIndex = 3;
            array_input.KeyPress += array_input_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F);
            label2.Location = new Point(12, 151);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 4;
            label2.Text = "Ручной ввод";
            // 
            // Btn_input_initial
            // 
            Btn_input_initial.Font = new Font("Microsoft Sans Serif", 15F);
            Btn_input_initial.Location = new Point(12, 23);
            Btn_input_initial.Name = "Btn_input_initial";
            Btn_input_initial.Size = new Size(262, 36);
            Btn_input_initial.TabIndex = 5;
            Btn_input_initial.Text = "Ввести массив из файла";
            Btn_input_initial.UseVisualStyleBackColor = true;
            Btn_input_initial.Click += Btn_input_initial_Click;
            // 
            // Btn_save_result
            // 
            Btn_save_result.Font = new Font("Microsoft Sans Serif", 15F);
            Btn_save_result.Location = new Point(12, 107);
            Btn_save_result.Name = "Btn_save_result";
            Btn_save_result.Size = new Size(390, 36);
            Btn_save_result.TabIndex = 6;
            Btn_save_result.Text = "Сохранить массив и результат в файл";
            Btn_save_result.UseVisualStyleBackColor = true;
            Btn_save_result.Click += Btn_save_result_Click;
            // 
            // Btn_save_original
            // 
            Btn_save_original.Font = new Font("Microsoft Sans Serif", 15F);
            Btn_save_original.Location = new Point(12, 65);
            Btn_save_original.Name = "Btn_save_original";
            Btn_save_original.Size = new Size(365, 36);
            Btn_save_original.TabIndex = 7;
            Btn_save_original.Text = "Сохранить исходный массив в файл";
            Btn_save_original.UseVisualStyleBackColor = true;
            Btn_save_original.Click += Btn_save_original_Click;
            // 
            // Work2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 267);
            Controls.Add(Btn_save_original);
            Controls.Add(Btn_save_result);
            Controls.Add(Btn_input_initial);
            Controls.Add(label2);
            Controls.Add(array_input);
            Controls.Add(label_result);
            Controls.Add(label1);
            Controls.Add(Btn_find);
            Name = "Work2";
            Text = "Work2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_find;
        private Label label1;
        private Label label_result;
        private TextBox array_input;
        private Label label2;
        private Button Btn_input_initial;
        private Button Btn_save_result;
        private Button Btn_save_original;
    }
}