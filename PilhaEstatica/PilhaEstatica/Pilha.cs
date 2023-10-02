using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstatica
{
    class Pilha
    {
        string[] pilha;
        int topo = 0;
        int limite;

        // criando o construtor da classe PILHA
        public Pilha(int Tamanho)
        {
            // new é usado para instânciar uma classe
            pilha = new string[Tamanho];
            limite = Tamanho;
        }

        // Método para empilhar um valor na pilha
        public void Empilhar(string Valor)
        {
            // Verifica se ainda há espaço na pilha
            if (topo < limite)
            {
                pilha[topo] = Valor; // Adiciona o valor na pilha
                topo++; // Incrementa o topo da pilha
            }
            else
            {
                Console.WriteLine("Pilha está cheia!"); // Exibe mensagem de erro caso a pilha esteja cheia
            }
        }

        // Método para desempilhar um valor da pilha
        public void Desempilhar()
        {
            // Verifica se há elementos na pilha
            if (topo > 0)
            {
                topo--; // Decrementa o topo da pilha
            }
            else
            {
                Console.WriteLine("Pilha vazia!"); // Exibe mensagem de erro caso a pilha esteja vazia
            }
        }

        // Método para imprimir os valores da pilha
        public void Imprimir()
        {
            // Verifica se há elementos na pilha
            if (topo > 0)
            {
                // Imprime os valores da pilha
                for (int i = 0; i < topo; i++)
                {
                    Console.WriteLine(pilha[i]);
                }
            }
            else
            {
                Console.WriteLine("Pilha vazia!"); // Exibe mensagem de erro caso a pilha esteja vazia
            }
        }
    }
}
