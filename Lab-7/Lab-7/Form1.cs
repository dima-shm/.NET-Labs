using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Lab_7
{
    public partial class Form1 : Form
    {
        Animal animal;
        Zoo zoo;
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

            for (int x = 0; x < 9; x++)
            {
                DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn();
                Column.Width = 95;
                dataGridView1.Columns.Add(Column);
            }
            dataGridView1.Rows.Add("Name", "Type", "Age", "Record on Red Book", "Date of receipt",
                                    "Habitat continent", "Habitat latitude", "Habitat longitude", "Description");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckErrors())
            {
                try
                {
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
                    SaveToXML();
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
        public void SaveToXML()
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter("Animals.xml", Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();

                writer.WriteStartElement("animal");
                foreach (Animal item in zoo)
                {
                    writer.WriteElementString("name", item.Name.ToString());
                    writer.WriteElementString("type", item.Type.ToString());
                    writer.WriteElementString("age", item.Age.ToString());
                    writer.WriteElementString("IsRcordOnRedBook", item.IsRcordOnRedBook.ToString());
                    writer.WriteElementString("dateOfReceipt", item.DateOfReceipt.ToString());
                    writer.WriteElementString("habitatContinent", item.Habitat.Continent.ToString());
                    writer.WriteElementString("habitatLatitude", item.Habitat.Latitude.ToString());
                    writer.WriteElementString("habitatLongitude", item.Habitat.Longitude.ToString());
                    writer.WriteElementString("description", item.Description.ToString());
                }
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();

                MessageBox.Show("Saved");
            }
            catch (Exception) { }
        }
        private void buttonToRestore_Click(object sender, EventArgs e)
        {
            LoadFromXML();
        }
        public void LoadFromXML()
        {
            try
            {
                animal.Habitat = new Habitat();

                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("Animals.xml");
                XmlElement xRoot = xDoc.DocumentElement; // Получим корневой элемент

                foreach (XmlNode xnode in xRoot)
                {
                    if (xnode.Name == "name")
                        animal.Name = xnode.InnerText;
                    if (xnode.Name == "type")
                        animal.Type = xnode.InnerText;
                    if (xnode.Name == "age")
                        animal.Age = int.Parse(xnode.InnerText);
                    if (xnode.Name == "IsRcordOnRedBook")
                        animal.IsRcordOnRedBook = bool.Parse(xnode.InnerText);
                    if (xnode.Name == "dateOfReceipt")
                        animal.DateOfReceipt = xnode.InnerText;
                    if (xnode.Name == "habitatContinent")
                        animal.Habitat.Continent = xnode.InnerText;
                    if (xnode.Name == "habitatLatitude")
                        animal.Habitat.Latitude = xnode.InnerText;
                    if (xnode.Name == "habitatLongitude")
                        animal.Habitat.Longitude = xnode.InnerText;
                    if (xnode.Name == "description")
                        animal.Description = xnode.InnerText;
                }
                zoo.Add(animal);

                dataGridView1.Rows.Add(animal.Name.ToString(), animal.Type.ToString(), animal.Age.ToString(),
                    animal.IsRcordOnRedBook.ToString(), animal.DateOfReceipt.ToString(),
                    animal.Habitat.Continent.ToString(), animal.Habitat.Latitude.ToString(), animal.Habitat.Longitude.ToString(),
                    animal.Description.ToString());
            }
            catch (Exception) { }
        }
    }
}
