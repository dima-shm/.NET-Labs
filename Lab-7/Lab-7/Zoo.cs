using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Windows.Forms;

namespace Lab_7
{
    class Zoo : IEnumerable
    {
        private List<Animal> listOfAnimal = new List<Animal>();


        public void Add(Animal _animal)
        {
            listOfAnimal.Add(_animal);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return listOfAnimal.GetEnumerator();
        }

        public void SaveToXML()
        {
            try
            {
                int id = 0;

                XDocument xdoc = new XDocument();
                XElement zoo = new XElement("zoo");

                foreach (Animal item in listOfAnimal)
                {
                    XElement animal = new XElement("animal");
                    XAttribute animalAttrib = new XAttribute("id", id);

                    XElement animalName = new XElement("name", listOfAnimal[id].Name);
                    XElement animalType = new XElement("type", listOfAnimal[id].Type);
                    XElement animalAge = new XElement("age", listOfAnimal[id].Age);
                    XElement animalRecordOnRedBook = new XElement("isRecordOnRedBook", listOfAnimal[id].IsRcordOnRedBook);
                    XElement animalDateOfReceipt = new XElement("dateOfReceipt", listOfAnimal[id].DateOfReceipt);

                    animal.Add(animalAttrib);
                    animal.Add(animalName);
                    animal.Add(animalType);
                    animal.Add(animalAge);
                    animal.Add(animalRecordOnRedBook);
                    animal.Add(animalDateOfReceipt);
                    zoo.Add(animal);

                    id++;
                }

                xdoc.Add(zoo);
                xdoc.Save("Animals.xml");
            }
            catch (Exception) { }
        }

        public void LoadFromXML()
        {
            //try
            //{
            //    XDocument xdoc = XDocument.Load("Animals.xml");
            //    foreach (XElement animalElement in xdoc.Element("zoo").Elements("animal"))
            //    {
            //        Animal animal = new Animal();
            //        XElement animalName = animalElement.Element("name");
            //        XElement animalType = animalElement.Element("type");
            //        XElement animalAge = animalElement.Element("age");
            //        XElement animalRecordOnRedBook = animalElement.Element("isRecordOnRedBook");
            //        XElement animalDateOfReceipt = animalElement.Element("dateOfReceipt");

            //        animal.Name = animalName.Value;
            //        animal.Type = animalType.Value;
            //        animal.Age = int.Parse(animalAge.Value);
            //        animal.IsRcordOnRedBook = bool.Parse(animalRecordOnRedBook.Value);
            //        animal.DateOfReceipt = animalDateOfReceipt.Value;

            //        listOfAnimal.Add(animal);

            //        for (int x = 0; x < 9; x++)
            //        {
            //            DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn();
            //            Column.Width = 95;
            //            dataGridView1.Columns.Add(Column);
            //        }
            //        dataGridView1.Rows.Add(animal.Name.ToString(), animal.Type.ToString(), animal.Age.ToString(),
            //        animal.IsRcordOnRedBook.ToString(), animal.DateOfReceipt.ToString(),
            //        animal.Habitat.Continent.ToString(), animal.Habitat.Latitude.ToString(), animal.Habitat.Longitude.ToString(),
            //        animal.Description.ToString());
            //    }
            //}
            //catch (Exception) { }
        }
    }
}
