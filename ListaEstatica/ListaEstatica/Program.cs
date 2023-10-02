
using ListaEstatica;

Lista agenda = new Lista(5);

Console.WriteLine("Lista Estática");
Console.WriteLine();

Console.WriteLine("Inserindo A, B, C e D na agenda");
agenda.Inserir("A");
agenda.Inserir("B");
agenda.Inserir("C");
agenda.Inserir("D");

Console.WriteLine("Imprimir todos os valores inseridos na Agenda");
agenda.Imprimir();

Console.WriteLine();
Console.WriteLine("Inserindo um valor na segunda posição entre A e B");
agenda.Inserir("Z", 2);

Console.WriteLine("Imprimir todos os valores inseridos na Agenda");
agenda.Imprimir();

Console.WriteLine("Ordenando a lista em ordem crescente");
agenda.Ordenar();

Console.WriteLine("Imprimir a Agenda em ordem crescente");
agenda.Imprimir();

Console.WriteLine("Alterar a posião dois da agenda.");
agenda.Alterar("Y",1);

Console.WriteLine("Imprimir a Agenda após a alteração.");
agenda.Imprimir();

Console.WriteLine("Localizando a letra z na Agenda");

if (agenda.Pesquisar("Z"))
{
    Console.WriteLine("O nome pesquisado foi encontrado."); 
}
else {
    Console.WriteLine("O nome pesquisado não foi encontrado.");
}

Console.WriteLine("Localizando a POSIÇÃO da letra z na Agenda");

if (agenda.PesquisarPosicao("Z") >= 0)
{
    Console.WriteLine("O nome pesquisado foi encontrado na posicao " + agenda.PesquisarPosicao("Z"));
}
else
{
    Console.WriteLine("O nome pesquisado não foi encontrado.");
}