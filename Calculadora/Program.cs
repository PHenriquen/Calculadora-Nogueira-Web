using System;

class Program
{
    static void Main()
    {
        bool rodando = true;

        while (rodando)
        {
            Console.Clear();
            Console.WriteLine("Calculadora Nogueira");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            string escolha = Console.ReadLine();

            if (escolha == "0")
            {
                rodando = false;
                continue;
            }

            Console.Write("Número 1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            if (escolha == "1")
            {
                Console.WriteLine("Resultado: " + Soma(n1, n2));
            }
            else if (escolha == "2")
            {
                Console.WriteLine("Resultado: " + Subtrair(n1, n2));
            }
            else if (escolha == "3")
            {
                Console.WriteLine("Resultado: " + Multiplicar(n1, n2));
            }
            else if (escolha == "4")
            {
                Console.WriteLine("Resultado: " + Dividir(n1, n2));
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }

            Console.WriteLine("Aperta Enter pra continuar...");
            Console.ReadLine();
        }
    }

    static double Soma(double a, double b)
    {
        return a + b;
    }

    static double Subtrair(double a, double b)
    {
        // fazer depois
        return 0;
    }

    static double Multiplicar(double a, double b)
    {
        // fazer depois
        return 0;
    }

    static double Dividir(double a, double b)
    {
        // fazer depois (lembrar de ver se b é diferente de 0)
        return 0;
    }
} 
