using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace att4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> contarPalavras = new Dictionary<string, int>();

            string filePath = "Aula Prática - Collections.txt"; 
            string text = File.ReadAllText(filePath);
            string[] palavras = text.Split(' ', ',', '.', ';', ':', '?', '!', '\n', '\r', '\"', '-', '(', ')');

            foreach (string palavra in palavras)
            {
                if (contarPalavras.ContainsKey(palavra))
                {
                    contarPalavras[palavra]++;
                }
                else
                {
                    contarPalavras[palavra] = 1;
                }
            }

            int opcao = 0;
            while (opcao != 5)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Verificar se uma determinada palavra está no dicionário");
                Console.WriteLine("2 - Consultar quantas palavras distintas existem no dicionário");
                Console.WriteLine("3 - Imprimir todas as palavras e suas respectivas frequências");
                Console.WriteLine("4 - Consultar a frequência de uma palavra específica");
                Console.WriteLine("5 - Sair");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a palavra para verificar: ");
                        string procurar = Console.ReadLine();
                        if (contarPalavras.ContainsKey(procurar))
                        {
                            Console.WriteLine($"A palavra '{procurar}' está no dicionário.");
                        }
                        else
                        {
                            Console.WriteLine($"A palavra '{procurar}' não foi encontrada no dicionário.");
                        }
                        break;

                    case 2:
                        Console.WriteLine($"Existem {contarPalavras.Count} palavras distintas no dicionário.");
                        break;

                    case 3:
                        Console.WriteLine("Palavras e frequências:");
                        foreach (var frequencia in contarPalavras)
                        {
                            Console.WriteLine($"{frequencia.Key}: {frequencia.Value}");
                        }
                        break;

                    case 4:
                        Console.Write("Digite a palavra para consultar a frequência: ");
                        string PalavrasFrequentes = Console.ReadLine();
                        if (contarPalavras.ContainsKey(PalavrasFrequentes))
                        {
                            Console.WriteLine($"A palavra '{PalavrasFrequentes}' aparece {contarPalavras[PalavrasFrequentes]} vezes.");
                        }
                        else
                        {
                            Console.WriteLine($"A palavra '{PalavrasFrequentes}' não foi encontrada no dicionário.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
            }
        }
    }
}
