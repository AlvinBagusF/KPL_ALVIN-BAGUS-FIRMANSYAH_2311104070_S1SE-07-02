using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PangkatIterasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse input values from text boxes
                if (double.TryParse(textBox1.Text, out double angka) &&
                    int.TryParse(textBox2.Text, out int pangkat))
                {
                    // Calculate power using PangkatCalculator class
                    double hasil = PangkatCalculator.HitungPangkat(angka, pangkat);

                    // Display the result
                    lblHasil.Text = $"Hasil: {hasil}";
                }
                else
                {
                    lblHasil.Text = "Input tidak valid!";
                }
            }
            catch (Exception ex)
            {
                lblHasil.Text = $"Error: {ex.Message}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            lblHasil.Text = "Hasil";
        }
    }

    // Calculator class for easier unit testing
    public static class PangkatCalculator
    {
        public static double HitungPangkat(double angka, int pangkat)
        {
            // Handle special cases
            if (pangkat == 0)
                return 1;

            if (angka == 0)
                return (pangkat < 0) ? double.PositiveInfinity : 0;

            // Calculate power using iteration
            double hasil = 1;

            // Handle negative exponent
            bool isNegative = false;
            if (pangkat < 0)
            {
                isNegative = true;
                pangkat = Math.Abs(pangkat);
            }

            // Iterative calculation
            for (int i = 0; i < pangkat; i++)
            {
                hasil *= angka;
            }

            // Apply negative exponent if needed
            if (isNegative)
            {
                hasil = 1 / hasil;
            }

            return hasil;
        }
    }
}