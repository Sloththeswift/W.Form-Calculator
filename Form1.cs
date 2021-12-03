using System;
using System.Windows.Forms;

namespace Form_calc
{
    public partial class Calculator : Form
    {
        private decimal _Buffer = 0;
        private char _Operation = ' ';

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (Calculatorscreen.Text == "0.")
            { Calculatorscreen.Text = button.Text; }
            else
            { Calculatorscreen.Text += button.Text; }
        }

        private void Operatorbtn_Click(object sender, EventArgs e)
        {
            if (_Operation == ' ')
            {
                _Operation = '+';
                _Buffer = decimal.Parse(Calculatorscreen.Text);
                Calculatorscreen.Text = "0.";
            }
            else
            {
                decimal currentValue = decimal.Parse(Calculatorscreen.Text);

                Calculatorscreen.Text = _Operation switch
                {
                    '+' => (_Buffer + currentValue).ToString(),
                    '-' => (_Buffer - currentValue).ToString(),
                    '*' => (_Buffer * currentValue).ToString(),
                    '/' => (_Buffer / currentValue).ToString(),
                    _ => "0."
                };

                _Buffer = 0;
                _Operation = ' ';
            }
        }

        private void resultbtn_Click(object sender, EventArgs e)
        {
            decimal currentValue = decimal.Parse(Calculatorscreen.Text);

            Calculatorscreen.Text = _Operation switch
            {
                '+' => (_Buffer + currentValue).ToString(),
                '-' => (_Buffer - currentValue).ToString(),
                '*' => (_Buffer * currentValue).ToString(),
                '/' => (_Buffer / currentValue).ToString(),
                _ => "0."
            };

            _Buffer = 0;
            _Operation = ' ';
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            if (_Operation == ' ')
            {
                _Operation = '-';
                _Buffer = decimal.Parse(Calculatorscreen.Text);
                Calculatorscreen.Text = "0.";
            }
            else
            {
                decimal currentValue = decimal.Parse(Calculatorscreen.Text);

                Calculatorscreen.Text = _Operation switch
                {
                    '+' => (_Buffer + currentValue).ToString(),
                    '-' => (_Buffer - currentValue).ToString(),
                    '*' => (_Buffer * currentValue).ToString(),
                    '/' => (_Buffer / currentValue).ToString(),
                    _ => "0."
                };

                _Buffer = 0;
                _Operation = ' ';
            }
        }

        private void multiplybtn_Click(object sender, EventArgs e)
        {
            if (_Operation == ' ')
            {
                _Operation = '*';
                _Buffer = decimal.Parse(Calculatorscreen.Text);
                Calculatorscreen.Text = "0.";
            }
            else
            {
                decimal currentValue = decimal.Parse(Calculatorscreen.Text);

                Calculatorscreen.Text = _Operation switch
                {
                    '+' => (_Buffer + currentValue).ToString(),
                    '-' => (_Buffer - currentValue).ToString(),
                    '*' => (_Buffer * currentValue).ToString(),
                    '/' => (_Buffer / currentValue).ToString(),
                    _ => "0."
                };

                _Buffer = 0;
                _Operation = ' ';
            }
        }

        private void dividebtn_Click(object sender, EventArgs e)
        {
            if (_Operation == ' ')
            {
                _Operation = '/';
                _Buffer = decimal.Parse(Calculatorscreen.Text);
                Calculatorscreen.Text = "0.";
            }
            else
            {
                decimal currentValue = decimal.Parse(Calculatorscreen.Text);

                Calculatorscreen.Text = _Operation switch
                {
                    '+' => (_Buffer + currentValue).ToString(),
                    '-' => (_Buffer - currentValue).ToString(),
                    '*' => (_Buffer * currentValue).ToString(),
                    '/' => (_Buffer / currentValue).ToString(),
                    _ => "0."
                };

                _Buffer = 0;
                _Operation = ' ';
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            Calculatorscreen.Clear();
            Calculatorscreen.Text = "0.";
        }
    }
}