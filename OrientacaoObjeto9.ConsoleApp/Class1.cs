using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto9.ConsoleApp
{
    internal class Aluno
    {
        public double n1, n2, n3, n4;
        public double Media()
        {
            double ValorNota = (4 / ((1 / n1) + (1 / n2) + (1 / n3) + (1 / n4)));
            return ValorNota;
        }
    }
}
