namespace att5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> rankingJogadores = new SortedList<int, string>();
            int opcao = 0;

            while (opcao != 5)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Adicionar um novo jogador e sua pontuação");
                Console.WriteLine("2 - Verificar a pontuação de um jogador");
                Console.WriteLine("3 - Remover um jogador e sua pontuação");
                Console.WriteLine("4 - Exibir o ranking de pontuação (ordem crescente)");
                Console.WriteLine("5 - Sair");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do jogador: ");
                        string nomeJogador = Console.ReadLine();
                        Console.Write("Digite a pontuação do jogador: ");
                        int pontuacao = int.Parse(Console.ReadLine());

                   
                        if (rankingJogadores.ContainsKey(pontuacao))
                        {
                            Console.WriteLine("Já existe um jogador com essa pontuação. Tente novamente com uma pontuação diferente.");
                        }
                        else
                        {
                            rankingJogadores.Add(pontuacao, nomeJogador);
                            Console.WriteLine($"Jogador {nomeJogador} adicionado com {pontuacao} pontos.");
                        }
                        break;

                    case 2:
                        Console.Write("Digite o nome do jogador que deseja verificar a pontuação: ");
                        nomeJogador = Console.ReadLine();

                        bool jogadorEncontrado = false;
                        foreach (var jogador in rankingJogadores)
                        {
                            if (jogador.Value == nomeJogador)
                            {
                                Console.WriteLine($"Jogador {nomeJogador} tem {jogador.Key} pontos.");
                                jogadorEncontrado = true;
                                break;
                            }
                        }

                        if (!jogadorEncontrado)
                        {
                            Console.WriteLine($"Jogador {nomeJogador} não encontrado.");
                        }
                        break;

                    case 3:
                        Console.Write("Digite o nome do jogador que deseja remover: ");
                        nomeJogador = Console.ReadLine();

                        int chaveRemover = -1;
                        foreach (var jogador in rankingJogadores)
                        {
                            if (jogador.Value == nomeJogador)
                            {
                                chaveRemover = jogador.Key;
                                
                            }
                        }

                        if (chaveRemover != -1)
                        {
                            rankingJogadores.Remove(chaveRemover);
                            Console.WriteLine($"Jogador {nomeJogador} removido.");
                        }
                        else
                        {
                            Console.WriteLine($"Jogador {nomeJogador} não encontrado.");
                        }

                        break;

                    case 4:
                        Console.WriteLine("Ranking de pontuação (ordem crescente):");
                        foreach (var jogador in rankingJogadores)
                        {
                            Console.WriteLine($"{jogador.Value}: {jogador.Key} pontos");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();
            }
        }
    }
}
