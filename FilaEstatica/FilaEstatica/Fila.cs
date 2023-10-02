using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaEstatica
{
    class Fila
    {
        // declaração das variáveis
        string[] fila;          // array de strings que representa a fila
        int limite;             // tamanho máximo da fila
        int primeiro;           // índice do primeiro elemento da fila
        int ultimo;             // índice do último elemento da fila

        public Fila(int Tamanho)                                // construtor da classe Fila que recebe o tamanho máximo da fila como argumento
        {
            fila = new string[Tamanho];     // inicializa a variável fila com um array de strings com tamanho igual a Tamanho
            limite = Tamanho;               // define o tamanho máximo da fila
            primeiro = 0;                   // define o índice do primeiro elemento como 0
            ultimo = 0;                     // define o índice do último elemento como 0
        }

        public void Enfileirar(string Valor)                    // método que recebe um valor do tipo string e enfileira o valor na fila
        {
            if(ultimo < limite)   // verifica se a fila ainda não está cheia
            {
                fila[ultimo] = Valor;           // adiciona o valor na última posição da fila
                ultimo++;                       // atualiza o índice do último elemento
            }
            else
            {
                Console.WriteLine("Fila cheia!");
            }
        }

        public void Desenfileirar()                             // método que remove o primeiro elemento da fila
        {
            if (primeiro < ultimo)   // verifica se a fila não está vazia
            {
                primeiro++;                     // atualiza o índice do primeiro elemento para apontar para o próximo elemento na fila
            }
            else                    
            {
                Console.WriteLine("Fila vazia!");
            }
        }

        public void Imprimir()                                  // método que imprime todos os elementos da fila
        {
            for (int i = primeiro; i < ultimo; i++)      // percorre todos os elementos da fila, começando do primeiro até o último
            {
                Console.WriteLine(fila[i]); // imprime o elemento da fila no índice i
            }
            Console.WriteLine("Fim da impressão");
        }

    }
}
