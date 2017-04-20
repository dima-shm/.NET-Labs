using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class SearchOnAge : Form
    {
        Zoo zoo;
        public SearchOnAge(Zoo _zoo)
        {
            InitializeComponent();
            zoo = _zoo;
            label1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (animalAge.Value == 0)
            {
                MessageBox.Show("Enter animal age");
            }
            else
            {
                var objects = from Animal item in zoo
                              where item.Age.ToString() == animalAge.Value.ToString()
                              select item;

                Result result = new Result(objects);
                result.Show();
                result.ShowResult();
            }  
        }

        private void animalAge_Scroll(object sender, EventArgs e)
        {
            label1.Text = animalAge.Value.ToString();
        }
    }
}
