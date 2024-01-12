namespace _1.Practical_question
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox2 = new ComboBox();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 21);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter a new word";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(198, 99);
            button1.Name = "button1";
            button1.Size = new Size(149, 34);
            button1.TabIndex = 2;
            button1.Text = "Add word";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 148);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 3;
            label2.Text = "OR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 193);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 4;
            label3.Text = "Select a word:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 257);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(101, 29);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Remove";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(321, 257);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(101, 29);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Remove";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(309, 221);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 193);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 7;
            label4.Text = "Select another word:";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(198, 300);
            button2.Name = "button2";
            button2.Size = new Size(149, 34);
            button2.TabIndex = 10;
            button2.Text = "Concatenate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Location = new Point(21, 376);
            label5.MaximumSize = new Size(600, 40);
            label5.MinimumSize = new Size(500, 40);
            label5.Name = "label5";
            label5.Size = new Size(500, 40);
            label5.TabIndex = 11;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 450);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(radioButton2);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox2;
        private Label label4;
        private Button button2;
        private Label label5;
    }
}