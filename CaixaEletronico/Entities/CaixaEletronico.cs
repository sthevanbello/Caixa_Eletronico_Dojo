using CaixaEletronico.Services;
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
        private readonly Print imprimir;
        //public StringBuilder stringBuilder;
        int notas100;
        int notas50;
        int notas20;
        int notas10;
        double valorNoCaixa;
        public CaixaEletronico()
        {
            notas = new Notas();
            imprimir = new Print();
            //stringBuilder = new StringBuilder();
            notas100 = 0;
            notas50 = 0;
            notas20 = 0;
            notas10 = 0;
            valorNoCaixa = 1000.00;
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
                throw new ArgumentException("Valor não pôde ser sacado, pois não há cédulas correspondentes.\nCédulas disponíveis -  R$10,00 - R$20,00 - R$50,00 e R$100,00");
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
                else if (valor >= 10 && valor < 20)
                {
                    notas10 = notas.ContaNota10();
                    valor -= 10.00;
                }

            }

        }


        public void RealizaSaque(double valor)
        {
                try
                {
                    
                    VerificaNotas(valor);

                    imprimir.ImprimeListaDeNotas(notas100, notas50, notas20, notas10);

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);

                } 

        }
    }
}
