using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern_RandomNumber
{
    public class Originator
    {
        int _statesnap;
        public int State
        {
            get { return _statesnap; }
            set
            {
                _statesnap = value;
                Console.WriteLine("State is " + _statesnap);
            }
        }

        public Memento CreateMemento()
        {
            Console.WriteLine("Create Memento From State :" + _statesnap );
            return new Memento(_statesnap);
        }

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("The Previous State was: ");
            State = memento.Statesnap;
        }
    }
}
