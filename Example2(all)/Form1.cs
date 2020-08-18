using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    /*Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.Компьютер говорит, больше или меньше загаданное число введенного.
        a) Для ввода данных от человека используется элемент TextBox;
        б) **Реализовать отдельную форму c TextBox для ввода числа.*/

    //Фамилия выполяющего - Супрун
    
    public partial class Form1 : Form
    {
        public string text;
        
        
        Random rnd = new Random();
        int botnumber;
        public Form1()
        {
            botnumber = rnd.Next(0, 101);
            InitializeComponent();
        }

        private void btnforcheck_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show(this);
           
                
        }
        public void Check()
        {
            if (Convert.ToInt32(txtBoxNumber.Text) == botnumber) MessageBox.Show("Победа!");
            if (Convert.ToInt32(txtBoxNumber.Text) > botnumber) MessageBox.Show("Ваше число больше");
            if (Convert.ToInt32(txtBoxNumber.Text) < botnumber) MessageBox.Show("Ваше число меньше");
        }
        public void form2end()
        {
            txtBoxNumber.Text = text;
            Check();
        }

        
    }
}
