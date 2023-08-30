using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario_base_tempo_de_serviço
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string salario_base, tempo_serviço;
            int temposerviço;
            double salariobase, salariofinal;

            Console.WriteLine("Ola, informe seu salario: ");
            salario_base = Console.ReadLine();
            Console.WriteLine("E agora informe seu tempo de serviço em nossa empresa (em anos)");
            tempo_serviço = Console.ReadLine();

            temposerviço = Int32.Parse(tempo_serviço);
            salariobase = double.Parse(salario_base);

            double imposto;

            salariofinal = salariobase;

            if (salariobase < 200)
            {
                imposto = 0;
                salariofinal = salariofinal - imposto;
            }
            else if (salariobase >= 200 && salariobase <= 450)
            {
                imposto = salariobase * 0.03;
                salariofinal = salariofinal - imposto;
            }
            else if (salariobase > 450 && salariobase < 700)
            {
                imposto = salariobase * 0.08;
                salariofinal = salariofinal - imposto;
            }
            else if (salariobase <= 700)
            {
                imposto = salariobase * 0.12;
                salariofinal = salariofinal - imposto;
            }

            int gratificacao;

            if (salariobase > 500 && temposerviço <= 3)
            {
                gratificacao = 20;
                salariofinal = salariofinal + gratificacao;
            }
            else if (salariobase > 500 && temposerviço > 3)
            {
                gratificacao = 30;
                salariofinal = salariofinal + gratificacao;
            }
            else if (salariobase <= 500 && temposerviço <= 3)
            {
                gratificacao = 23;
                salariofinal = salariofinal + gratificacao;
            }
            else if (salariobase <= 500 && temposerviço > 3 && temposerviço < 6)
            {
                gratificacao = 35;
                salariofinal = salariofinal + gratificacao;
            }
            else if (salariobase <= 500 && temposerviço <= 6)
            {
                gratificacao = 33;
                salariofinal = salariofinal + gratificacao;
            }

            if (salariofinal <= 350) 
            {
                Console.WriteLine("Seu salario final é de " + salariofinal + " classificado como A");
            }
            else if (salariofinal > 350 && salariofinal < 600)
            {
                Console.WriteLine("Seu salario final é de " + salariofinal + " classificado como B");
            }
            else if (salariofinal >= 600)
            {
                Console.WriteLine("Seu salario final é de " + salariofinal + " classificado como C");
            }

            Console.ReadKey();
        }
    }
}
