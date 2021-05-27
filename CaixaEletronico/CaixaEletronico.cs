using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class CaixaEletronico
    {
        private readonly Notas notas;
        public StringBuilder stringBuilder;
        int notas100;
        int notas50;
        int notas20;
        int notas10;
        public CaixaEletronico()
        {
            notas = new Notas();
            stringBuilder = new StringBuilder();
            notas100 = 0;
            notas50 = 0;
            notas20 = 0;
            notas10 = 0;
        }

        private bool VerificaSaqueValido(double valor)
        {

            if (valor % 10 == 0)
            {
                return true;
            }

            return false;
        }

        private void VerificaNotas(double valor)
        {
            

            if (!VerificaSaqueValido(valor))
            {
                throw new ArgumentException("Valor não pôde ser sacado, pois não há cédulas correspondentes.\n Cédulas disponíveis -  R$10,00 - R$20,00 - R$50,00 e R$100,00");
            }

            while (valor > 0)
            {

                if (valor >= 100.00)
                {
                    notas100 = notas.ContaNota100();
                    valor -= 100.00;
                }
                else if (valor >= 50 && valor < 100)
                {
                    notas50 = notas.ContaNota50();
                    valor -= 50.00;
                }
                else if (valor >= 20 && valor < 50)
                {
                    notas20 = notas.ContaNota20();
                    valor -= 20.00;
                }
                else if(valor >= 10 && valor < 20)
                {
                    notas10 = notas.ContaNota10();
                    valor -= 10.00;
                }

            }

        }

       
        private void ImprimeListaDeNotas()
        {
            stringBuilder.Append("Entregar ");

            
            if (notas100 == 1)
            {
                stringBuilder.Append($"{notas100} nota de R$100,00 ");
            }
            if (notas100 > 1)
            {
                stringBuilder.Append($"{notas100} notas de R$100,00 ");
            }
            if (notas50 > 0)
            {
                if (notas20 == 0 && notas10 == 0)
                {
                    stringBuilder.Append("e ");
                }
                stringBuilder.Append($"{notas50} nota de R$50,00 ");
            }
            if (notas20 == 1)
            {
                if (notas10 == 0)
                {
                    stringBuilder.Append("e ");
                }
                stringBuilder.Append($"{notas20} nota de R$20,00 ");

            }
            if (notas20 > 1)
            {
                if (notas10 == 0)
                {
                    stringBuilder.Append("e ");
                }
                stringBuilder.Append($"{notas20} notas de R$20,00 ");
            }
            if (notas10 == 1)
            {
                if (stringBuilder.Length > 9)
                {
                    stringBuilder.Append("e ");
                }
                stringBuilder.Append($"{notas10} nota de R$10,00");
            }

            Console.WriteLine(stringBuilder);
        }

        public void RealizaSaque(double valor)
        {

            VerificaNotas(valor);
            ImprimeListaDeNotas();

        }
    }
}
