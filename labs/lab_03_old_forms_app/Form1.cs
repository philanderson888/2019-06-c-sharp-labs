using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_03_old_forms_app
{
    public partial class Form1 : Form
    {
        static int counter = 0;

        public Form1()
        {
            InitializeComponent();
            Initialise();

        }

        void Initialise()
        {
            label1.Text = "Welcome - What Is Your Name ? ";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hi " + textBox1.Text;
            counter++;
            label2.Text = counter.ToString();
        }
    }
}
