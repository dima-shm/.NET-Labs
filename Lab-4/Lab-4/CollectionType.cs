using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//найти количество объектов, содержащих заданное значение, 
//получите все объекты из массива за исключением первых 3-х

namespace Lab_4
{
    class CollectionType<T> : IEnumerable
                            where T : new()
    {
        private SortedSet<T> set;


        public CollectionType()
        {
            set = new SortedSet<T>();
        }
        public void Add(T value)
        {
            set.Add(value);
        }
        public void Clear()
        {
            set.Clear();
        }
        public bool Contains(T value)
        {
            return set.Contains(value);
        }
        public void Remove(T value)
        {
            set.Remove(value);
        }
        public int Count()
        {
            return set.Count();
        }
        public void Print()
        {
            foreach (T item in set)
            {
                Console.WriteLine(item);
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return set.GetEnumerator();
        }


        public T this[int index]
        {
            get
            {
                return set.ElementAt<T>(index);
            }
        }


        public void WriteToFile()
        {
            foreach (T item in set)
            {
                File.AppendAllText("collection.txt", "Height: " + item.ToString() + " Radius: " + item.ToString() + "\r\n");
            }
            File.AppendAllText("collection.txt", new String('-', 85));
        }
    }
}
