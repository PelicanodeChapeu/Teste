using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10;

            Console.WriteLine("Hello World");
            Console.WriteLine(x);

            Aluno aluno1 = new Aluno(321,"Alvaro", 2.2f);
            Aluno aluno2 = new Aluno(654, "Ryan", 0);
             

            Console.WriteLine(aluno1.id);
            Console.WriteLine($"O aluno 2 tem o ID {aluno2.id} e seu nome {aluno2.nome}");

            aluno1.ExibirResultado();

            Console.ReadLine();
        }
    }
}