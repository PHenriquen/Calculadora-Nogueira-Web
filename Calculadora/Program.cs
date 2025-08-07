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

    // funções vão ser feitas por cada pessoa do grupo
    static double Soma(double a, double b)
    {
         static double Soma(double a, double b)
    {
        return a + b;
    }

    static double Subtrair(double a, double b)
    {
        // Solicita o primeiro número
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        // Solicita o segundo número
        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Realiza a subtração
        double resultado = numero1 - numero2;

        // Exibe o resultado
        Console.WriteLine($"O resultado da subtração é: {resultado}");
    }

    static double Multiplicar(double a, double b)
    {
        Console.Write("Digite o primeiro número: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double resultado = a * b;
        Console.WriteLine($"{a} x {b}: {resultado}");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
        return 0;
    }

    static double Dividir(double a, double b)
    {
       static double Dividir(double a, double b)
{
    if (b == 0)
    {
        Console.WriteLine("Erro: Divisão por zero não é permitida.");
        return 0; // ou você pode lançar uma exceção, dependendo do que preferir
    }

    return a / b;
}

