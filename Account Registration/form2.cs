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
    public partial class form2 : Form
    {
        public static form2 instance;

        /* form 1 and form 2 connectiom */
        public Label lab1;
        public Label lab2;
        public Label lab3;
        public Label lab4;
        public Label lab5;
        public Label lab6;
        public Label lab7;
        public Label lab8;
        public form2()
        {
            InitializeComponent();
            instance = this;

            /* Output */
            lab1 = label9;
            lab2 = label10;
            lab3 = label11;
            lab4 = label12;
            lab5 = label13;
            lab6 = label14;
            lab7 = label15;
            lab8 = label16;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
