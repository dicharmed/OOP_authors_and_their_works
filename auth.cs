using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KP
{
    public partial class auth : Form
    {
        string login = "admin";
        string psw = "12345";

        public auth()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //CANCEL
        {
            textBox1.Text = "";
            textBox2.Text = "";

            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login == textBox1.Text && psw == textBox2.Text)
            {
                AdminForm admn = new AdminForm();
                admn.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");

                textBox1.Text = "";
                textBox2.Text = "";
            };
        }
    }
}
