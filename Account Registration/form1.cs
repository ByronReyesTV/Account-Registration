using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class form1 : Form
    {
        public static form1 instance;
        public TextBox tb1;
        public form1()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            form2 form = new form2();
            form.Show();

            /* input */
            form2.instance.lab1.Text = textBox1.Text;
            form2.instance.lab2.Text = comboBox1.Text;
            form2.instance.lab3.Text = textBox2.Text;
            form2.instance.lab4.Text = textBox3.Text;
            form2.instance.lab5.Text = textBox4.Text;
            form2.instance.lab6.Text = textBox5.Text;
            form2.instance.lab7.Text = textBox6.Text;
            form2.instance.lab8.Text = richTextBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* Clear */
            textBox1.Clear();
            comboBox1.ResetText();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            richTextBox1.Clear();
        }
    }
}
