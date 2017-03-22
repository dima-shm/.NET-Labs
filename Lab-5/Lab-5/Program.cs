using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer archer = new Archer(250, 50, 1, 30);
            Druid druid = new Druid(500, 100, 1, 50);

            Console.WriteLine("<Archer>\n" + archer.ToString());
            Console.WriteLine("<Druid>\n" + druid.ToString());


            Game game = new Game();

            game.Attacked += Attack;
            Console.WriteLine("\t\t\tEvent: <Archer> Attack <Druid>\n");
            game.Battle(archer, druid);
            Console.WriteLine("<Archer>\n" + archer.ToString());
            Console.WriteLine("<Druid>\n" + druid.ToString());

            Console.WriteLine("\t\t\tEvent: <Druid> Attack <Archer>\n");
            game.Battle(druid, archer);
            Console.WriteLine("<Archer>\n" + archer.ToString());
            Console.WriteLine("<Druid>\n" + druid.ToString());

            game.Treated += Treat;
            Console.WriteLine("\t\t\tEvent: <Druid> Treat <Archer>\n");
            game.Treatment(druid, archer);
            Console.WriteLine("<Archer>\n" + archer.ToString());
            Console.WriteLine("<Druid>\n" + druid.ToString());


            Reflector.WriteToFileAllContent("GameEventArgs");
            Reflector.WriteToFileAllPublicMethods("Game");
            Reflector.WriteToFileFieldAndProperties("GameEventArgs");
            Reflector.WriteToFileImplementedInterfaces("Archer");
            Reflector.WriteToFileNameOfMethodsWithSpecifiedType("Game", "Fighter");
            Reflector.ReadArgsMethodFromFile("Lab_5.MyClass", "Color_Message");
        }
        static void Attack(object o, GameEventArgs e)
        {
            if (e.fighter2.Hp > 0 && e.fighter1.Hp > 0)
                e.fighter2.Hp -= e.fighter1.Damage;
        }
        static void Treat(object o, GameEventArgs e)
        {
            if (e.fighter2.Hp > 0 && e.fighter1.Hp > 0)
                e.fighter2.Hp += e.fighter1.Damage;
        }
    }
}