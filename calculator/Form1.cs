using System.Net;

namespace calculator
{
    public partial class Form1 : Form
    {
        public string d; // дейсвтие
        public string n1; // первое число
        public bool n2; // флаг начали набирать 2е число
        private double memory;
        public Form1()
        {
            InitializeComponent();
            buttonMC.Enabled = false;
            buttonMR.Enabled = false;
            buttonMplus.Enabled = false;
            buttonMminus.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e) // добавление цифр
        {
            Button b = (Button)sender; // нажатие
            if (n2 == true)
            {
                n2 = false;
                textBox1.Text = "0"; // стираем после нажатие кого-либо действия
            }

            if (textBox1.Text == "0")
                textBox1.Text = b.Text;
            else
                textBox1.Text = textBox1.Text + b.Text;
        }

        private void button17_Click(object sender, EventArgs e) // удаление всех цифр
        {
            textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e) // оперции над числами
        {
            Button b = (Button)sender; // считывание нажатия
            d = b.Text; //  действие
            n1 = textBox1.Text; // набранное число 
            n2 = true;
        }

        private void button23_Click(object sender, EventArgs e) // равно
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(n1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (d == "+")
            {
                res = dn1 + dn2;
            }
            if (d == "-")
            {
                res = dn1 - dn2;
            }
            if (d == "×")
            {
                res = dn1 * dn2;
            }
            if (d == "÷")
            {
                res = dn1 / dn2;
            }
            if (d == "%")
            {
                res = dn1 * dn2 / 100;
            }
            d = "="; // кнопка дейсвтия
            n2 = true; // стереть дисплей
            textBox1.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e) // корень
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e) // квадрат
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn, 2);
            textBox1.Text = res.ToString();
        }

        private void button1_Click(object sender, EventArgs e) // 1\x
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = 1 / dn;
            textBox1.Text = res.ToString();
        }

        private void button24_Click(object sender, EventArgs e) // +-
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button22_Click(object sender, EventArgs e) // ,
        {
            if (!textBox1.Text.Contains(",")) // проверка на запятую
                textBox1.Text = textBox1.Text + ",";
        }

        private void button19_Click(object sender, EventArgs e) //стирание по элементно 
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1); // удаление символа с конца
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonMS_Click(object sender, EventArgs e) // MEMORY SAVE
        {
            memory = Double.Parse(textBox1.Text); // область памяти
            buttonMC.Enabled = true;
            buttonMR.Enabled = true;
            buttonMplus.Enabled = true;
            buttonMminus.Enabled = true;

        }

        private void buttonMR_Click(object sender, EventArgs e) // MEMORY READ
        {
            textBox1.Text = memory.ToString();
        }

        private void buttonMC_Click(object sender, EventArgs e) //MEMORY CLEAR
        {
            textBox1.Text = "0";
            memory = 0;
            buttonMR.Enabled = false;
            buttonMC.Enabled = false;
            buttonMplus.Enabled = false;
            buttonMminus.Enabled = false;
        }

        private void buttonMplus_Click(object sender, EventArgs e) // MEMORY PLUS
        {
            memory += Double.Parse(textBox1.Text);
        }

        private void buttonMminus_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(textBox1.Text);
        }
    }
}