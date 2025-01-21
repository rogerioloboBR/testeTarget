using System;

public class Fibonacci
{
    // Método para verificar se um número pertence à sequência de Fibonacci
    public void CalcularFibonacci()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Número inválido. Digite um número não negativo.");
            return;
        }

        // Variáveis para a sequência de Fibonacci
        int a = 0, b = 1, proximo = 0;

        // Verificando se o número informado é 0 ou 1 (casos especiais)
        if (numero == 0 || numero == 1)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            return;
        }

        // Calculando a sequência de Fibonacci
        while (proximo < numero)
        {
            proximo = a + b;
            a = b;
            b = proximo;
        }

        // Verificando se o número informado pertence à sequência
        if (proximo == numero)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }
}
