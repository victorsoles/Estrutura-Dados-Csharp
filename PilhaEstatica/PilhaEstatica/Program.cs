using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            //using PilhaEstatica
            Console.WriteLine("Pilha Estática");
            Pilha Agenda = new Pilha(5);

            // INSERINDO VALORES NA AGENDA
            Agenda.Empilhar("A");
            Agenda.Empilhar("B");
            Agenda.Empilhar("C");
            Agenda.Empilhar("D");
            Agenda.Empilhar("E");
            // Pilha cheia
            Agenda.Empilhar("F");

            // desempilhado
            Agenda.Desempilhar();
            Agenda.Desempilhar();
            Agenda.Desempilhar();
            Agenda.Desempilhar();
            Agenda.Desempilhar();
            // pilha vazia
            Agenda.Desempilhar();

            // impressão
            // INSERINDO VALORES NA AGENDA
            Agenda.Empilhar("A");
            Agenda.Empilhar("B");
            Agenda.Empilhar("C");
            Agenda.Empilhar("D");
            Agenda.Empilhar("E");

            // DESEMPILHAR O PRIMEIRO VALOR DA PILHA
            Agenda.Desempilhar();
            Agenda.Desempilhar();

            // IMPRESSÃO
            Agenda.Imprimir();

            Console.ReadKey();
        }
    }
}
