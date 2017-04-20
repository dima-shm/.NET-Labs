using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab_8
{
    public partial class SearchOnContinent : Form
    {
        Zoo zoo;
        public SearchOnContinent(Zoo _zoo)
        {
            InitializeComponent();
            zoo = _zoo;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (animalContinent.Text == "")
            {
                MessageBox.Show("Enter continent");
            }
            else
            {
                var objects = from Animal item in zoo
                              where item.Habitat.Continent.ToString() == animalContinent.Text.ToString()
                              select item;

                Result result = new Result(objects);
                result.Show();
                result.ShowResult();
            }  
        }
    }
}
