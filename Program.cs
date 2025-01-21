using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

var option = ShowMenu();

switch (option)
{
    case "1":
        CalcularFaturamento();
        break;
    case "2":
        CalcularFibonacci();
        break;
    case "3":
        InverterString();
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}

static string ShowMenu()
{
    // Exibe o menu de opções
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Calcular Faturamento");
    Console.WriteLine("2 - Calcular Sequência Fibonacci");
    Console.WriteLine("3 - Inverter String");
    Console.Write("Digite o número da opção: ");
    return Console.ReadLine() ?? string.Empty;
}

// Método para calcular e exibir as métricas do faturamento
static void CalcularFaturamento()
{
    // Lê o arquivo JSON
    string json = File.ReadAllText(@"Resources\faturamento.json");


    // Desserializa os dados do JSON
    var faturamentoMensal = JsonConvert.DeserializeObject<List<Faturamento>>(json);

    // Filtra os dias com faturamento
    var diasComFaturamento = faturamentoMensal.Where(f => f.Valor > 0).ToList();

    // Menor valor de faturamento
    var menorFaturamento = diasComFaturamento.Min(f => f.Valor);
    Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");

    // Maior valor de faturamento
    var maiorFaturamento = diasComFaturamento.Max(f => f.Valor);
    Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");

    // Média de faturamento diário
    var mediaFaturamento = diasComFaturamento.Average(f => f.Valor);
    Console.WriteLine($"Média de faturamento diário: {mediaFaturamento}");

    // Número de dias com faturamento superior à média
    var diasAcimaMedia = diasComFaturamento.Count(f => f.Valor > mediaFaturamento);
    Console.WriteLine($"Número de dias com faturamento superior à média: {diasAcimaMedia}");
}

// Método para calcular a sequência de Fibonacci
static void CalcularFibonacci()
{
    Console.Write("Digite o número de termos da sequência de Fibonacci: ");
    int n = int.Parse(Console.ReadLine());

    List<int> fibonacci = new List<int>();

    // Condições iniciais
    fibonacci.Add(0); // O primeiro número
    if (n > 1)
    {
        fibonacci.Add(1); // O segundo número
    }

    // Calcula a sequência de Fibonacci
    for (int i = 2; i < n; i++)
    {
        int proximo = fibonacci[i - 1] + fibonacci[i - 2];
        fibonacci.Add(proximo);
    }

    // Exibe a sequência de Fibonacci
    Console.WriteLine("Sequência de Fibonacci:");
    foreach (var num in fibonacci)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

// Método para inverter a string
static void InverterString()
{
    Console.Write("Digite a string para inverter: ");
    string input = Console.ReadLine();

    if (!string.IsNullOrEmpty(input))
    {
        // Usa o método de Array.Reverse para inverter os caracteres da string
        char[] array = input.ToCharArray();
        Array.Reverse(array);
        string invertedString = new string(array);
        Console.WriteLine($"String invertida: {invertedString}");
    }
    else
    {
        Console.WriteLine("A string fornecida está vazia.");
    }
}

// Classe para representar os dados de faturamento
public class Faturamento
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}
