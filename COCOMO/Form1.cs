using System.Data;
using System.Numerics;

namespace COCOMO
{
    public partial class Form1 : Form
    {
        double a, b, c, d, EAF = 1, Ei, E;


        private Dictionary<string, int> factorsIndex = new Dictionary<string, int>();



        double[,] values = {
            { 0.75, 0.88, 1.00, 1.15, 1.40, 0},
            { 0, 0.94, 1.00, 1.08, 1.16, 0},
            { 0.70, 0.85, 1.00, 1.15, 1.30, 1.65 },
            { 0, 0, 1.00, 1.11, 1.30, 1.66 },
            { 0, 0, 1.00, 1.06, 1.21, 1.56 },
            { 0, 0.87, 1.00, 1.15, 1.30, 0 },
            { 0, 0.87, 1.00, 1.07, 1.15, 0 },
            { 1.46, 1.19, 1.00, 0.86, 0.71, 0 },
            { 1.29, 1.13, 1.00, 0.91, 0.82, 0 },
            { 1.42, 1.17, 1.00, 0.86, 0.70, 0 },
            { 1.21, 1.10, 1.00, 0.90, 0, 0 },
            { 1.14, 1.07, 1.00, 0.95, 0, 0 },
            { 1.24, 1.10, 1.00, 0.91, 0.82, 0 },
            { 1.24, 1.10, 1.00, 0.91, 0.83, 0 },
            { 1.23, 1.08, 1.00, 1.04, 1.10, 0 }

        };


        public Form1()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedTextChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked) //intermediate constant values
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    a = 3.2;
                    b = 1.05;
                    c = 2.5;
                    d = 0.38;

                }
                else if (comboBox1.SelectedIndex == 1)
                {

                    a = 3.0;
                    b = 1.12;
                    c = 2.5;
                    d = 0.35;

                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    a = 2.8;
                    b = 1.20;
                    c = 2.5;
                    d = 0.32;
                }
            }
            else if (radioButton7.Checked) { //Basic constant values



                if (comboBox1.SelectedIndex == 0)
                {
                    a = 2.4;
                    b = 1.05;
                    c = 2.5;
                    d = 0.38;

                }
                else if (comboBox1.SelectedIndex == 1)
                {

                    a = 3.0;
                    b = 1.12;
                    c = 2.5;
                    d = 0.35;

                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    a = 3.6;
                    b = 1.20;
                    c = 2.5;
                    d = 0.32;
                }

            }
        }
    
        private void Init()
        {
            radioButton1.Show();
            radioButton2.Show();
            radioButton3.Show();
            radioButton4.Show();
            radioButton5.Show();
            radioButton6.Show();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;

            comboBox2.Text = "";
            comboBox1.Text = null;

            comboBox2.Items.Clear();
            listView1.Items.Clear();

            foreach (var factor in factorsIndex.Keys)
                comboBox2.Items.Add(factor);

            EAF = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Organic");
            comboBox1.Items.Add("Semi-Detached");
            comboBox1.Items.Add("Embeded");

            ///////////////////////////////////////////////////////////////////////////////////////////
            factorsIndex.Add("Required software reliability", 0);
            factorsIndex.Add("Size of application database", 1);
            factorsIndex.Add("Complexity of the product", 2);
            factorsIndex.Add("Run-time performance constraints", 3);
            factorsIndex.Add("Memory constraints", 4);
            factorsIndex.Add("Volatility of the virtual machine environment", 5);
            factorsIndex.Add("Required turnabout time", 6);
            factorsIndex.Add("Analyst capability", 7);
            factorsIndex.Add("Applications experience", 8);
            factorsIndex.Add("Software engineer capability", 9);
            factorsIndex.Add("Virtual machine experience", 10);
            factorsIndex.Add("Programming language experience", 11);
            factorsIndex.Add("Application of software engineering methods", 12);
            factorsIndex.Add("Use of software tools", 13);
            factorsIndex.Add("Required development schedule", 14);

            ////////////////////////////////////////////////////////////////////////////////////////////
            radioButton7.Checked = true;

            Init();
        }


        private void comboBox2_SelectedTextChanged(object sender, EventArgs e)
        {
            radioButton1.Show();
            radioButton2.Show();
            radioButton3.Show();
            radioButton4.Show();
            radioButton5.Show();
            radioButton6.Show();

            var selectedText = comboBox2.Items[comboBox2.SelectedIndex].ToString();  

            //
            if (values[factorsIndex[selectedText], 0] == 0)
                radioButton1.Hide();
             if (values[factorsIndex[selectedText], 1] == 0) 
                radioButton2.Hide();
             if (values[factorsIndex[selectedText], 2] == 0)
                radioButton3.Hide();
             if (values[factorsIndex[selectedText], 3] == 0)
                radioButton4.Hide();
             if (values[factorsIndex[selectedText], 4] == 0)
                radioButton5.Hide();
             if (values[factorsIndex[selectedText], 5] == 0)
                radioButton6.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var radioButtonValue = "";
            var radioButtonIndex = 0;

            if (radioButton1.Checked)
            {
                radioButtonValue = radioButton1.Text;

            }
            else if (radioButton2.Checked)
            {
                radioButtonValue = radioButton2.Text;
                radioButtonIndex = 1;
            }
            else if (radioButton3.Checked)
            {
                radioButtonIndex = 2;
                radioButtonValue = radioButton3.Text;

            }
            else if (radioButton4.Checked)
            {
                radioButtonIndex = 3;
                radioButtonValue = radioButton4.Text;

            }
            else if (radioButton5.Checked)
            {
                radioButtonIndex = 5;
                radioButtonValue = radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                radioButtonIndex = 6;
                radioButtonValue = radioButton6.Text;
            }
            
            EAF *= values[factorsIndex[comboBox2.Text], radioButtonIndex];
            listView1.Items.Add($"{comboBox2.Text} --{radioButtonValue}");
            comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                if (int.Parse(textBox1.Text) < 50)
                {
                    comboBox1.SelectedIndex = 0;

                }
                else if (int.Parse(textBox1.Text) >= 50 && int.Parse(textBox1.Text) < 300)
                {
                    comboBox1.SelectedIndex = 1;

                }
                else if (int.Parse(textBox1.Text) >= 300)
                {
                    comboBox1.SelectedIndex = 2;

                }
            }
            Ei = a * Math.Pow(int.Parse(textBox1.Text), b);
            MessageBox.Show(Ei.ToString() + " ≈ " + Math.Ceiling(Ei));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                if (int.Parse(textBox1.Text) < 50)
                {
                    comboBox1.SelectedIndex = 0;

                }
                else if (int.Parse(textBox1.Text) >= 50 && int.Parse(textBox1.Text) < 300)
                {
                    comboBox1.SelectedIndex = 1;

                }
                else if (int.Parse(textBox1.Text) >= 300)
                {
                    comboBox1.SelectedIndex = 2;

                }
            }
            var TDEV = 0.00; 
            Ei = a * Math.Pow(int.Parse(textBox1.Text), b);
            E = a * Math.Pow(int.Parse(textBox1.Text), b) * EAF;
            if (radioButton7.Checked) { TDEV = c * Math.Pow(Ei, d); }
            else if (radioButton8.Checked) { TDEV = c * Math.Pow(E, d); }            
            MessageBox.Show(TDEV.ToString() + " ≈ " + Math.Ceiling(TDEV));
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                if (int.Parse(textBox1.Text) < 50)
                {
                    comboBox1.SelectedIndex = 0;

                }
                else if (int.Parse(textBox1.Text) >= 50 && int.Parse(textBox1.Text) < 300)
                {
                    comboBox1.SelectedIndex = 1;

                }
                else if (int.Parse(textBox1.Text) >= 300)
                {
                    comboBox1.SelectedIndex = 2;

                }
            }
            E = a * Math.Pow(int.Parse(textBox1.Text), b) * EAF;
          
            MessageBox.Show(E.ToString() + " ≈ " + Math.Ceiling(E));
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                label2.Hide();
                comboBox2.Hide();
                groupBox1.Hide();
                listView1.Hide();
                button4.Hide();
                button1.Hide();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton8.Checked)
            {
                label2.Show();
                comboBox2.Show();
                groupBox1.Show();
                listView1.Show();
                button4.Show();
                button1.Show();
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}