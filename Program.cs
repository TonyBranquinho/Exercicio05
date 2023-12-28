using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite o codigo da peça 1, o numero de peças 1" +
                "e o valor unitario dela.");
            Console.WriteLine("Digite o codigo da peça 2, o numero de peças 2" +
                "e o valor unitario dela.");

            string[] vet1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(vet1[0]);
            int quantidade1 = int.Parse(vet1[1]);
            double valorUnitario1 = double.Parse(vet1[2], CI);

            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int quantidade2 = int.Parse(vet2[1]);
            double valorUnitario2 = double.Parse(vet2[2], CI);

            double parcial1 = quantidade1 * valorUnitario1;
            double parcial2 = quantidade2 * valorUnitario2;
            double total = parcial1 + parcial2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CI));

        }
    }
}