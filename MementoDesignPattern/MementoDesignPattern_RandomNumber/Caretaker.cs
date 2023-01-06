using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MementoDesignPattern_RandomNumber
{
    public class Caretaker
    {
        Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }

    //public class Caretaker
    //{
    //    Dictionary<string, Memento> dicMemento = new Dictionary<string, Memento>();
    //    Memento _memento;
    //    string _mementoName;

    //    public string MementoName
    //    {
    //        set { _mementoName = value; }
    //    }

    //    public Memento Memento
    //    {
    //        set
    //        {
    //            _memento = value;
    //        }
    //    }

    //    public void AddMementoToList()
    //    {
    //        dicMemento.Add(_mementoName, _memento);
    //    }

    //    public Memento RestoreMemento (string mementoName)
    //    {
    //        var memneto = dicMemento.FirstOrDefault(q => q.Key.Equals(mementoName)).Value;
    //        dicMemento.Clear();
    //        dicMemento.Add(mementoName, memneto);
    //        return memneto;
    //    }

    //}
}
