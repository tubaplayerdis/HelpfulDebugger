using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpful_debuger;

namespace Helpful_debugger
{
    public partial class CalculatorForm : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        string cashe = "";
        bool isOperationPerformed = false;
        Functions funcs = new Functions();
        Calculator calcs = new Calculator();
        
        public CalculatorForm()
        {
            InitializeComponent();
            funcs.AddToOutputCashe("CalculatorForm.cs has started");
            
        }

        private void button_click(object sender, EventArgs e)
        {
            Button buttont = (Button)sender;
            funcs.AddToOutputCashe(sender.ToString());
            cashe += buttont.Text + " ";
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;

            }
            else
                textBox_Result.Text = textBox_Result.Text + button.Text;


        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button15.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
                cashe += button.Text + " ";
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
                cashe += button.Text + " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    calcs.WriteToCashe($"{cashe} = {textBox_Result.Text}");
                    cashe = "";
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    calcs.WriteToCashe($"{cashe} = {textBox_Result.Text}");
                    cashe = "";
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    calcs.WriteToCashe($"{cashe} = {textBox_Result.Text}");
                    cashe = "";
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    calcs.WriteToCashe($"{cashe} = {textBox_Result.Text}");
                    cashe = "";
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            funcs.AddToOutputCashe("Calculator was closed");
            this.Close();
            
        }
    }
}
