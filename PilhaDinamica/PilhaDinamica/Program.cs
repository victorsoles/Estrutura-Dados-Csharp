// See https://aka.ms/new-console-template for more information
using PilhaDinamica;

Console.WriteLine("Pilha DINÂMICA");

Pilha Agenda = new Pilha();

// EMPILHANDO SEIS ELEMENTOS
Agenda.Empilhar("A");
Agenda.Empilhar("B");
Agenda.Empilhar("C");
Agenda.Empilhar("D");
Agenda.Empilhar("E");
Agenda.Empilhar("F");

// IMPRESSÃO APÓS O EMPILHAMENTO
Agenda.Imprimir();

Console.WriteLine();
// DESEMPILHANDO O ÚLTIMO ELEMENTO
Agenda.Desempilhar();   

// IMPRESS]AO APÓS O PRIMEIRO DESEMPILHAMENTO
Agenda.Imprimir();

