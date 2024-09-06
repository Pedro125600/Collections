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



            Pilha.Push(0);
            Pilha.Push(1);

            

         for(int i = 0; i < N;i++)
            {
               // Fazer a sequencia de fibonachi e armazenar na pilha
            }

         foreach(int n in Pilha)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();

        }
    }
}
