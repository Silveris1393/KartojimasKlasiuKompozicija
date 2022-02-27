using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartojimasKlasiuKompozicija2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            7.Sukurti Bibliotekos, Knygos ir Skaitytojo klases susietas klasių kompozicijos ryšiu. Bibliotekos klasėje
            turi būti informacija apie visus bibliotekos skaitytojus, joje saugomas knygas, galimybė išvesti knygas
            kurios yra paimtos skaityti ir kas jas skaito, bei skaitytojų sąrašą kurie yra paėmė skaityti knygas iš
            bibliotekos.Knygos klasėje pateikiama informacija apie autorių, pavadinimą, išleidimo metus ir pan.
            Skaitytojo klasėje pateikiamas vardas, pavardė, asmens kodas ir kt.
            */

            Biblioteka test = new Biblioteka();
            test.generuotiKnygas();
            test.generuotiSkaitytojus();
            //  test.rodytiKnygas();


            // test.pasirinktiKnyga(pasirinkimas);

            // test.rodytiKnygas();
            //   test.paimtosKnygos();
            // test.parodytiSkaitytojus();
            test.parodytiSkaitytojus();
            Console.WriteLine("pasirinkite skaitytoja");
            int pasirinkimas2 = Convert.ToInt32(Console.ReadLine());
            test.rodytiKnygas();
            Console.WriteLine("pasirinkite knyga");
            int pasirinkimas= Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            test.pasirinktiSkaitytojaIrKnyga(pasirinkimas, test.pasirinktiKnyga(pasirinkimas2));
            test.pasirinktiSkaitytojaIrKnyga(2, test.pasirinktiKnyga(4));
            test.paimtosKnygos();
            Console.ReadKey();

            
        }
    }
}
