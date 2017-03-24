using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collection
{
    public partial class Form1 : Form
    {
        CollectionType<int> list;
        Random rand;

        public Form1()
        {
            InitializeComponent();
            list = new CollectionType<int>();
            rand = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = "";

                for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                {
                    list.Add(rand.Next(1, 50));
                    richTextBox1.Text += list[i].ToString() + "\r\n";
                }
            }
            catch (Exception) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Text = "";

                list.Sort((int x, int y) => x > y);

                for (int i = 0; i < list.Count(); i++)
                {
                    richTextBox2.Text += list[i].ToString() + "\r\n";
                }
            }
            catch (Exception) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Text = "";

                list.Sort((int x, int y) => x < y);

                for (int i = 0; i < list.Count(); i++)
                {
                    richTextBox2.Text += list[i].ToString() + "\r\n";
                }
            }
            catch (Exception) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "";

            var ObjectsContainingValue = from int item in list
                                         where item == Convert.ToInt32(textBox2.Text)
                                         select item;

            richTextBox3.Text = ObjectsContainingValue.Count().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "";

            var Value = from int item in list
                        where item != list[0]
                        where item != list[1]
                        where item != list[2]
                        select item;

            foreach (int item in Value)
            {
                richTextBox3.Text += item.ToString() + "\r\n";
            }
        }
    }
}
