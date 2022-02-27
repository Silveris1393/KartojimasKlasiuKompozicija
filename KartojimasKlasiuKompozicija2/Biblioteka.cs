using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartojimasKlasiuKompozicija2
{
    internal class Biblioteka
    {
        List<Knyga> knygos = new List<Knyga>();
        List<Skaitytojas> skaitytojas = new List<Skaitytojas>();

        public void generuotiSkaitytojus()
        {
            skaitytojas.Add(new Skaitytojas("Petras"));
            skaitytojas.Add(new Skaitytojas("Mantas"));
            skaitytojas.Add(new Skaitytojas("Tadas"));
            skaitytojas.Add(new Skaitytojas("Gabriele"));
            skaitytojas.Add(new Skaitytojas("Auguste"));
        }
        
        public void generuotiKnygas()
        {
            knygos.Add(new Knyga("Monroe- fantaziju pasaulis", 5));
            knygos.Add(new Knyga("Body of knowledge", 5));
            knygos.Add(new Knyga("Anthony Robbins - neribota galia", 5));
            knygos.Add(new Knyga("Kaip susirasti draugu ir daryti jiems itaka", 5));
            knygos.Add(new Knyga("Nepisk sau proto", 5));
        }
      public void rodytiKnygas()
        {
            foreach (var knygos in knygos)
            {
                knygos.getKnyga();
            }
        }
        public void parodytiSkaitytojus()
        {
            foreach(var skaitytojai in skaitytojas)
            {
                Console.WriteLine(skaitytojai.getVardas()); 
            }
        }
        public void pasirinktiSkaitytojaIrKnyga(int kuris,string knyga)
        {

            skaitytojas[kuris].pasiimtiKnyga(knyga);
        }
        public string pasirinktiKnyga(int pasirinkimas)
        {
            knygos[pasirinkimas].setPaimtaT();
            return knygos[pasirinkimas].pasirinktiKnyga();
        }
        public void paimtosKnygos()
        { foreach (var skaitytojas in skaitytojas)
            {
                if (skaitytojas.getKnyga() != null)
                {
                    skaitytojas.getVardasVoid();
                }
            }
            foreach (var knygos in knygos)
            {
                if (knygos.getPaimta() == true)
                {
                     knygos.getKnyga();
                }
            }
           
        }
    }
}
