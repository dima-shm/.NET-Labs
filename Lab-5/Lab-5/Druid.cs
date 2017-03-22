using System;
using System.IO;

namespace Lab_5
{
    sealed class Druid : Fighter, IAction
    {
        int mana;
        public int Mana
        {
            get
            {
                return mana;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Mana property. Value less then zero.");
                else
                    mana = value;
            }
        }


        public Druid() : base()
        {
            Hp = 0;
            Damage = 0;
            Level = 0;
            mana = 0;
        }
        public Druid(int _hp, int _damage, int _level, int _mana) : base(_hp, _damage, _level)
        {
            mana = _mana;
        }


        public void Move()
        {
            Console.WriteLine("Druid goes");
        }


        public override void WriteToFile()
        {
            File.WriteAllText("Druid.txt", "Hp: " + Hp.ToString());
            File.AppendAllText("Druid.txt", "\r\nDamage: " + Damage.ToString());
            File.AppendAllText("Druid.txt", "\r\nLevel: " + Level.ToString());
            File.AppendAllText("Druid.txt", "\r\nMana: " + Mana.ToString());
        }
        public override string ToString()
        {
            return "HP: " + Hp + "\nDamage: " + Damage + "\nLevel: " + Level + "\nMana: " + Mana + "\n";
        }
        public override int GetHashCode()
        {
            return Hp.GetHashCode() + Damage.GetHashCode() + Mana.GetHashCode();
        }
        public override bool Equals(object _obj)
        {
            if (_obj.GetType() != this.GetType())
                return false;

            Druid _archer = (Druid)_obj;
            return (this.Hp == _archer.Hp &&
                this.Damage == _archer.Damage &&
                this.Level == _archer.Level &&
                this.Mana == _archer.Mana);
        }


        public static Druid operator +(Druid _druid, int _hp)
        {
            checked
            {
                _druid.Hp += _hp;
            }
            return _druid;
        }
        public static Druid operator -(Druid _druid, int _hp)
        {

            if (_druid.Hp >= 1 && _druid.Hp > _hp)
            {
                _druid.Hp -= _hp;
            }
            else
                _druid.Hp = 0;
            return _druid;
        }
        public static Druid operator *(Druid _druid, Fighter _fighter)
        {
            if (_druid.Hp > 0 && _fighter.Hp > 0)
            {
                _druid.Hp -= _fighter.Damage;
            }
            return _druid;
        }
        public static bool operator <(Druid _druid1, Druid _druid2)
        {
            return _druid1.Hp < _druid2.Hp;
        }
        public static bool operator >(Druid _druid1, Druid _druid2)
        {
            return _druid1.Hp > _druid2.Hp;
        }
        public static bool operator ==(Druid _druid1, Druid _druid2)
        {
            return _druid1.Hp == _druid2.Hp;
        }
        public static bool operator !=(Druid _druid1, Druid _druid2)
        {
            return _druid1.Hp != _druid2.Hp;
        }
    }
}
