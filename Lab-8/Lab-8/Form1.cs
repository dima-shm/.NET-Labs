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
    public partial class Form1 : Form
    {
        Animal animal;
        public Zoo zoo;
        int currentRow;
        public Form1()
        {
            InitializeComponent();

            animalType.Items.Add("Amphibians");
            animalType.Items.Add("Birds");
            animalType.Items.Add("Fish");
            animalType.Items.Add("Mammals");
            animalType.Items.Add("Reptiles");

            habitatContinent.Items.Add("Africa");
            habitatContinent.Items.Add("Antarctida");
            habitatContinent.Items.Add("Asia");
            habitatContinent.Items.Add("Australia");
            habitatContinent.Items.Add("Europe");
            habitatContinent.Items.Add("North America");
            habitatContinent.Items.Add("South America");

            animalDateOfReceipt.Format = DateTimePickerFormat.Short;

            animal = new Animal();
            zoo = new Zoo();

            InitFirstRow();
            currentRow = 0;
        }

        private void InitFirstRow()
        {
            for (int x = 0; x < 9; x++)
            {
                DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn();
                Column.Width = 95;
                dataGridView1.Columns.Add(Column);
            }
            dataGridView1.Rows.Add("Name", "Type", "Age", "Record on Red Book", "Date of receipt",
                                    "Habitat continent", "Habitat latitude", "Habitat longitude", "Description");
            currentRow = 1;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!CheckErrors())
            {
                try
                {
                    animal = new Animal();
                    animal.Name = animalName.Text.ToString();
                    animal.Type = animalType.Text.ToString();
                    animal.Age = (int)animalAge.Value;
                    if (animalIsRedBookYes.Checked)
                        animal.IsRcordOnRedBook = true;
                    else
                        animal.IsRcordOnRedBook = false;
                    animal.DateOfReceipt = animalDateOfReceipt.Text.ToString();
                    animal.Habitat = new Habitat();
                    animal.Habitat.Continent = habitatContinent.Text.ToString();
                    animal.Habitat.Latitude = habitatLatitude.Text.ToString();
                    animal.Habitat.Longitude = habitatLongitude.Text.ToString();
                    animal.Description = description.Text.ToString();
                    zoo.Add(animal);
                    zoo.SaveToXML("Animals");
                }
                catch (Exception) { }
            }
        }
        private bool CheckErrors()
        {
            try
            {
                if (animalName.Text == "")
                    error.SetError(animalName, "Enter name");
                else if (animalName.Text.Length < 3)
                    error.SetError(animalName, "Too short the name");
                else
                    error.SetError(animalName, "");

                if (animalType.Items.IndexOf(animalType.Text) < 0)
                    error.SetError(animalType, "Select from list");
                else
                    error.SetError(animalType, "");

                if (animalAge.Value == 0)
                    error.SetError(animalAge, "Enter age");
                else
                    error.SetError(animalAge, "");

                if (!animalIsRedBookYes.Checked && !animalIsRedBookNo.Checked)
                {
                    error.SetError(animalIsRedBookYes, "Select one of the options");
                    error.SetError(animalIsRedBookNo, "Select one of the options");
                }
                else
                {
                    error.SetError(animalIsRedBookYes, "");
                    error.SetError(animalIsRedBookNo, "");
                }

                if (habitatContinent.Items.IndexOf(habitatContinent.Text) < 0)
                    error.SetError(habitatContinent, "Select from list");
                else
                    error.SetError(habitatContinent, "");
            }
            catch (Exception) { }

            if (error.GetError(animalName) != "Enter name" && error.GetError(animalName) != "Too short the name"
                        && error.GetError(animalType) != "Select from list"
                        && error.GetError(animalAge) != "Enter age"
                        && error.GetError(animalIsRedBookYes) != "Select one of the options" && error.GetError(animalIsRedBookNo) != "Select one of the options"
                        && error.GetError(habitatContinent) != "Select from list")
                return false;
            else
                return true;
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML Fiels| *.xml";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;

            zoo.Clear();
            zoo.LoadFromXML(filename);

            for (int i = currentRow; i != 0; i--)
            {
                dataGridView1.Rows.RemoveAt(i);
                currentRow--;
            }
            foreach (Animal item in zoo)
            {
                dataGridView1.Rows.Add();
                currentRow++;
                dataGridView1.Rows[currentRow].Cells[0].Value = item.Name;
                dataGridView1.Rows[currentRow].Cells[1].Value = item.Type;
                dataGridView1.Rows[currentRow].Cells[2].Value = item.Age;
                dataGridView1.Rows[currentRow].Cells[3].Value = item.IsRcordOnRedBook;
                dataGridView1.Rows[currentRow].Cells[4].Value = item.DateOfReceipt;
                dataGridView1.Rows[currentRow].Cells[5].Value = item.Habitat.Continent;
                dataGridView1.Rows[currentRow].Cells[6].Value = item.Habitat.Latitude;
                dataGridView1.Rows[currentRow].Cells[7].Value = item.Habitat.Longitude;
                dataGridView1.Rows[currentRow].Cells[8].Value = item.Description;
            }
        }

        private void searchOnType_Click(object sender, EventArgs e)
        {
            SearchOnType search = new SearchOnType(zoo);
            search.Show();
            zoo = search.GetZoo();
        }
        private void searchOnAge_Click(object sender, EventArgs e)
        {
            SearchOnAge search = new SearchOnAge(zoo);
            search.Show();
            zoo = search.GetZoo();
        }
        private void searchOnContinent_Click(object sender, EventArgs e)
        {
            SearchOnContinent search = new SearchOnContinent(zoo);
            search.Show();
            zoo = search.GetZoo();
        }
        private void SortOnDateOfReceipt_Click(object sender, EventArgs e)
        {
            zoo.Sort((Animal x, Animal y) => String.Compare(x.DateOfReceipt, y.DateOfReceipt));

            Result result = new Result(zoo);
            result.Show();
            result.ShowResultZoo();
            zoo = result.GetZoo();
        }
        private void save_Click(object sender, EventArgs e)
        {
            zoo.SaveToXML("Result");
        }
        private void aboutProgramm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tLab-8\n" + "© Shumanski Dima\n" + "\tv1.01",
                            "About program",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            zoo.Clear();

            for (int i = currentRow; i != 0; i--)
            {
                dataGridView1.Rows.RemoveAt(i);
                currentRow--;
            }
        }
    }
}
