using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer archer = new Archer(250, 50, 1, 30);
            Druid druid = new Druid(500, 100, 1, 50);

            archer.WriteToFile();
            druid.WriteToFile();

            Console.WriteLine("<Archer>\n" + archer.ToString());
            Console.WriteLine("<Druid>\n" + druid.ToString());

            if (archer.Equals(druid))
                Console.WriteLine("archer == druid\n");
            else
                Console.WriteLine("archer != druid\n");

            var myTuple = Fighter.Corteg(archer, "Alex");
            Console.WriteLine("{0}\n{1}\nDamage: {2}\n", myTuple.Item1, myTuple.Item2, myTuple.Item3);

            druid -= 50;
            Console.WriteLine("<Druid>\n" + druid.ToString());

            druid *= archer;
            Console.WriteLine("<Druid>\n" + druid.ToString());


            Hunter hunter1 = Hunter.getInstance();
            hunter1.Hp = 123;
            Console.WriteLine("<Hunter1>\n" + hunter1.ToString());
            Hunter hunter2 = Hunter.getInstance();
            Console.WriteLine("<Hunter2>\n" + hunter2.ToString());


            Archer archer2 = new Archer(500, 100, 2, 30);
            Console.WriteLine("<Archer2>\n" + archer2.ToString());
            Memento memento = new Memento(archer2);
            archer2.LevelUp();
            Console.WriteLine("<Archer2>\n" + archer2.ToString());
            Memento.Restorer.GetRestorer(ref memento, ref archer2);
            Console.WriteLine("<Archer2>\n" + archer2.ToString());
        }
    }
}
