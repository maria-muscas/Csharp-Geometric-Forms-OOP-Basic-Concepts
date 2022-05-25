using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forme_geometrice
{
    public class Triunghi:Forma,IAria
    {
        int baza, inaltimea;

        public int Baza { get => baza; set => baza = value; }
        public int Inaltimea { get => inaltimea; set => inaltimea = value; }
        public Triunghi()
        {

        }
        public Triunghi(string oCuloare, int oBaza,int oInaltime):base(oCuloare)
        {
            this.Baza = oBaza;
            this.Inaltimea = oInaltime;
        }
        public override string descriere()
        {
            return base.descriere()+" "+this.Baza+" "+this.Inaltimea;
        }
        public float calculAria()
        {
            float result = 0;
            result = (this.Baza * this.Inaltimea) / 2;
            return result;
        }
        
  
        public void adaugTriunghi()
        {
            Console.WriteLine("Introduceti val pentru triunghi: ");
            Console.WriteLine("Introduceti culoarea: ");
            this.Culoare = Console.ReadLine();
            Console.WriteLine("Introduceti valoarea bazei: ");
            this.Baza = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti inaltimea: ");
            this.Inaltimea= int.Parse(Console.ReadLine());
            Triunghi tr = new Triunghi(Culoare,Baza,Inaltimea);
            elemente.Add(tr);
            nrElemente++;
        }
       
    }
}
