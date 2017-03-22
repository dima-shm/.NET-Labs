using System;
using System.IO;

namespace Lab_5
{
    class Memento
    {
        private Archer Archer { get; set; }


        public Memento(Archer _archer)
        {
            Archer = new Archer(_archer.Hp, _archer.Damage, _archer.Level, _archer.NumberArrows);
        }


        public void SaveMemento(Archer _archer)
        {
            Archer = new Archer(_archer.Hp, _archer.Damage, _archer.Level, _archer.NumberArrows);
        }
        public Archer GetMemento()
        {
            return Archer;
        }


        public class Restorer
        {

            public static void GetRestorer(ref Memento _memento, ref Archer _archer)
            {
                _archer = _memento.GetMemento();
            }
        }
    }
}
