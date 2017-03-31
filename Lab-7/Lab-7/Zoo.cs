using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Zoo : IEnumerable
    {
        private List<Animal> animal;

        public Zoo()
        {
            animal = new List<Animal>();
        }

        public void Add(Animal plane)
        {
            animal.Add(plane);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return animal.GetEnumerator();
        }
    }
}
