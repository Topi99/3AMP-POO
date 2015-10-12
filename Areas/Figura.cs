using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulos
{
    class Figura
    {
        public float CalcAreaTriang(float bas, float altura)
        {
            return (bas * altura) / 2;
        }

        public float CalcArea(float l)
        {
            return l * l;
        }

        public float CalcArea(float bas, float alt)
        {
            return bas * alt;
        }

        public double CalcCirc(float r)
        {
            return Math.PI * (Math.Pow(r, 2));
        }
    }
}
