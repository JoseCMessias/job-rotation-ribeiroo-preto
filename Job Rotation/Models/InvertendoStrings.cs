namespace Job_Rotation.Models
{
    public class InvertendoStrings
    {
        public void ResultadoInventendoStrings()
        {
            string original = "exemplo";
          
            char[] invertido = new char[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                invertido[i] = original[original.Length - 1 - i];
            }

            string invertidoString = new string(invertido);

            Console.WriteLine("String original: " + original);
            Console.WriteLine("String invertida: " + invertidoString);
        }
    }
}