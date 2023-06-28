using System;

namespace Pertemuan_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Console.WriteLine("Silahkan Pilih Printer : ");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.LaserJet");

            Console.WriteLine("Masukan Angka Pilihan Printer Anda : "); int input = Convert.ToInt32(Console.ReadLine());
            int pilihanPrinter = Convert.ToInt32(Console.ReadLine());
            printer.Merk = pilihanPrinter;

            IPrinter print;
            IPrinter show;

            if (printer.Merk == 1)
            {
                print = new Epson();
                show = new Epson();
            }
            else if (printer.Merk == 2)
            {
                print = new Canon();
                show = new Canon();
            }
            else 
            {
                print = new LaserJet();
                show = new LaserJet();
            }

            show.Show(printer);
            print.Print(printer);
            Console.ReadKey();
        }
    }
}
