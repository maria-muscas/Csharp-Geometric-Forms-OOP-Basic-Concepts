using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forme_geometrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triunghi tr = new Triunghi();
            Dreptunghi drp = new Dreptunghi();
            int nr_triunghi, nr_dreptunghi;
            Console.WriteLine("Introduceti nr de triunghiuri: ");
            nr_triunghi = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti nr de dreptunghiuri: ");
            nr_dreptunghi = int.Parse(Console.ReadLine());
            for(int i=0;i<nr_triunghi;i++)
            {
                tr.adaugTriunghi();
            }
            for (int i = 0; i < nr_dreptunghi; i++)
            {
                drp.adaugDreptunghi();
            }
            Console.WriteLine("Afisare elemente: ");
            tr.afisArie();
            Console.WriteLine("Afisare elemente dupa sortare: ");
            tr.sortare();
            Console.ReadKey();

        }
    }
}
