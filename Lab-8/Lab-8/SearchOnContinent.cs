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
                Result result = null;
                Regex regex = new Regex(animalContinent.Text.ToString(), RegexOptions.IgnoreCase);
                foreach (Animal item in zoo)
                {
                    if (regex.IsMatch(item.Habitat.Continent.ToString()))
                    {
                        var objects = from Animal it in zoo
                                      where it.Habitat.Continent.ToString() == item.Habitat.Continent.ToString()
                                      select it;
                        result = new Result(objects);
                    }
                }
                if (result != null)
                {
                    result.Show();
                    result.ShowResult();
                }
                else
                    MessageBox.Show("No matches where found");
            }
        }
        public Zoo GetZoo()
        {
            return zoo;
        }
    }
}
