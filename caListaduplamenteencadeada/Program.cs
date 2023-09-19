using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaduplamenteencadeada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lista minhaLista = new Lista();

            string controle;

            Console.WriteLine("[1] Insira um inteiro na Lista");
            Console.WriteLine("[2] Remova um inteiro da Lista");
            Console.WriteLine("[3] Imprima o MAIOR elemento da Lista");
            Console.WriteLine("[4] Imprima a Lista");
            Console.WriteLine("[5] SAIR");

            controle = Console.ReadLine();

            while (controle != "5")
            {
                switch (controle)
                {
                    case "1":
                        Console.WriteLine("Insira um inteiro:");
                        int valor = Convert.ToInt32(Console.ReadLine());
                        minhaLista.addInicio(valor);
                        break;
                    case "2":
                        Console.WriteLine("digite o numero:");
                        int remove;
                        remove = Convert.ToInt32(Console.ReadLine());
                        minhaLista.Remove(remove);
                        break;
                    case "3":
                        int maior = minhaLista.Maior();
                        Console.WriteLine("O maior elemento da lista é: " + maior);
                        break;
                    case "4":
                        Console.WriteLine("Lista:");
                        minhaLista.Imprimirlista();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("[1] Insira um inteiro na Lista");
                Console.WriteLine("[2] Remova um inteiro da Lista");
                Console.WriteLine("[3] Imprima o MAIOR elemento da Lista");
                Console.WriteLine("[4] Imprima a Lista");
                Console.WriteLine("[5] SAIR");

                controle = Console.ReadLine();
            }

        }
    }
}
