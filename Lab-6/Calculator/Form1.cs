using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string a, b;
            try
            {
                a = Convert.ToString(textBox1.Text);
                b = Convert.ToString(textBox2.Text);
                label1.Text = (Compare(a, b));
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода");
            }
        }

        private string Compare(string _a, string _b)
        {
            if (_a.Length == _b.Length)
            {
                if (String.Compare(_a, _b) == 0)
                    return "=";
                if (String.Compare(_a, _b) < 0)
                    return "<";
                else
                    return ">";
            }
            else
            {
                    return "!=";
            }
            
        }
    }
}
