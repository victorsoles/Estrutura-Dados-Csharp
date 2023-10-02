using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fila estática
            Console.WriteLine("                               ");
            Console.WriteLine("         Fila Estática         ");
            Console.WriteLine("                               ");

            // criando uma variável do tipo da Classe Fila
            Fila agenda = new Fila(5); // cria uma nova instância da classe Fila com tamanho máximo 5

            agenda.Enfileirar("A");
            agenda.Enfileirar("B");
            agenda.Enfileirar("C");
            agenda.Enfileirar("D");
            agenda.Enfileirar("E");

            // tentando adicionar um elemento a mais, mesmo após a fila ter atingido seu limite
            //agenda.Enfileirar("F");

            // removendo o primeiro elemento da fila
            //agenda.Desenfileirar(); // desenfileirar a letra A

            // imprimindo a fila
            agenda.Imprimir();

            Console.ReadKey();

        }
    }
}
