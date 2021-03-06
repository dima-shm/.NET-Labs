﻿using System;
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
    public partial class SearchOnType : Form
    {
        Zoo zoo;
        public SearchOnType(Zoo _zoo)
        {
            InitializeComponent();
            zoo = _zoo;

            animalType.Items.Add("Amphibians");
            animalType.Items.Add("Birds");
            animalType.Items.Add("Fish");
            animalType.Items.Add("Mammals");
            animalType.Items.Add("Reptiles");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (animalType.Items.IndexOf(animalType.Text) < 0)
            {
                MessageBox.Show("Enter data on blank");
            }
            else
            {
                var objects = from Animal item in zoo
                              where item.Type.ToString() == animalType.Text.ToString()
                              select item;

                Result result = new Result(objects);
                result.Show();
                result.ShowResult();
            }              
        }
        public Zoo GetZoo()
        {
            return zoo;
        }
    }
}
