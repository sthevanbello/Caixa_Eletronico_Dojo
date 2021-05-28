using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Services
{
    class Print
    {
        StringBuilder stringBuilder = new StringBuilder();
        public void ImprimeListaDeNotas(double notas100, double notas50, double notas20, double notas10)
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
                    //stringBuilder.Append("e ");
                }
                stringBuilder.Append($"{notas20} nota de R$20,00 ");

            }
            if (notas20 > 1)
            {
                if (notas10 == 0 && notas50 > 0 || notas100 > 0)
                {
                    //stringBuilder.Append("e ");
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
    }
}
