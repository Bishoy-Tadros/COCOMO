namespace COCOMO
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            button5 = new Button();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(202, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(499, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedTextChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(202, 203);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(499, 33);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedTextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(37, 133);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 2;
            label1.Text = "Project type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 203);
            label2.Name = "label2";
            label2.Size = new Size(147, 32);
            label2.TabIndex = 3;
            label2.Text = "Cost driver:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(31, 68);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(129, 36);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Very low";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(31, 127);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 36);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Low";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(31, 190);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(130, 36);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Nominal";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(31, 246);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(90, 36);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "High";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(31, 309);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(143, 36);
            radioButton5.TabIndex = 9;
            radioButton5.TabStop = true;
            radioButton5.Text = "Very High";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(31, 373);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(148, 36);
            radioButton6.TabIndex = 10;
            radioButton6.TabStop = true;
            radioButton6.Text = "Extra High";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(342, 487);
            button1.Name = "button1";
            button1.Size = new Size(242, 86);
            button1.TabIndex = 12;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(904, 622);
            button2.Name = "button2";
            button2.Size = new Size(185, 86);
            button2.TabIndex = 14;
            button2.Text = "Calculate Effort";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Indigo;
            groupBox1.Location = new Point(37, 274);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 467);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rating:";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1115, 622);
            button3.Name = "button3";
            button3.Size = new Size(193, 86);
            button3.TabIndex = 16;
            button3.Text = "Calculate TDEV";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGreen;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(698, 622);
            button4.Name = "button4";
            button4.Size = new Size(188, 86);
            button4.TabIndex = 17;
            button4.Text = "Calculate Actual Effort";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(376, 305);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 58);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(128, 64, 64);
            label3.Location = new Point(261, 316);
            label3.Name = "label3";
            label3.Size = new Size(109, 41);
            label3.TabIndex = 19;
            label3.Text = "KLOC :";
            label3.Click += label3_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Red;
            button5.Location = new Point(342, 615);
            button5.Name = "button5";
            button5.Size = new Size(242, 86);
            button5.TabIndex = 20;
            button5.Text = "RESET";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("Imprint MT Shadow", 15F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton7.ForeColor = Color.ForestGreen;
            radioButton7.Location = new Point(34, 48);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(206, 39);
            radioButton7.TabIndex = 11;
            radioButton7.TabStop = true;
            radioButton7.Text = "Basic Model";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Font = new Font("Imprint MT Shadow", 15F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton8.ForeColor = Color.ForestGreen;
            radioButton8.Location = new Point(316, 48);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(310, 39);
            radioButton8.TabIndex = 21;
            radioButton8.TabStop = true;
            radioButton8.Text = "Intermediate Model";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += radioButton8_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Green;
            groupBox2.Location = new Point(37, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(664, 104);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Model";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // listView1
            // 
            listView1.Location = new Point(766, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(542, 551);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 773);
            Controls.Add(groupBox2);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label3;
        private Button button5;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private GroupBox groupBox2;
        private ListView listView1;
    }
}