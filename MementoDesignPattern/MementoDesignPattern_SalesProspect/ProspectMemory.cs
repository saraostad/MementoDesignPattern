﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern_SalesProspect
{
    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    public class ProspectMemory
    {
        Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
