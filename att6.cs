using System;
using System.Collections.Generic;

class Programa
{
    static void Main(string[] args)
    {
        LinkedList<string> Filmes = new LinkedList<string>();
        int opcao = 0;

        while (opcao != 7)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Inserir um filme no final da lista");
            Console.WriteLine("2 - Inserir um filme depois de uma posição específica da lista");
            Console.WriteLine("3 - Inserir um filme antes de uma posição específica da lista");
            Console.WriteLine("4 - Remover o filme que estiver no final da lista");
            Console.WriteLine("5 - Pesquisar se um filme consta na lista");
            Console.WriteLine("6 - Listar todos os filmes da lista");
            Console.WriteLine("7 - Encerrar o programa");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcao)
            {
                case 1:
                    Console.Write("Novo Filme: ");
                    string novoFilme = Console.ReadLine();
                    Filmes.AddLast(novoFilme);
                    Console.WriteLine($"Filme Adicionado ao final da lista: {novoFilme}");
                    break;

                case 2:
                    Console.Write("Nome do filme existente para adicionar o novo filme depois: ");
                    string filmeExistente = Console.ReadLine();
                    LinkedListNode<string> current = Filmes.Find(filmeExistente);
                    Console.Write("Novo Filme: ");
                    novoFilme = Console.ReadLine();
                    Filmes.AddAfter(current, novoFilme);
                    Console.WriteLine($"Filme {novoFilme} inserido depois de {filmeExistente}");



                    break;

                case 3:
                    Console.Write("Nome do filme existente para adicionar o novo filme antes: ");
                    filmeExistente = Console.ReadLine();
                   current = Filmes.Find(filmeExistente);
                    Console.Write("Novo Filme: ");
                    novoFilme = Console.ReadLine();
                    Filmes.AddBefore(current, novoFilme);
                    Console.WriteLine($"Filme {novoFilme} inserido antes de {filmeExistente}");

                    break;

                case 4:
                   
                        string filmeRemovido = Filmes.Last.Value;
                        Filmes.RemoveLast();
                        Console.WriteLine($"Filme Removido: {filmeRemovido}");
                
                    break;

                case 5:
                    Console.Write("Nome do filme: ");
                    string buscarFilme = Console.ReadLine();
                    if (Filmes.Contains(buscarFilme))
                        Console.WriteLine($"O filme '{buscarFilme}' está na lista.");
                    else
                        Console.WriteLine($"O filme '{buscarFilme}' não foi encontrado na lista.");
                    break;

                case 6:
                      Console.WriteLine("Filmes na lista:");
                        foreach (string filme in Filmes)
                        {
                            Console.WriteLine(filme);
                        }
                  
                    break;

                case 7:
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
                Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();
            
        }
    }
}
