using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern_RandomNumber
{
    public class Memento
    {
        int _statesnap;

        public Memento(int statesnap)
        {
            this._statesnap = statesnap;
        }

        public int Statesnap
        {
            get { return _statesnap; }
        }
    }
}
