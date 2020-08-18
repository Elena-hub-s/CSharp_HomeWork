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
    public partial class Form2 : Form
    {

        Form1 f1 = new Form1();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnfrm2Go_Click(object sender, EventArgs e)
        {
            f1.text = txtBoxForm2.Text.ToString();
            f1.form2end();
            this.Close();
        }
    }
}
