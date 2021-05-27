using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Notas
    {
        private int Nota10;
        private int Nota20;
        private int Nota50;
        private int Nota100;

        public Notas()
        {

        }

        public int ContaNota10()
        {
            return Nota10 += 1;
        }
        public int ContaNota20()
        {
            return Nota20 += 1;
        }
        public int ContaNota50()
        {
            return Nota50 += 1;
        }
        public int ContaNota100()
        {
            return Nota100 += 1;
        }
    }

}
