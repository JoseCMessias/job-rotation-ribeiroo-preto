using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job_Rotation.Models
{
    public class ProximoElemento
    {
        public void resultadoProximoElemento()
        {
            // Sequência a)
            int a = 7;
            a += 2;
            Console.WriteLine("Próximo número da sequência a): " + a);

            // Sequência b)
            int b = 64;
            b *= 2;
            Console.WriteLine("Próximo número da sequência b): " + b);

            // Sequência c)
            int c = 36;
            c += (int)Math.Pow(Math.Sqrt(c) + 1, 2);
            Console.WriteLine("Próximo número da sequência c): " + c);

            // Sequência d)
            int d = 64;
            d += (int)Math.Pow(Math.Sqrt(d) + 2, 2);
            Console.WriteLine("Próximo número da sequência d): " + d);

            // Sequência e)
            int e1 = 8, e2 = 5;
            int e = e1 + e2;
            Console.WriteLine("Próximo número da sequência e): " + e);

            // Sequência f)
            int f = 19;
            if (f % 2 == 0)
            {
                f *= 2;
                f += 2;
            }
            else
            {
                f += 2;
            }
            Console.WriteLine("Próximo número da sequência f): " + f);
        }
    }
}