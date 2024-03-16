namespace SomaDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar ao usuário que insira dois números inteiros
            Console.WriteLine("Digite o primeiro número inteiro:");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro:");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            // Calcular a soma dos números fornecidos
            int soma = numero1 + numero2;

            // Imprimir a soma dos números
            Console.WriteLine($"A soma de {numero1} e {numero2} é: {soma}");

            Console.ReadLine(); // Espera o usuário pressionar Enter antes de fechar a janela
        }
    }
}

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número inteiro:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro:");
            int numero2 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;

            Console.WriteLine($"A soma dos números fornecidos é: {soma}");
        }
    }
}

class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que insira um valor em metros
            Console.WriteLine("Digite um valor em metros:");
            double metros = double.Parse(Console.ReadLine());

            // Converte metros para milímetros (1 metro = 1000 milímetros)
            double milimetros = metros * 1000;

            // Exibe o valor em milímetros
            Console.WriteLine($"{metros} metros é equivalente a {milimetros} milímetros.");
        }
    }
}

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor atual do salário:");
            double salarioAtual = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual de aumento (em %):");
            double percentualAumento = double.Parse(Console.ReadLine());

            double valorAumento = salarioAtual * (percentualAumento / 100);

            double novoSalario = salarioAtual + valorAumento;

            Console.WriteLine($"Salário inicial: R${salarioAtual}");
            Console.WriteLine($"Percentual de aumento: {percentualAumento}%");
            Console.WriteLine($"Valor do aumento: R${valorAumento}");
            Console.WriteLine($"Novo salário: R${novoSalario}");
        }
    }
}

  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor atual da mercadoria:");
            double valorAtual = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual de desconto (em %):");
            double percentualDesconto = double.Parse(Console.ReadLine());

            double valorDesconto = valorAtual * (percentualDesconto / 100);

            double valorFinal = valorAtual - valorDesconto;

            Console.WriteLine($"Valor atual da mercadoria: R${valorAtual}");
            Console.WriteLine($"Percentual de desconto: {percentualDesconto}%");
            Console.WriteLine($"Valor do desconto: R${valorDesconto}");
            Console.WriteLine($"Valor final da mercadoria: R${valorFinal}");
        }
    }
}

class Program
    {
        static void Main(string[] args)
        {
            const double valorDiaria = 95.00;
            const double valorPorQuilometro = 0.35;

            Console.WriteLine("Digite o total de dias alugados:");
            int totalDias = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem inicial:");
            double quilometragemInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final:");
            double quilometragemFinal = double.Parse(Console.ReadLine());

            double totalQuilometrosPercorridos = quilometragemFinal - quilometragemInicial;
            double valorAluguelDiarias = totalDias * valorDiaria;
            double valorAluguelQuilometros = totalQuilometrosPercorridos * valorPorQuilometro;
            double valorTotalAluguel = valorAluguelDiarias + valorAluguelQuilometros;

            Console.WriteLine($"Valor do aluguel pelas diárias: R${valorAluguelDiarias:F2}");
            Console.WriteLine($"Valor do aluguel pelos quilômetros percorridos: R${valorAluguelQuilometros:F2}");
            Console.WriteLine($"Valor total do aluguel: R${valorTotalAluguel:F2}");
        }
    }
}

 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC (Índice de Massa Corporal)");
            Console.WriteLine("---------------------------------------------");

            // Solicitar ao usuário que insira seu peso em quilogramas
            Console.WriteLine("Digite seu peso (em kg):");
            double peso = double.Parse(Console.ReadLine());

            // Solicitar ao usuário que insira sua altura em metros
            Console.WriteLine("Digite sua altura (em metros):");
            double altura = double.Parse(Console.ReadLine());

            // Calcular o IMC (peso dividido pelo quadrado da altura)
            double imc = peso / (altura * altura);

            // Exibir o IMC
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            // Classificar o IMC de acordo com a tabela padrão
            if (imc < 18.5)
            {
                Console.WriteLine("Classificação: Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Classificação: Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else if (imc < 35)
            {
                Console.WriteLine("Classificação: Obesidade Grau I");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Classificação: Obesidade Grau II (severa)");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade Grau III (mórbida)");
            }
        }
    }
}

namespace MultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Múltiplos de 3 entre 0 e 100:");

            // Itera de 0 a 100 para verificar cada número
            for (int i = 0; i <= 100; i++)
            {
                // Verifica se o número atual é um múltiplo de 3
                if (i % 3 == 0)
                {
                    Console.WriteLine(i); // Imprime o múltiplo de 3
                }
            }
        }
    }
}

namespace Fatoriais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatoriais de 1 até 10:");

            // Itera de 1 a 10 para calcular e imprimir o fatorial de cada número
            for (int i = 1; i <= 10; i++)
            {
                long fatorial = CalcularFatorial(i);
                Console.WriteLine($"Fatorial de {i}: {fatorial}");
            }
        }

        // Método para calcular o fatorial de um número
        static long CalcularFatorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                long resultado = 1;
                for (int i = 2; i <= n; i++)
                {
                    resultado *= i;
                }
                return resultado;
            }
        }
    }
}