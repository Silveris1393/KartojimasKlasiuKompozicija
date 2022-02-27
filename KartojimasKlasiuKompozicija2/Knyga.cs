using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartojimasKlasiuKompozicija2
{
    internal class Knyga
    {
        protected string pavadinimas;
        protected int likutis;
        bool paimta = false;

        public void getKnyga()
        {
            Console.WriteLine(pavadinimas + $" Likutis bibliotekoje: {likutis}");
        }
        public bool getPaimta()
        {
            return paimta;
        }
        public void setPaimtaT()
        {
            paimta = true;
           

        }
        public string pasirinktiKnyga()
        {
            likutis--;
            return pavadinimas;
        }
        public void setPaimtaF()
        {
            paimta = false;

        }

        public Knyga()
        {
            Console.WriteLine("iveskite kygos pavadinima");
            pavadinimas = Console.ReadLine();
            Console.WriteLine("iveskite knygu kieki");
            likutis = Convert.ToInt32(Console.ReadLine());

        }
        public Knyga (string pavadinimas, int likutis)
        {
            this.pavadinimas=pavadinimas;
            this.likutis = likutis;

        }
        public Knyga (string pavadinimas)
        {
            this.pavadinimas= pavadinimas;
        }
    }

}
