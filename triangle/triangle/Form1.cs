using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace triangle
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;

            if (!double.TryParse(textBox1.Text, out a) || a <= 0 ||
                !double.TryParse(textBox2.Text, out b) || b <= 0 ||
                !double.TryParse(textBox3.Text, out c) || c <= 0)
            {
                label8.Text = "Ошибка: Введите корректные положительные числа.";
                return;
            }

            // Проверка выбранного CheckBox и выполнение соответствующего блока кода
            if (checkBox1.Checked)
            {
                // Проверка условий неравенства треугольника
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    label8.Text = "Ошибка: Эти длины сторон не образуют треугольник.";
                    return;
                }

                string triangleType;
                if (a == b && b == c)
                    triangleType = "Равносторонний треугольник";
                else if (a == b || a == c || b == c)
                    triangleType = "Равнобедренный треугольник";
                else
                    triangleType = "Разносторонний треугольник";

                // Расчет площади треугольника по формуле Герона
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                // Вывод результатов
                label8.Text = "Тип треугольника: " + triangleType + "\nПлощадь треугольника: " + area;
            }
            else if (checkBox2.Checked)
            {
                // Проверка условий неравенства треугольника
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    label8.Text = "Ошибка: Эти длины сторон не образуют треугольник.";
                    return;
                }

                // Определение типа треугольника
                string triangleType;
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    triangleType = "Прямоугольный треугольник";
                else if (a * a + b * b < c * c || a * a + c * c < b * b || b * b + c * c < a * a)
                    triangleType = "Тупоугольный треугольник";
                else
                    triangleType = "Остроугольный треугольник";

                // Расчет площади треугольника по формуле Герона
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                // Вывод результатов
                label8.Text = "Тип треугольника: " + triangleType + "\nПлощадь треугольника: " + area;
            }
            else
            {
                label8.Text = "Выберите тип треугольника.";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
