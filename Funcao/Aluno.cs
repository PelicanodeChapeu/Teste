using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcao
{
    public class Aluno
    {

        public int id;
        public string nome;
        private float nota;
        private bool resultado;

        public Aluno(int id, string nome, float nota)
        {
            this.id = id;
            this.nome = nome;
            this.nota = nota;
            this.resultado = ResultadoProva(nota);
        }

        public bool ResultadoProva(float nota) 
        {
            bool result = false;
            if (nota >= 5)
            {
                result = true;
            }

            return result;
        
        }

        public void ExibirResultado()
        {
            if (this.resultado == true)
            {
             Console.WriteLine($"Parabéns pela aprovação! Sua nota foi {this.nota}"); 
            }
            else
            {
                Console.WriteLine($"Você foi reprovado. Sua nota foi {this.nota}");
             
            }
            
            //Console.WriteLine(this.resultado ? "Parabéns você foi aprovado : "Você foi reprovado);" Então esse linha resume ? -> IF e : -> Else
        }
    }
}

