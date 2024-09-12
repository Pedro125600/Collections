using System;
using System.Collections.Generic;

namespace att3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> filaIniciacaoCientifica = new Queue<int>();
            Queue<int> filaMestrado = new Queue<int>();

            int opcao = 0;

            while (opcao != 11)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Inserir um aluno na fila de espera de bolsas de Iniciação Científica");
                Console.WriteLine("2 - Inserir um aluno na fila de espera de bolsas de Mestrado");
                Console.WriteLine("3 - Remover um aluno da fila de bolsas de Iniciação Científica");
                Console.WriteLine("4 - Remover um aluno da fila de bolsas de Mestrado");
                Console.WriteLine("5 - Mostrar fila de espera de bolsas de Iniciação Científica");
                Console.WriteLine("6 - Mostrar fila de espera de bolsas de Mestrado");
                Console.WriteLine("7 - Pesquisar aluno na fila de espera de bolsas de Iniciação Científica");
                Console.WriteLine("8 - Pesquisar aluno na fila de espera de bolsas de Mestrado");
                Console.WriteLine("9 - Mostrar qual o aluno que está no início da fila de espera de bolsas de Iniciação Científica");
                Console.WriteLine("10 - Mostrar qual o aluno que está no início da fila de espera de bolsas de Mestrado");
                Console.WriteLine("11 - Encerrar o programa");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o código do aluno para Iniciação Científica: ");
                        int alunoIC = int.Parse(Console.ReadLine());
                        filaIniciacaoCientifica.Enqueue(alunoIC);
                        Console.WriteLine($"Aluno {alunoIC} adicionado à fila de Iniciação Científica.");
                        break;

                    case 2:
                        Console.Write("Digite o código do aluno para Mestrado: ");
                        int alunoMestrado = int.Parse(Console.ReadLine());
                        filaMestrado.Enqueue(alunoMestrado);
                        Console.WriteLine($"Aluno {alunoMestrado} adicionado à fila de Mestrado.");
                        break;

                    case 3:
                        if (filaIniciacaoCientifica.Count > 0)
                        {
                            int removidoIC = filaIniciacaoCientifica.Dequeue();
                            Console.WriteLine($"Aluno {removidoIC} removido da fila de Iniciação Científica.");
                        }
                        else
                        {
                            Console.WriteLine("A fila de Iniciação Científica está vazia.");
                        }
                        break;

                    case 4:
                        if (filaMestrado.Count > 0)
                        {
                            int removidoMestrado = filaMestrado.Dequeue();
                            Console.WriteLine($"Aluno {removidoMestrado} removido da fila de Mestrado.");
                        }
                        else
                        {
                            Console.WriteLine("A fila de Mestrado está vazia.");
                        }
                        break;

                    case 5:
                        if (filaIniciacaoCientifica.Count > 0)
                        {
                            Console.WriteLine("Fila de espera de Iniciação Científica:");
                            foreach (int aluno in filaIniciacaoCientifica)
                            {
                                Console.WriteLine(aluno);
                            }
                        }
                        else
                        {
                            Console.WriteLine("A fila de Iniciação Científica está vazia.");
                        }
                        break;

                    case 6:
                        if (filaMestrado.Count > 0)
                        {
                            Console.WriteLine("Fila de espera de Mestrado:");
                            foreach (int aluno in filaMestrado)
                            {
                                Console.WriteLine(aluno);
                            }
                        }
                        else
                        {
                            Console.WriteLine("A fila de Mestrado está vazia.");
                        }
                        break;

                    case 7:
                        Console.Write("Digite o código do aluno para pesquisar na fila de Iniciação Científica: ");
                        int buscarIC = int.Parse(Console.ReadLine());
                        if (filaIniciacaoCientifica.Contains(buscarIC))
                        {
                            Console.WriteLine($"Aluno {buscarIC} está na fila de Iniciação Científica.");
                        }
                        else
                        {
                            Console.WriteLine($"Aluno {buscarIC} não está na fila de Iniciação Científica.");
                        }
                        break;

                    case 8:
                        Console.Write("Digite o código do aluno para pesquisar na fila de Mestrado: ");
                        int buscarMestrado = int.Parse(Console.ReadLine());
                        if (filaMestrado.Contains(buscarMestrado))
                        {
                            Console.WriteLine($"Aluno {buscarMestrado} está na fila de Mestrado.");
                        }
                        else
                        {
                            Console.WriteLine($"Aluno {buscarMestrado} não está na fila de Mestrado.");
                        }
                        break;

                    case 9:
                        if (filaIniciacaoCientifica.Count > 0)
                        {
                            Console.WriteLine($"Aluno {filaIniciacaoCientifica.Peek()} está no início da fila de Iniciação Científica.");
                        }
                        else
                        {
                            Console.WriteLine("A fila de Iniciação Científica está vazia.");
                        }
                        break;

                    case 10:
                        if (filaMestrado.Count > 0)
                        {
                            Console.WriteLine($"Aluno {filaMestrado.Peek()} está no início da fila de Mestrado.");
                        }
                        else
                        {
                            Console.WriteLine("A fila de Mestrado está vazia.");
                        }
                        break;

                    case 11:
                        Console.WriteLine("Programa encerrado.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
