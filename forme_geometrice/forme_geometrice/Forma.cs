using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forme_geometrice
{
    public abstract class Forma
    {
        string culoare;
        protected static List<IAria> elemente = new List<IAria>();
        protected static int nrElemente = 0;


        public string Culoare { get => culoare; set => culoare = value; }
        public Forma()
        {

        }
        public Forma(string oCuloare)
        {
            this.Culoare = oCuloare;
        }
        public virtual String descriere()
        {
            return this.Culoare;
        }
        public void afisArie()
        {
            
            for (int i = 0; i < nrElemente; i++)
            {
                    Console.Write(elemente[i].calculAria()+" ");
                    Console.WriteLine(((Forma)(elemente[i])).descriere());
            }
        }
        public void sortare()
        {
            elemente.Sort(new myComparer());
            foreach (Forma f in elemente)
                Console.WriteLine(f.descriere());
        }
        class myComparer : IComparer<IAria>
        {
            public int Compare(IAria x, IAria y)
            {
                return x.calculAria().CompareTo(y.calculAria());
            }
        }
    }
}
