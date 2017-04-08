using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Zoo : IEnumerable
    {
        private List<Animal> listOfAnimal;

        public Zoo()
        {
            listOfAnimal = new List<Animal>();
        }

        public void Add(Animal plane)
        {
            listOfAnimal.Add(plane);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return listOfAnimal.GetEnumerator();
        }
    }
}
