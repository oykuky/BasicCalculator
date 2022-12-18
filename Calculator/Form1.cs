using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private char _operation;
        private bool _screenBeCleared;
        private double _firstNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_screenBeCleared == true)
            {
                screenLabel.Text = "";
                _screenBeCleared = false;
            }
            if (screenLabel.Text == "0")
                screenLabel.Text = "";
            screenLabel.Text += "1";
        }

        private void N2Button_Click(object sender, EventArgs e)
        {
            if (_screenBeCleared == true)
            {
                screenLabel.Text = "";
                _screenBeCleared = false;
            }
            if (screenLabel.Text == "0")
                screenLabel.Text = "";
            screenLabel.Text += "2";
        }

        private void N3Button_Click(object sender, EventArgs e)
        {
            if (_screenBeCleared == true)
            {
                screenLabel.Text = "";
                _screenBeCleared = false;
            }
            if (screenLabel.Text == "0")
                screenLabel.Text = "";
            screenLabel.Text += "3";
        }

        private void N4Button_Click(object sender, EventArgs e)
        {
            if (_screenBeCleared == true)
            {
                screenLabel.Text = "";
                _screenBeCleared = false;
            }
            if (screenLabel.Text == "0")
                screenLabel.Text = "";
            screenLabel.Text += "4";
        }

        private void N5Button_Click(object sender, EventArgs e)
        {
            if (_screenBeCleared == true)
            {
                screenLabel.Text = "";
                _screenBeCleared = false;
            }
            if (screenLabel.Text == "0")
                screenLabel.Text = "";
            screenLabel.Text += "5";
        }

        private void N6Button_Click(object sender, EventArgs e)
        {
            if (_screenBeCleared == true)
            {
                screenLabel.Text = "";
                _screenBeCleared = false;
            }
            if (screenLabel.Text == "0")
                screenLabel.Text = "";
            screenLabel.Text += "6";
        }

        private void N7Button_Click(object sender, EventArgs e)
        {
            if (_screenBeCleared == true)
            {
                screenLabel.Text = "";
                _screenBeCleared = false;
            }
            if (screenLabel.Text == "0")
                screenLabel.Text = "";
            screenLabel.Text += "7";
        }

        private void N8Button_Click(object sender, EventArgs e)
        {
            if (_screenBeCleared == true)
            {
                screenLabel.Text = "";
                _screenBeCleared = false;
            }
            if (screenLabel.Text == "0")
                screenLabel.Text = "";
            screenLabel.Text += "8";
        }

        private void N9Button_Click(object sender, EventArgs e)
        {
            if (_screenBeCleared == true)
            {
                screenLabel.Text = "";
                _screenBeCleared = false;
            }
            if (screenLabel.Text == "0")
                screenLabel.Text = "";
            screenLabel.Text += "9";
        }

        private void N0Button_Click(object sender, EventArgs e)
        {
            if (_screenBeCleared == true)
            {
                screenLabel.Text = "";
                _screenBeCleared = false;
            }

            if (screenLabel.Text == "0")
                screenLabel.Text = "";
            screenLabel.Text += "0";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            _operation = '+';
            _screenBeCleared = true;
            _firstNum = Convert.ToDouble(screenLabel.Text);

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            _operation = '-';
            _screenBeCleared = true;
            _firstNum = Convert.ToDouble(screenLabel.Text);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            _operation = '*';
            _screenBeCleared = true;
            _firstNum = Convert.ToDouble(screenLabel.Text);
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            _operation = '/';
            _screenBeCleared = true;
            _firstNum = Convert.ToDouble(screenLabel.Text);
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            screenLabel.Text = "0";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            double secNum = Convert.ToDouble(screenLabel.Text);
            double result = 0;

            switch (_operation)
            {
                case '+':
                    result = _firstNum + secNum;
                    result = Convert.ToDouble(result);
                    break;
                case '-':
                    result = _firstNum - secNum;
                    break;
                case '*':
                    result = _firstNum * secNum;
                    break;
                case '/':
                    if (secNum == 0)
                    {
                        screenLabel.Text = "Cannot divide by zero";

                    }
                    result = _firstNum / secNum;
                    break;
            }
                screenLabel.Text = Convert.ToString(result);
        }

    }
}
