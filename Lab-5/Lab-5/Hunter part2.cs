using System;
using System.IO;

namespace Lab_5
{
    partial class Hunter : Fighter, IAction
    {
        private Hunter() : base()
        {
            Hp = 0;
            Damage = 0;
            Level = 0;
            Force = 0;
        }


        public void Move()
        {
            Console.WriteLine("Archer goes");
        }


        public override string ToString()
        {
            return "HP: " + Hp + "\nDamage: " + Damage + "\nLevel: " + Level + "\nForce: " + Force + "\n";
        }


        public static Hunter getInstance()
        {
            if (instance == null)
                instance = new Hunter();
            return instance;
        }


        public override void WriteToFile()
        {
            File.WriteAllText("Hunter.txt", "Hp: " + Hp.ToString());
            File.AppendAllText("Hunter.txt", "\r\nDamage: " + Damage.ToString());
            File.AppendAllText("Hunter.txt", "\r\nLevel: " + Level.ToString());
            File.AppendAllText("Hunter.txt", "\r\nForce: " + Force.ToString());
        }
    }
}
