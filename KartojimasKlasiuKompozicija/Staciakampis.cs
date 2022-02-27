using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartojimasKlasiuKompozicija
{
    internal class Staciakampis
    {
        private Taskas kairinisA;
        private Taskas kairinisV;
        private Taskas desininisA;
        private Taskas desininisV;
        public double krastineA;
        public double krastineB;

        //(x2-x1)2+(y2-y1)2  krastines ilgis
        public double krastinesilgisA()
        {
          krastineA =Math.Sqrt( (kairinisA.getX() - desininisA.getX())*2 + (kairinisA.getY()- desininisA.getY())* 2);
            return krastineA;
        }
        public double krastinesilgisB()
        {
            krastineB = Math.Sqrt( (kairinisV.getX() - kairinisA.getX()) * 2 + (kairinisA.getY() - kairinisA.getY()) * 2);
            return krastineB;
        }

        public double perimetras()
        {
            return 2* (krastinesilgisA() + krastinesilgisB());

        }
        public double plotas()
        {
            return krastinesilgisA() * krastinesilgisB();
        }

        public Staciakampis()
        {
            kairinisA = new Taskas();
            kairinisV = new Taskas();
            desininisA = new Taskas();
            desininisV = new Taskas();
            krastineA= krastinesilgisA();

           krastineB = krastinesilgisB();  
        }
    }
}
