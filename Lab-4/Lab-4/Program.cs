using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionType<Cylinder> setForCylinder = new CollectionType<Cylinder>();

            setForCylinder.Add(new Cylinder(11, 11));
            setForCylinder.Add(new Cylinder(12, 11));
            setForCylinder.Add(new Cylinder(13, 11));
            setForCylinder.Add(new Cylinder(14, 11));
            setForCylinder.Add(new Cylinder(15, 11));

            Console.WriteLine("\nsetForCylinder: ");
            for (int i = 0; i < setForCylinder.Count(); i++)
                setForCylinder[i].Print();
            Console.WriteLine();



            CollectionType<int> set1 = new CollectionType<int>();
            CollectionType<int> set2 = new CollectionType<int>();
            CollectionType<int> set3 = new CollectionType<int>();

            set1.Add(1);
            set1.Add(3);
            set1.Add(-5);
            set1.Add(2);

            set2.Add(10);
            set2.Add(313);
            set2.Add(92);

            set3.Add(8);
            set3.Add(5);
            set3.Add(-53);
            set3.Add(1);
            set3.Add(-44);

            CollectionType<int>[] set = { set1, set1, set2, set3 };

            Console.WriteLine("\nset[]: ");
            foreach (CollectionType<int> item in set)
            {
                Console.Write("[");
                foreach (int itemInSet in item)
                {
                    Console.Write(itemInSet + " ");
                }
                Console.Write("] ");
            }
            Console.WriteLine();
            Console.WriteLine("\nЗапросы:");
            var ObjectsContainingValue = from CollectionType<int> item in set
                                         where item == set1
                                         select item;
            Console.WriteLine("Количество объектов содержащих занчение set1 в массиве set[]: " + ObjectsContainingValue.Count());
            //var Value = from CollectionType<int> item in set
            //            where item.
            //            select item;
            Console.WriteLine("Все объекты кроме первых трех в массиве set[]: ");
            var Value = from CollectionType<int> item in set
                        where item != set[0]
                        where item != set[1]
                        where item != set[2]
                        select item;
            foreach (CollectionType<int> item in Value)
            {
                Console.Write("[");
                foreach (int itemInSet in item)
                {
                    Console.Write(itemInSet + " ");
                }
                Console.Write("] ");
            }

            



            SortedSet<string> setForString = new SortedSet<string>();

            setForString.Add("Hello");
            setForString.Add("How");
            setForString.Add("Are");
            setForString.Add("You");
            setForString.Add("?");

            Console.WriteLine("\n\nsetForString: ");
            foreach (string item in setForString)
                Console.Write("[" + item + "] ");
            Console.WriteLine();
 
            var setForStringLength = from string item in setForString
                                     where item.Length == 3
                                     select item;
            Console.WriteLine("Количество строк длиной 3: " + setForStringLength.Count());
            Console.Write("Строки длиной 3: ");
            foreach (string item in setForStringLength)
                Console.Write("[" + item + "] ");
            Console.WriteLine();
        }
    }
}
