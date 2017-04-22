using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Lab_8
{
    public delegate int Comparator(Animal x, Animal y);

    public class Zoo : IEnumerable
    {
        private List<Animal> listOfAnimal = new List<Animal>();


        public void Add(Animal _animal)
        {
            listOfAnimal.Add(_animal);
        }
        public void Clear()
        {
            listOfAnimal.Clear();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return listOfAnimal.GetEnumerator();
        }


        public void SaveToXML(string nameFile)
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
                    XElement habitatContinent = new XElement("habitatContinent", listOfAnimal[id].Habitat.Continent);
                    XElement habitatLatitude = new XElement("habitatLatitude", listOfAnimal[id].Habitat.Latitude);
                    XElement habitatLongitude = new XElement("habitatLongitude", listOfAnimal[id].Habitat.Longitude);
                    XElement description = new XElement("description", listOfAnimal[id].Description);

                    animal.Add(animalAttrib);
                    animal.Add(animalName);
                    animal.Add(animalType);
                    animal.Add(animalAge);
                    animal.Add(animalRecordOnRedBook);
                    animal.Add(animalDateOfReceipt);
                    animal.Add(habitatContinent);
                    animal.Add(habitatLatitude);
                    animal.Add(habitatLongitude);
                    animal.Add(description);
                    zoo.Add(animal);

                    id++;
                }

                xdoc.Add(zoo);
                xdoc.Save(nameFile + ".xml");
            }
            catch (Exception) { }
        }
        public void LoadFromXML(string filename)
        {
            try
            {
                XDocument xdoc = XDocument.Load(filename);
                foreach (XElement animalElement in xdoc.Element("zoo").Elements("animal"))
                {
                    Animal animal = new Animal();
                    animal.Habitat = new Habitat();
                    XElement animalName = animalElement.Element("name");
                    XElement animalType = animalElement.Element("type");
                    XElement animalAge = animalElement.Element("age");
                    XElement animalRecordOnRedBook = animalElement.Element("isRecordOnRedBook");
                    XElement animalDateOfReceipt = animalElement.Element("dateOfReceipt");
                    XElement habitatContinent = animalElement.Element("habitatContinent");
                    XElement habitatLatitude = animalElement.Element("habitatLatitude");
                    XElement habitatLongitude = animalElement.Element("habitatLongitude");
                    XElement description = animalElement.Element("description");

                    animal.Name = animalName.Value;
                    animal.Type = animalType.Value;
                    animal.Age = int.Parse(animalAge.Value);
                    animal.IsRcordOnRedBook = bool.Parse(animalRecordOnRedBook.Value);
                    animal.DateOfReceipt = animalDateOfReceipt.Value;
                    animal.Habitat.Continent = habitatContinent.Value;
                    animal.Habitat.Latitude = habitatLatitude.Value;
                    animal.Habitat.Longitude = habitatLongitude.Value;
                    animal.Description = description.Value;

                    Add(animal);
                }
            }
            catch (Exception) { }
        }

        public void Sort(Comparator func)
        {
            Animal tmp;
            for (int i = 0; i < listOfAnimal.Count; i++)
                for (int j = 0; j < listOfAnimal.Count - 1 - i; j++)
                    if (func(listOfAnimal[j], listOfAnimal[j + 1]) > 0)
                    {
                        tmp = listOfAnimal[j];
                        listOfAnimal[j] = listOfAnimal[j + 1];
                        listOfAnimal[j + 1] = tmp;
                    }
        }
    }
}
