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

        public CaixaEletronico(Notas notas)
        {
            this.notas = notas;
        }

        public bool VerificaSaque(double valor)
        {

            if (valor % 10 == 0)
            {
                return true;
            }

            return false;
        }

        public void Saque(double valor)
        {
            
        }
    }
}
