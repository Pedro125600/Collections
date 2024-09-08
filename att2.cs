using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De o valor de N:");
            int N = int.Parse(Console.ReadLine());

            while(N < 3)
            {
                Console.Write("N deve ser maior ou igual a 3");
                N = int.Parse(Console.ReadLine());

            }

            Stack<int> Pilha = new Stack<int>(); 



           int a = 0, b = 1;

            Pilha.Push(a);
            Pilha.Push(b); 
            for (int i = 2; i < N; i++)
            {
                int c = a + b;
                Pilha.Push(c);
                a = b;
                b = c;
            }

            Console.WriteLine("Sequência de Fibonacci na ordem inversa:");

         foreach(int n in Pilha)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();

        }
    }
}
