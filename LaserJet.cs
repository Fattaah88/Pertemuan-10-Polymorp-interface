using System;
using System.Collections.Generic;
using System.Text;

namespace Pertemuan_10
{
    public class LaserJet : IPrinter
    {
        void IPrinter.Print(Printer printer)
        {
            Console.WriteLine("LaserJet printer printing ...");
        }

        void IPrinter.Show(Printer printer)
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }
    }
}
