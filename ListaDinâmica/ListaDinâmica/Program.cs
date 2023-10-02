// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lista Dinâmica");
Console.WriteLine("");

Lista lista = new Lista();

lista.Inserir("A");
lista.Inserir("C");
lista.Inserir("D");
lista.Inserir("E");

Console.WriteLine("Primeira impressão");
lista.Imprimir();

Console.WriteLine("Inserindo o B na posição 2");
lista.Inserir("B", 2);

Console.WriteLine("Impressão pós insersão");