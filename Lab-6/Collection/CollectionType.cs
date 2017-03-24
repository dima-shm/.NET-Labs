using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public delegate bool Comparator<T>(T x, T y);

    class CollectionType<T> : IEnumerable
                           where T : new()
    {
        private List<T> list;

        public CollectionType()
        {
            list = new List<T>();
        }

        public T this[int index]
        {
            get
            {
                return list.ElementAt<T>(index);
            }
            set
            {
                list.Insert(index, value);
            }
        }

        public List<T> GetList()
        {
            return list;
        }

        public void Add(T elem)
        {
            list.Add(elem);
        }

        public void Add(CollectionType<T> list2)
        {
            foreach (T item in list2)
            {
                list.Add(item);
            }
        }

        public void InsertAt(T item, int index)
        {
            list.Insert(index, item);
        }

        public void Remove(T item)
        {
            list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        public int Count()
        {
            return list.Count();
        }

        public bool Exists(Predicate<T> predicate)
        {
            return !(list.Exists(predicate));
        }

        public void ReverseList()
        {
            list.Reverse();
        }

        public void Sort(Comparator<T> func)
        {
            T tmp;
            for (int i = 0; i < list.Count; i++)
                for (int j = 0; j < list.Count - 1 - i; j++)
                    if (func(list[j], list[j + 1]))
                    {
                        tmp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tmp;
                    }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public void WriteToFile()
        {
            foreach (T item in list)
            {
                File.AppendAllText("collection.txt", "Height: " + item.ToString() + " Radius: " + item.ToString() + "\r\n");
            }
            File.AppendAllText("collection.txt", new String('-', 85));
        }
    }
}
