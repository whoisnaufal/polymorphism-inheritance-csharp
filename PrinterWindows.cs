using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class PrinterWindows
    {
        public string merk { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("MERK display dimension : UKURAN");
        }

        public virtual void Print()
        {
            Console.WriteLine("MERK Printer printing.......");
        }
    }
}