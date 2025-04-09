using System;
using System.Windows.Forms;

namespace JurnalModul3KPL
{
    public partial class Form1 : Form
    {
        private string input = "";
        private double num1 = 0, num2 = 0;
        private char operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input += btn.Text;
            LabelResult.Text = input;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num1 = double.Parse(input);
            operation = btn.Text[0];
            input = "";
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(input);
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
            }

            LabelResult.Text = result.ToString();
            input = result.ToString();
        }
    }
}
