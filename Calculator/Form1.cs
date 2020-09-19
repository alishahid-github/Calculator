using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_operand(object sender, EventArgs e)
        {
            Button current_btn = (Button)sender;
            
            if (current_btn.Text == ".")
            {
                if (!(valueTextBox.Text.Contains(".")))
                    valueTextBox.Text += current_btn.Text;
            }
            else
                valueTextBox.Text += current_btn.Text;
        }

        public double first_operand;
        public string C_operator = "\0";
        public bool is_first_operand_find = false;

        private void operator_click(object sender, EventArgs e)
        {
            Button current_btn = (Button)sender;
            C_operator = current_btn.Text;
            if (valueTextBox.Text != "" && is_first_operand_find == false && C_operator != "\0")
            {
                is_first_operand_find = true;
                first_operand = Convert.ToDouble(valueTextBox.Text);
                valueTextBox.Text = "";
            }

            if (valueTextBox.Text != "" && is_first_operand_find)
            {
                perform_calculate();
                first_operand= Convert.ToDouble(resultTextBox.Text);
            }

        }

      

        private void calculate(object sender, EventArgs e)
        {
            if (valueTextBox.Text != "" && is_first_operand_find)
            {
                perform_calculate();
                first_operand = Convert.ToDouble(resultTextBox.Text);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            valueTextBox.Text = "";
            resultTextBox.Text = "";
            is_first_operand_find = false;
            C_operator = "\0";

        }

        private void perform_calculate()
        {
            if (C_operator == "+")
                resultTextBox.Text = Convert.ToString(Convert.ToDecimal(first_operand) + Convert.ToDecimal(valueTextBox.Text));
            else if (C_operator == "-")
                resultTextBox.Text = Convert.ToString(Convert.ToDecimal(first_operand) - Convert.ToDecimal(valueTextBox.Text));
            else if (C_operator == "x")
                resultTextBox.Text = Convert.ToString(Convert.ToDecimal(first_operand) * Convert.ToDecimal(valueTextBox.Text));
            else if (C_operator == "÷")
                resultTextBox.Text = Convert.ToString(Convert.ToDecimal(first_operand) / Convert.ToDecimal(valueTextBox.Text));

            valueTextBox.Text = "";
        }
    }
}
