using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();



            Console.WriteLine("Insira um valor para realizar o saque");
            double valor = double.Parse(Console.ReadLine());

            cliente.Sacar(valor);

            Console.ReadLine();
        }
    }
}
