using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job_Rotation.Models
{
    public class Soma
    {
        private int INDICE = 13;
        private int SOMA = 0;
        private int K = 0;

        public void SomaValores()
        {
            while(K < INDICE)
            {
                K += 1;
                SOMA += K;
            }

            System.Console.WriteLine($"Soma = {SOMA}");
        }
    }
}