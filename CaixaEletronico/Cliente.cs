using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class Cliente
    {
        private readonly CaixaEletronico _caixaEletronico;

        public Cliente()
        {
            _caixaEletronico = new CaixaEletronico();
        }


        public void Sacar(double valor)
        {
            _caixaEletronico.RealizaSaque(valor);
        }
    }
}
