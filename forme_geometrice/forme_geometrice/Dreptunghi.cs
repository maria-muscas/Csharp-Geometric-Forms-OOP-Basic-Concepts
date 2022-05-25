using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forme_geometrice
{
    public class Dreptunghi:Forma,IAria
    {
        int lungime, latime;

        public int Lungime { get => lungime; set => lungime = value; }
        public int Latime { get => latime; set => latime = value; }
        public Dreptunghi()
        {

        }
        public Dreptunghi(string oCuloare, int oLatime,int oLungime):base(oCuloare)
        {
            this.Latime = oLatime;
            this.Lungime = oLungime;
        }
        public override string descriere()
        {
            return base.descriere()+" " +this.Lungime+" "+this.Latime;
        }
        public float calculAria()
        {
            float rez = 0;
            rez = this.Latime * this.Lungime;
            return rez;
        }
        public void adaugDreptunghi()
        {
            Console.WriteLine("Introduceti val pentru dreptunghi: ");
            Console.WriteLine("Introduceti culoarea: ");
            this.Culoare = Console.ReadLine();
            Console.WriteLine("Introduceti valoarea lungimii: ");
            this.Lungime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latimea: ");
            this.Latime = int.Parse(Console.ReadLine());
            Dreptunghi drp = new Dreptunghi(Culoare,Lungime,Latime);
            elemente.Add(drp);
            nrElemente++;
        }
    }
}
