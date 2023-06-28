using System;
using System.Collections.Generic;
using System.Text;

namespace Pertemuan_10
{
    public class Canon : IPrinter
    {
        void IPrinter.Print(Printer printer)
        {
            Console.WriteLine("Canon printer printing ...");
        }

        void IPrinter.Show(Printer printer)
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
    }
}
