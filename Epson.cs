using System;
using System.Collections.Generic;
using System.Text;

namespace Pertemuan_10
{
    public class Epson : IPrinter
    {
        void IPrinter.Print(Printer printer)
        {
            Console.WriteLine("Epson printer printing ...");
        }

        void IPrinter.Show(Printer printer)
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
    }
}
