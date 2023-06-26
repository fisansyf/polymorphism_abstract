using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer epson = new Epson();
            Printer canon = new Canon();
            Printer laserjet = new LaserJet();

            epson.Dimension = "10*11";
            epson.Merk = "Epson";

            canon.Dimension = "9.5*12";
            canon.Merk = "Canon";

            laserjet.Dimension = "12*12";
            laserjet.Merk = "LaserJet";

            Console.WriteLine("Pilihan printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");
            Console.Write("Pilih printer [1..3] : ");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //pengkondisian
            if (pilihan == 1)
            {
                epson.Show();
                epson.Print();
            }
            else if (pilihan == 2)
            {
                canon.Show();
                canon.Print();
            }
            else if (pilihan == 3)
            {
                laserjet.Show();
                laserjet.Print();
            }
            else
                Console.WriteLine("!!Printer not detected!!");

            Console.ReadKey();
        }
    }
}
