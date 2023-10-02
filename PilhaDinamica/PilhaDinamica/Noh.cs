using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    internal class Noh // armazenar todos os valores da Pilha
    {
        private string valor;
        Noh anterior;

        public string Valor
        {
            get { return valor; }
            set { valor = value; }            
        }
        public Noh Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
    }

}
