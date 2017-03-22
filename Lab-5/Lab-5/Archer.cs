using System;
using System.IO;

namespace Lab_5
{
    class Archer : Fighter , IAction
    {
        private int numberArrows;
        public int NumberArrows
        {
            get
            {
                return numberArrows;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("numberArrows property. Value less then zero.");
                else
                    numberArrows = value;
            }
        }


        public Archer() : base()
        {
            Hp = 0;
            Damage = 0;
            Level = 0;
            NumberArrows = 0;
        }
        public Archer(int _hp, int _damage, int _level, int _numberArrows) : base(_hp, _damage, _level)
        {
            NumberArrows = _numberArrows;
        }


        public void Move()
        {
            Console.WriteLine("Archer goes");
        }

       
        public override void WriteToFile()
        {
            File.WriteAllText("Archer.txt", "Hp: " + Hp.ToString());
            File.AppendAllText("Archer.txt", "\r\nDamage: " + Damage.ToString());
            File.AppendAllText("Archer.txt", "\r\nLevel: " + Level.ToString());
            File.AppendAllText("Archer.txt", "\r\nNumberArrows: " + NumberArrows.ToString());
        }
        //public override string ToString() =>  $"HP:{Hp}\nLevel: {Level}\nDamage:{Damage}\nNumberArrows:{NumberArrows}\n";
        public override string ToString()
        {
            return "HP: " + Hp + "\nDamage: " + Damage + "\nLevel: " + Level + "\nNumberArrows: " + NumberArrows + "\n";
        }
        public override int GetHashCode()
        {
            return Hp.GetHashCode() + Damage.GetHashCode() + NumberArrows.GetHashCode();
        }
        public override bool Equals(object _obj)
        {
            if (_obj.GetType() != this.GetType()) 
                return false;

            Archer _archer = (Archer)_obj;
            return (this.Hp == _archer.Hp && 
                this.Damage == _archer.Damage && 
                this.Level == _archer.Level && 
                this.NumberArrows == _archer.NumberArrows);
        }
    }
}
