using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace att1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Filmes = new List<string>();

            int opcaoo = 0;

            while (opcaoo != 9)
            {
                Console.Clear();
            Console.WriteLine("1 - Inserir um filme no final da lista");
            Console.WriteLine("2 - Inserir um filme em uma posição específica da lista");
            Console.WriteLine("3 - Remover um filme da lista");
            Console.WriteLine("4 - Remover um filme em uma posição específica da lista");
            Console.WriteLine("5 - Pesquisar se um filme consta na lista");
            Console.WriteLine("6 - Listar todos os filmes da lista");
            Console.WriteLine("7 - Inverter a ordem dos filmes presentes na lista");
            Console.WriteLine("8 - Ordenar a lista de filmes");
            Console.WriteLine("9 - Encerrar o programa");

                Console.Write("Escolha uma opção:");
                opcaoo = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcaoo)
                {
                    case 1:
                        Console.Write("Novo Filme:");
                        string novoFilme = Console.ReadLine();
                        Filmes.Add(novoFilme);
                        Console.WriteLine($"Filme Adicionado: {novoFilme} ");
                        break;
                    case 2:
                        Console.Write("Novo Filme:");
                        novoFilme = Console.ReadLine();
                        Console.Write("Posição do filme:");
                        int posicao = int.Parse(Console.ReadLine());
                        Filmes.Insert(posicao, novoFilme);
                        Console.WriteLine($"Filme: {novoFilme} Adicionado a posição {posicao} ");
                        break; 
                    case 3:
                        Console.Write("Remover Filme:");
                        string remover = Console.ReadLine();
                        Filmes.Remove(remover);
                        Console.WriteLine($"Filme Removido: {remover} ");
                        break;
                    case 4:
                        Console.Write("Remover filme na Posição:");
                        posicao = int.Parse(Console.ReadLine());
                        Filmes.RemoveAt(posicao);
                        Console.WriteLine($"Filme: {Filmes} removido da posição {posicao} ");
                        break;
                    case 5:
                        Console.Write("Nome do filme:");
                        string buscarFilme = Console.ReadLine();
                        if (Filmes.Contains(buscarFilme))
                            Console.WriteLine("Esta na lista");
                        else
                            Console.WriteLine("Não esta na lista");
                        break;
                    case 6:
                        foreach (string filme in Filmes)
                        {
                            Console.Write(filme + " ");
                        }
                        break;
                    case 7:
                        Filmes.Reverse();
                        Console.WriteLine("Lista Invertida");

                        break;
                    case 8:
                        Filmes.Sort();
                        Console.WriteLine("Lista Ordenada");
                        break;
                    case 9:
                        Console.WriteLine("FIM");
                        break;
                }

                Console.ReadLine();
            }


            Console.ReadLine();


        }



    }
    }
