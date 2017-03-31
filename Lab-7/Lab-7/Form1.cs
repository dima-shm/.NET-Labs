using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            animalType.Items.Add("Птицы");
            animalType.Items.Add("Млекопитающие");
            animalType.Items.Add("Пресмыкающиеся");
            animalType.Items.Add("Земноводные");
            animalType.Items.Add("Рыбы");

            animalDateOfReceipt.Format = DateTimePickerFormat.Short;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
