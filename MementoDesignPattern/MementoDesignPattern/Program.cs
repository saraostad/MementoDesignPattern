﻿using System;

namespace MementoDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";
            
            // Store internal state
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();
            
            // Continue changing originator
            o.State = "Off";
            
            // Restore saved state
            o.SetMemento(c.Memento);
            
            // Wait for user
            Console.ReadKey();
        }

            //      Output
            //State = On
            //State = Off
            //Restoring state:
            //State = On

        public class Originator
        {
            string state;
            public string State
            {
                get { return state; }
                set
                {
                    state = value;
                    Console.WriteLine("State = " + state);
                }
            }
            // Creates memento 
            public Memento CreateMemento()
            {
                return (new Memento(state));
            }
            // Restores original state
            public void SetMemento(Memento memento)
            {
                Console.WriteLine("Restoring state...");
                State = memento.State;
            }
        }
        /// <summary>
        /// The 'Memento' class
        /// </summary>
        public class Memento
        {
            string state;
            // Constructor
            public Memento(string state)
            {
                this.state = state;
            }
            public string State
            {
                get { return state; }
            }
        }
        /// <summary>
        /// The 'Caretaker' class
        /// </summary>
        public class Caretaker
        {
            Memento memento;
            public Memento Memento
            {
                set { memento = value; }
                get { return memento; }
            }
        }
    }
}
