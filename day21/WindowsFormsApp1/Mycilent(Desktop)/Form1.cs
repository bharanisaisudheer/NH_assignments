using Mycilent_Desktop_.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mycilent_Desktop_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            mathematicsSoapClient m = new mathematicsSoapClient();

            textBox2.Text = m.Factorial(n).ToString();

            Console.ReadLine();
        }
    }
}
