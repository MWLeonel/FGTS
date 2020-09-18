using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double FGTS;

            Console.Write("Digite seu Valor Salario R$: ");
            salario = double.Parse(Console.ReadLine());

            FGTS = (salario / 100) * 8;
            Console.WriteLine("Seu FGTS é = R${0}", FGTS);
            Console.Write("\n");

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
