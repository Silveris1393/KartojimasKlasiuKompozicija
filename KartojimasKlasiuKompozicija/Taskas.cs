using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartojimasKlasiuKompozicija
{
    internal class Taskas
    {
        private double x;
        private double y;
        public void setX(double x)
        {
            this.x = x;
        }
        public void setY(double y)
        {
            this.y = y;
        }
        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }

        public Taskas()
        {
            Console.WriteLine("iveskite tasko koordinates");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
        }
    }
}
