using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    delegate void MyEventHendler(object o, GameEventArgs e);
    class GameEventArgs
    {
        public Fighter fighter1, fighter2;

        public GameEventArgs(Fighter _fighter1, Fighter _fighter2)
        {
            fighter1 = _fighter1;
            fighter2 = _fighter2;
        }
    }
    class Game
    {
        public event MyEventHendler Attacked;
        public event MyEventHendler Treated;

        public void OnAttackEvent(Fighter _fighter1, Fighter _fighter2)
        {
            if (Attacked != null)
                Attacked(this, new GameEventArgs(_fighter1, _fighter2));
        }
        public void OnTreatEvent(Fighter _fighter1, Fighter _fighter2)
        {
            if (Treated != null)
                Treated(this, new GameEventArgs(_fighter1, _fighter2));
        }
    }
}
