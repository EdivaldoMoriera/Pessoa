using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            TestePessoa p1 = new TestePessoa();
            TestePessoa p2 = new TestePessoa();

            Console.WriteLine("Dados da primeira Pessoa:");
           
            p1.nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da Pessoa:");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome da pessoa: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da Pessoa:");
            p2.idade = int.Parse(Console.ReadLine());
            if (p1.idade > p2.idade)
            {
                Console.WriteLine("A pessoa mais velhas é " +p1.nome);
            }
            else
            {
                Console.WriteLine("a pessoa mais velha é: "+p2.idade );
               
            }

            Console.ReadLine();
        }
    }
}
