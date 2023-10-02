using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinâmica
{
    internal class Noh
    {
        string valor = "";
        Noh frente = null;
        Noh atras = null;

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public Noh Frente
        {
            get { return frente; }
            set { frente = value; }
        }

        public Noh Atras
        {
            get { return atras; }
            set { atras = value; }
        }

    }
}
