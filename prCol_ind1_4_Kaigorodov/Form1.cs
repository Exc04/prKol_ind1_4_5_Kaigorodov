using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prCol_ind_4_Kaigorodov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = "Stroki.txt";
            textBox1.Text = file;
            if (!File.Exists(file))
            {
                MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            string[] line = File.ReadAllLines(file);

            if(line.Length < 2)
            {
                MessageBox.Show("В файле должно быть минимум 2 строки");
                return;
            }

            string stroka1 = line[0];
            string stroka2 = line[1];

            textBox2.Text = stroka1;
            textBox3.Text = stroka2;

            bool result = stroka.Revers(stroka1, stroka2);

            if (result)
            {
                MessageBox.Show("Результат: Да, первая строка является обратной второй строке", "Результат", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Результат: Нет, первая строка не является обратной второй строке", "Результат", MessageBoxButtons.OK);
            }
        }
    }
}
