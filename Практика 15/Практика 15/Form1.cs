using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Практика_15
{
    public partial class Form1 : Form
    {
        private ArrayList numbers = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            var count = NumListBox.SelectedItems.Count;
            if (count == 2)
            {
                string result = "";
                string selectedItems = String.Join(";", NumListBox.SelectedItems.Cast<string>().ToArray());
                string[] parts = selectedItems.Split(';');
                double real1 = double.Parse(parts[0]);
                double imaginary1 = double.Parse(parts[1]);
                double real2 = double.Parse(parts[2]);
                double imaginary2 = double.Parse(parts[3]);
                ComplexNumbers number1 = new ComplexNumbers(real1, imaginary1);
                ComplexNumbers number2 = new ComplexNumbers(real2, imaginary2);
                if (comboBoxOperations.SelectedItem == null)
                {
                    MessageBox.Show("Выберите операцию в ComboBox", "Ошибка");
                }
                else
                {
                    string operation = comboBoxOperations.SelectedItem.ToString();
                    switch (operation)
                    {
                        case "Сложение":
                            result = number1.Sum(number2).ToString();
                            MessageBox.Show(result, "Ответ");
                            break;
                        case "Умножение":
                            result = number1.Mul(number2).ToString();
                            MessageBox.Show(result, "Ответ");
                            break;
                        case "Вычитание":
                            result = number1.Dif(number2).ToString();
                            MessageBox.Show(result, "Ответ");
                            break;
                    }
                }

            }
            else
            {
                MessageBox.Show("Выберите два значения", "Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Text Files|*.txt";
                openFileDialog1.ToString();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //string fileName = Path.GetFileName(openFileDialog1.FileName);
                    string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                    if (lines.Length == 0)
                    {
                        MessageBox.Show("Файл пуст", "Ошибка");
                    }
                    else
                    {
                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(';');
                            double real = double.Parse(parts[0]);
                            double imaginary = double.Parse(parts[1].Replace("i", ""));
                            ComplexNumbers number = new ComplexNumbers(real, imaginary);
                            numbers.Add(number);
                        }

                        foreach (ComplexNumbers number in numbers)
                        {
                            NumListBox.Items.Add($"{number.Vaild};{number.Imaginary}");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string result = "";
                double real1 = double.Parse(textBox1.Text);
                double imaginary1 = double.Parse(textBox2.Text);
                double real2 = double.Parse(textBox3.Text);
                double imaginary2 = double.Parse(textBox4.Text);
                ComplexNumbers number1 = new ComplexNumbers(real1, imaginary1);
                ComplexNumbers number2 = new ComplexNumbers(real2, imaginary2);
                if (comboBoxOperations.SelectedItem == null)
                {
                    MessageBox.Show("Выберите операцию в ComboBox", "Ошибка");
                }
                else
                {
                    string operation = comboBoxOperations.SelectedItem.ToString();
                    switch (operation)
                    {
                        case "Сложение":
                            result = number1.Sum(number2).ToString();
                            MessageBox.Show(result, "Ответ");
                            break;
                        case "Умножение":
                            result = number1.Mul(number2).ToString();
                            MessageBox.Show(result, "Ответ");
                            break;
                        case "Вычитание":
                            result = number1.Dif(number2).ToString();
                            MessageBox.Show(result, "Ответ");
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }
    }
}
