using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    internal class Noh
    {
        string valor=null;
        Noh atras=null;

        public string Valor
        {
            get { return valor; } 
            set { valor = value; }
        } 

        public Noh Atras
        {
            get { return atras; }
            set { atras = value; }
        }
    }

}
