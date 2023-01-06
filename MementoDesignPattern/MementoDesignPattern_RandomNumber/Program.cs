using System;
using System.Collections.Generic;

namespace MementoDesignPattern_RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator origin = new Originator();
            Random rand = new Random();
            origin.State = rand.Next(1000000);

            // Creating a Memento
            Caretaker caret = new Caretaker();
            caret.Memento = origin.CreateMemento();

            //Changing the state
            origin.State = rand.Next(1000000);
            origin.State = rand.Next(1000000);
            origin.State = rand.Next(1000000);

            // Restoring the State
            origin.RestoreMemento(caret.Memento);

            // Wait for user
            Console.ReadKey();
        }
    }
}
