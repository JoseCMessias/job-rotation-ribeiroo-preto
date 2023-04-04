using Job_Rotation.Models;

Soma ResultadoDaSoma = new Soma();
ResultadoDaSoma.SomaValores();
// SOMA = 91

Console.WriteLine("--------------------------");
Veiculos ResultadoPosicaoVeiuclo = new Veiculos();
ResultadoPosicaoVeiuclo.PosicaoDoVeiculo();
// O carro está mais próximo de Ribeirão Preto.

Console.WriteLine("--------------------------");
ProximoElemento resultadoDoProximoElemento = new ProximoElemento();
resultadoDoProximoElemento.resultadoProximoElemento();
/*
Próximo número da sequência a): 9
Próximo número da sequência b): 128
Próximo número da sequência c): 85
Próximo número da sequência d): 164
Próximo número da sequência e): 13
Próximo número da sequência f): 21
*/

Console.WriteLine("--------------------------");
InvertendoStrings resultadoDaInversoo = new InvertendoStrings();
resultadoDaInversoo.ResultadoInventendoStrings();
// String original: exemplo
// String invertida: olpmexe

Console.WriteLine("--------------------------");
SequenciaDeFibonacci resultadodeFibonati = new SequenciaDeFibonacci();
resultadodeFibonati.DeFibonati();
// 5 pertence à sequência de Fibonacci.  

Console.WriteLine("--------------------------");