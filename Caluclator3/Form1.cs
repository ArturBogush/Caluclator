namespace Caluclator3
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        private double operand1;
        private double operand2;
        private double memoryValue = 0.0; 

        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);

            res = Math.Pow(dn,2);

            textBox1.Text = res.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дiйсно бажаєте закрити програму?", "Пiдтвердження", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
           {
                double result = 0;
                if (D == "%")
                {
                    result = (operand1 * operand2) / 100;
                }

                else

                {
                    result = 0;
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
                Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text=textBox1.Text + B.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            double operand1, operand2, result;
            result = 0;
            operand1 = Convert.ToDouble(N1);
            if (double.TryParse(textBox1.Text, out operand2))
            {
                if (D == "+")
                {
                    result = operand1 + operand2;
                }
                else if (D == "-")
                {
                    result = operand1 - operand2;
                }

                else if (D == "*")
                {
                    result = operand1 * operand2;
                }
                else if (D == ":")
                {
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                    }
                    else
                    {
                        textBox1.Text = "Помилка: Дiлення на нуль";
                        return;
                    }

                }
                D = "=";
                N1 = result.ToString();
                n2 = true;
                textBox1.Text = N1;
            }
            else
            {
                textBox1.Text = "Помилка: Некоректнi данi";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            
            res = Math.Sqrt(dn);
            
            textBox1.Text = res.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);

            if (dn != 0)
            {
                res = 1 / dn;
                textBox1.Text = res.ToString();
            }
            else
            {
                textBox1.Text = "Помилка: Дiлення на нуль";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);

            res = -dn;

            textBox1.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void ButtonMPlus_click(object sender, EventArgs e)
        {
            double currentValue;
            if (double.TryParse(textBox1.Text, out currentValue))
            {
                memoryValue += currentValue; 
            }
        }

        private void ButtonMMinus_Click(object sender, EventArgs e)
        {
            {
                double currentValue;
                if (double.TryParse(textBox1.Text, out currentValue))
                {
                    memoryValue -= currentValue; 
                }
            }
        }

        private void ButtonMStore_Click(object sender, EventArgs e)
        {
            double currentValue;
            if (double.TryParse(textBox1.Text, out currentValue))
            {
                memoryValue = currentValue; 
            }
        }

        private void ButoonMRecall_Click(object sender, EventArgs e)
        {
            textBox1.Text = memoryValue.ToString();
        }

        private void ButtonMClear_Click(object sender, EventArgs e)
        {
            memoryValue = 0.0;
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {

        }
    }
       
}


       