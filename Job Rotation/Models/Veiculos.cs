using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job_Rotation.Models
{
    public class Veiculos
    {
        public void PosicaoDoVeiculo()
        {
            const double distancia = 100;
            const double velocidadeCarro = 110;
            const double velocidadeCaminhao = 80;
            const double tempoAdicionalPedagioCaminhao = 5;
            double tempoAdicionalHoras = tempoAdicionalPedagioCaminhao / 60;
            double tempoCarro = distancia / velocidadeCarro;
            double tempoCaminhao = (distancia / velocidadeCaminhao) + (tempoAdicionalHoras * 2);
            
            if (tempoCarro < tempoCaminhao)
            {
                Console.WriteLine("O carro está mais próximo de Ribeirão Preto.");
            }
            else if (tempoCaminhao < tempoCarro)
            {
                Console.WriteLine("O caminhão está mais próximo de Ribeirão Preto.");
            }
            else
            {
                Console.WriteLine("O carro e o caminhão se encontram no meio do caminho.");
            }
        }
    }
}