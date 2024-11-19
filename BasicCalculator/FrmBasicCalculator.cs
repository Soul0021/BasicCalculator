using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorPrivateAssembly;

using System.Windows.Forms;

namespace BasicCalculator
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (txtNum1.Text == "0")
            {
                txtNum1.Clear(); 
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse input numbers
                float num1 = float.Parse(txtNum1.Text);
                float num2 = float.Parse(txtNum2.Text);
                float result = 0;

                // Determine the operation
                switch (cmbOperation.SelectedItem.ToString())
                {
                    case "+":
                        result = BasicComputation.Add(num1, num2);
                        break;
                    case "-":
                        result = BasicComputation.Subtract(num1, num2);
                        break;
                    case "*":
                        result = BasicComputation.Multiply(num1, num2);
                        break;
                    case "/":
                        result = BasicComputation.Divide(num1, num2);
                        break;
                }

                // Display the result
                lblTotal.Text = result.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            // Check if the text in the TextBox is just "0"
            if (txtNum1.Text == "0")
            {
                txtNum1.Clear(); // Clear the TextBox when it only contains "0"
            }
        }
        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            // Check if the text in the TextBox is just "0"
            if (txtNum2.Text == "0")
            {
                txtNum2.Clear(); // Clear the TextBox when it only contains "0"
            }
        }
    }
}
