using System;
using System.Windows.Forms;

namespace Calculater
{
    public partial class ttlCalculator : Form
    {
        
        private int num1 = 0;
        private int num2 = 0;
        private int result = 0;

        public ttlCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int result = 0;

            lblResult.Text = result.ToString();

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum1.Text, out int parsedValue))
            {
                num1 = parsedValue;
            }
            else
            {
                num1 = 0; 
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum2.Text, out int parsedValue))
            {
                num2 = parsedValue;
            }
            else
            {
                num2 = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = num1 + num2;
            lblResult.Text = result.ToString();
        }

        private void bunMinus_Click(object sender, EventArgs e)
        {
            int result = num1 - num2;
            lblResult.Text = result.ToString();
        }

        private void bunKakeru_Click(object sender, EventArgs e)
        {
            int result = num1 * num2;
            lblResult.Text = result.ToString();
        }

        private void btnWaru_Click(object sender, EventArgs e)
        {
            int result = num1 / num2;
            lblResult.Text = result.ToString();
        }
    }
}
