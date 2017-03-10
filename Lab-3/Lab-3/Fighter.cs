using System;

namespace Lab_3
{
    abstract class Fighter
    {
        private int hp;
        private int damage;
        private int level;
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Hp property. Value less then zero.");
                else
                    hp = value;
            }
        }
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Damage property. Value less then zero.");
                else
                    hp = value;
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Level property. Value less then zero.");
                else
                    level = value;
            }
        }


        public Fighter()
        {
            hp = 0;
            damage = 0;
            level = 0;
        }
        public Fighter(int _hp, int _damage, int _level)
        {
            hp = _hp;
            damage = _damage;
            level = _level;
        }


        public void LevelUp()
        {
            level++;
            hp = 250 * level;
            damage = 50 * level;
        }
        public void LevelDown()
        {
            level--;
            hp = 250 * level;
            damage = 50 * level;
        }
        

        public abstract void WriteToFile();
        public abstract string ToString();


        public static Tuple<string, string, int> Corteg(Archer _archer, string _name)
        {
            string name;
            if (_name == "Alex")
                name = "Name is Alex";
            else
                name = "Name is't Alex";
            string hp = "Hp: " + _archer.Hp.ToString();
            int damage = _archer.Damage;

            return Tuple.Create<string, string, int>(name, hp, damage);
        }
    }
}
