using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinâmica
{
    internal class Lista
    {
        Noh primeiro;
        Noh ultimo;
        int quantidade = 0;

        public int Quantidade
        { 
            get { return quantidade; } 
            set { quantidade = value; } 
        }

        public void Inserir(string valor)
        {
            Noh nn = new Noh();

            nn.Valor = valor;
            nn.Atras = null;
            nn.Frente = null;

            if (Quantidade == 0)
            {
                primeiro = nn;
                ultimo = nn;
            }
            else
            {
                ultimo.Atras = nn;
                nn.Frente = ultimo;
                ultimo = nn;
            }

            Quantidade++;
        }

        public void Inserir(string valor, int posicao)
        {
            Noh nn = new Noh();

            Noh auxPrimeiro = primeiro;

            if (Quantidade > 0)
            {
                for (int i = 1; i < posicao; i++)
                {
                    auxPrimeiro = auxPrimeiro.Atras;
                }

                nn.Valor = valor;

                nn.Frente = auxPrimeiro.Frente;
                auxPrimeiro.Frente.Atras = nn;
                auxPrimeiro.Frente = nn;
                nn.Atras = auxPrimeiro;
            }
            else
            {
                Inserir(valor);
            }

            
        }

        public void Imprimir()
        {
            Noh auxPrimeiro = primeiro;

            for (int i = 1; i <= Quantidade; i++)
            {
                Console.WriteLine(auxPrimeiro.Valor);
                auxPrimeiro = auxPrimeiro.Atras;
            }
        }
    }
}
