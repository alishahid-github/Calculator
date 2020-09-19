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
        public string C_operator="\0";
        public double second_operand;
        public bool is_first_find=false;
    }
}
