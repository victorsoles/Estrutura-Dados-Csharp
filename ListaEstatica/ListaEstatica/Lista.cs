using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Inserir(string valor)                ok
 * Inserir(string valor, int posicao)   ok
 * 
 * Excluir()                            ok
 * Excluir(int posicao)                 ok
 * 
 * Imprimir()                           ok                         
 * Imprimir(int inicio, int final)      ok
 * 
 * Ordenar(int ordem)                   ok
 * 
 * Alterar(string valor, int posicao)   ok
 * 
 * Pesquisar(string valor)              ok
 */
  
namespace ListaEstatica
{
    internal class Lista
    {
        string[] lista;
        int limite;
        int primeiro = 0;
        int ultimo = 0;

        public Lista(int Tamanho) 
        {
            this.lista = new string[Tamanho];
            this.limite = Tamanho;
        }

        public void Inserir(string Valor)
        {
            if (ultimo < limite)
            {
                lista[ultimo] = Valor;
                ultimo++;
            }
            else
            {
                Console.WriteLine("Lista cheia!");
            }

        }

        public void Inserir(string Valor, int Posicao)
        {
            // verifica se há espaço
            if(ultimo < limite)
            {
                if (Posicao >= ultimo)
                {
                    Inserir(Valor);
                }
                else
                {
                    // movimentação para alocar o novo valor na POS. desejada
                    for (int i = 0; i < (ultimo - (Posicao-1)); i++)
                    {
                        lista[ultimo - i] = lista[ultimo - (i + 1)];
                    }

                    // guarda o valor na posição desejada
                    lista[Posicao-1] = Valor;

                    ultimo++;
                }
            }
            else
            {
                Console.WriteLine("Lista cheia!");
            }
        }

        public void Excluir()
        {
            if (ultimo > 0)
            {
                ultimo--;
            }
            else
            {
                Console.WriteLine("Lista vazia!");
            }
        }

        public void Excluir(int Posicao)
        {
            // movimentação dos dados para ocupar o espaço vazio.
            for (int i = Posicao; i < ultimo; i++)
            {
                lista[i] = lista[i + 1];
            }
            // atualiza o valor da última posição
            ultimo--;
        }

        public void Imprimir()
        {
            if(ultimo > 0)
            {
                for (int i = 0; i < ultimo; i++)
                {
                    Console.WriteLine(lista[i]);
                }
            }
            else
            {
                Console.WriteLine("Lista vazia!");
            }
        }

        public void Imprimir(int Inicio, int Final)
        {
            if(ultimo > 0)
            {
                for (int i = (Inicio - 1); i < Final; i++)
                {
                    Console.WriteLine(lista[i]);
                }
            }
            else
            {
                Console.WriteLine("Lista vazia!");
            }
        }

        public void Ordenar(int Ordem=0)
        {
            if (ultimo > 0)
            {
                if(ultimo > 1)
                {
                    if(Ordem == 0)
                    {
                        // ordem crescente
                        for (int i = 0; i < (ultimo - 1); i++)
                        {
                            for (int j = i+1; j < ultimo; j++)
                            {
                                if (lista[i].CompareTo(lista[j]) == 1)
                                {
                                    string aux = lista[i].ToString();
                                    lista[i] = lista[j];
                                    lista[j] = aux;
                                }
                            }
                        }
                    }
                    else
                    {
                        // ordem decrescente
                        for (int i = 0; i < (ultimo - 1); i++)
                        {
                            for (int j = i+1; j < ultimo; j++)
                            {
                                if (lista[i].CompareTo(lista[j]) == -1)
                                {
                                    string aux = lista[i].ToString();
                                    lista[i] = lista[j];
                                    lista[j] = aux;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Lista vazia!");
            }
        }

        public void Alterar(string Valor, int Posicao)
        {
            if((Posicao < ultimo) && (Posicao > 0))
            {
                lista[Posicao]= Valor;
            }
            else
            {
                Console.WriteLine("Posição fora da lista");
            }
        }

        public int PesquisarPosicao(string Valor)
        {
            int achei = -1; // NÃO ACHEI
            int i = 0;
            while (i < ultimo)
            {
                if (lista[i].ToUpper() == Valor.ToUpper())
                {
                    achei = i; // ACHEI O VALOR
                    i = ultimo;
                }
                i++;
            }
            return achei;
        }

        public bool Pesquisar(string Valor)
        {
            bool achei = false; // NÃO ACHEI
            int i = 0;
            while(i < ultimo)
            {
                if (lista[i].ToUpper() == Valor.ToUpper()) 
                {
                    achei = true; // ACHEI O VALOR
                    i = ultimo;
                }
                i++;
            }
            return achei;
        }
    }
}
