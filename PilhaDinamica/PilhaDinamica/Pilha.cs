using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    internal class Pilha
    {
        Noh topo = null;
        int quantidade = 0;

        public void Empilhar(string Valor)
        {
            // criando o NOH ATUAL --> Noh noh
            Noh noh = new Noh();

            noh.Valor = Valor;
            noh.Anterior = topo;

            topo = noh; // topo agora recebe o NOH ATUAL
            quantidade++;
        }

        public void Desempilhar()
        {
            if(quantidade > 0)
            {
                topo = topo.Anterior;
                quantidade--;
            }
            else
            {
                Console.WriteLine("Pilha vazia!");
            }
        }

        public void Imprimir()
        {
            Noh auxTopo = topo;

            if(quantidade > 0)
            {
                for (int i = 0; i < quantidade; i++)
                {
                    Console.WriteLine(auxTopo.Valor);
                    auxTopo = auxTopo.Anterior;
                }
            }
            else
            {
                Console.WriteLine("Pilha vazia!");
            }
        }
    }
}
