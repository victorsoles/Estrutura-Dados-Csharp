using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    internal class Fila
    {
        Noh primeiro;
        Noh ultimo;
        int quantidade=0;

        public int Quantidade
        {
            get { return quantidade; } 
            set { quantidade = value; }
        }

        public void Enfileirar(string valor)
        {
            Noh nn = new Noh();

            nn.Valor = valor;
            nn.Atras = null;

            if (Quantidade == 0)
            {         
                primeiro = nn;
                ultimo = nn;
            }
            else
            {
                ultimo.Atras = nn;
                ultimo = nn;
            }

            Quantidade++;
        }

        public void Desinfileirar()
        {
            if(Quantidade > 0)
            {
                primeiro = primeiro.Atras;
                Quantidade--;
            }
        }

        public void Imprimir()
        {
            if(Quantidade >= 1)
            {
                Noh auxPrimeiro = primeiro;

                for (int i = 1; i <= quantidade; i++)
                {
                    Console.WriteLine(auxPrimeiro.Valor);
                    auxPrimeiro = auxPrimeiro.Atras;
                }
            }
            else
            {
                Console.WriteLine("Fila Vazia!");
            }
            
        }
    }
}
