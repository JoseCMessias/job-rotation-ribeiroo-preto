namespace Job_Rotation.Models
{
    public class InvertendoStrings
    {
        public void ResultadoInventendoStrings()
        {
            // Definindo a string que será invertida
            string original = "exemplo";

            // Criando um array de caracteres para armazenar a string invertida
            char[] invertido = new char[original.Length];

            // Preenchendo o array invertido com os caracteres da string original, na ordem inversa
            for (int i = 0; i < original.Length; i++)
            {
                invertido[i] = original[original.Length - 1 - i];
            }

            // Convertendo o array invertido em uma nova string
            string invertidoString = new string(invertido);

            // Exibindo o resultado na tela
            Console.WriteLine("String original: " + original);
            Console.WriteLine("String invertida: " + invertidoString);
        }
    }
}