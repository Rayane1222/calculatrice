using System;
using System.Data.SQLite;
using System.IO;

namespace calculatrice
{


    public partial class Form1 : Form
    {

        private void calcul()
        {



            switch (signe)
            {
                case "+":
                    result = contenuTextBox1 + contenuTextBox2;
                    break;
                case "-":
                    result = contenuTextBox1 - contenuTextBox2;
                    break;
                case "*":
                    result = contenuTextBox1 * contenuTextBox2;
                    break;
                case "/":
                    result = contenuTextBox1 / contenuTextBox2;
                    break;
            }

            string connectionString = "Data Source=C:\\Users\\Setup Game\\source\\repos\\calculatrice\\calculatrice\\mydatabase.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Calculations (op1, op2, operateur, RES) " +
                               "VALUES (@op1, @op2, @operateur, @RES)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@op1", contenuTextBox1);
                    _ = command.Parameters.AddWithValue("@op2", contenuTextBox2);
                    command.Parameters.AddWithValue("@operateur", signe);
                    command.Parameters.AddWithValue("@RES", result);


                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            textBox1.Text = result.ToString(); ;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculationsForm calculationsForm = new CalculationsForm();
            calculationsForm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonvirgule_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button_efface_dernier_caractére_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void buttoneffacetout_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";

        }

        private void buttonPlus_Click_Click(object sender, EventArgs e)
        {
            contenuTextBox1 = int.Parse(textBox1.Text);
            signe = "+";
            textBox1.Clear();
        }

        private void buttonEquals_Click_Click(object sender, EventArgs e)
        {
            contenuTextBox2 = int.Parse(textBox1.Text);
            textBox1.Clear();
            calcul();

        }

        private void button_sustraction_Click(object sender, EventArgs e)
        {
            contenuTextBox1 = int.Parse(textBox1.Text);
            signe = "-";
            textBox1.Clear();
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            contenuTextBox1 = int.Parse(textBox1.Text);
            signe = "*";
            textBox1.Clear();
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            contenuTextBox1 = int.Parse(textBox1.Text);
            signe = "/";
            textBox1.Clear();
        }
    }
}