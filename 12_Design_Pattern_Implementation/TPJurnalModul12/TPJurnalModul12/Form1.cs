using System;
using System.Drawing;
using System.Windows.Forms;

namespace tpmodul12_2311104070
{
    public class Form1 : Form // <-- WAJIB mewarisi dari Form
    {
        private TextBox inputBox;
        private Button checkButton;
        private Label outputLabel;

        public Form1()
        {
            this.Text = "TP Modul 12 - Cari Tanda Bilangan";
            this.Size = new Size(400, 200);

            inputBox = new TextBox();
            inputBox.Location = new Point(30, 30);
            inputBox.Width = 200;
            this.Controls.Add(inputBox);

            checkButton = new Button();
            checkButton.Text = "Cek Bilangan";
            checkButton.Location = new Point(250, 30);
            checkButton.Click += new EventHandler(CheckButton_Click);
            this.Controls.Add(checkButton);

            outputLabel = new Label();
            outputLabel.Location = new Point(30, 80);
            outputLabel.Width = 300;
            this.Controls.Add(outputLabel);
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Convert.ToInt32(inputBox.Text);
                string hasil = CariTandaBilangan(input);
                outputLabel.Text = "Hasil: " + hasil;
            }
            catch (FormatException)
            {
                outputLabel.Text = "Input tidak valid!";
            }
        }

        public string CariTandaBilangan(int a)
        {
            if (a < 0) return "Negatif";
            if (a > 0) return "Positif";
            return "Nol";
        }
    }
}
