using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_abstract
{
    public abstract class Printer
    {
        public string Dimension { get; set; }
        public string Merk { get; set; }
        public abstract void Show();
        public abstract void Print();
    }
}