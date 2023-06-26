using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_abstract
{
    public class LaserJet : Printer
    {
        public override void Show()
        {
            Console.WriteLine("<>Merk printer         : {0}", Merk);
            Console.WriteLine("<>display dimension    : {0}", Dimension);
        }
        public override void Print()
        {
            Console.WriteLine("<>{0} printer printing....", Merk);
        }
    }
}
