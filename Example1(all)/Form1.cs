using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    /*а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
    в) Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.*/

    //Фамилия выполняющего - Супрун
    public partial class Form1 : Form
    {

        public Stack<int> st = new Stack<int>();
        public bool bc = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            bc = false;
            st.Push(int.Parse(lblNumber.Text) + 1);
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblCountCommand.Text = (int.Parse(lblCountCommand.Text) + 1).ToString();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            bc = false;
            st.Push(int.Parse(lblNumber.Text) * 2);
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblCountCommand.Text = (int.Parse(lblCountCommand.Text) + 1).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblCountCommand.Text = (int.Parse(lblCountCommand.Text) + 1).ToString();
        }

        private void btnCommandPlay_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            lblCountCommand.Text = "0";
            Random rnd = new Random();
            lblGameText.Visible = true;
            lblCountNumberPlay.Visible = true;
            btnBack.Visible = true;
            lblCountNumberPlay.Text = (rnd.Next(0, 101)).ToString();

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (bc == false)
            {
                int a = st.Pop();
                bc = true;
            }
            lblNumber.Text = st.Pop().ToString();
        }


    }
}
