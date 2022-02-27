using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartojimasKlasiuKompozicija2
{
    internal class Skaitytojas
    {
        protected string vardas;
        List<Knyga> knygos = new List<Knyga>();

        public void pasiimtiKnyga(string pavadinimas)
        {
            knygos.Add(new Knyga(pavadinimas));
            
        }

        public Knyga getKnyga()
        {
            return knygos.FirstOrDefault();
        }
        public string  getVardas()
        {
            return vardas;
        }
        public void getVardasVoid()
        {
            Console.WriteLine($"Skaitytojas {vardas}");
        }
        public Skaitytojas () {}
        public Skaitytojas(string vardas)
        {
            this.vardas = vardas;
        }
    }
}
