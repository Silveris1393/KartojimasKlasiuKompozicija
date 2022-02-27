using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartojimasKlasiuKompozicija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1.Stačiakampis plokštumoje gali būti aprašytas keturiais taškais, kurie nusako jo kampų koordinates.
            Sukurkite dvi klases – Taskas ir Staciakampis.Klasė Taskas aprašo taško plokštumoje koordinates(x
            ir y), o Staciakampis turės keturis Taskas klasės objektus, kurie nusakys jo kampų koordinates.
            Sukurkite klasės metodus, kurie leistų apskaičiuoti stačiakampio perimetrą ir plotą pagal įvestas jo    
            kampų koordinates
            */

            Staciakampis pirmas = new Staciakampis();
            double testas = pirmas.perimetras();
            double testas2 = pirmas.plotas();

            Console.WriteLine($"Staciakampio perimetras yra {testas} \nO plotas yra: {testas2}");

            Console.ReadLine();

        }
    }
}
