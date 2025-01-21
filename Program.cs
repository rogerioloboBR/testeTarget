//using System;
//using System.Collections.Generic;
//using System.IO;
//using Newtonsoft.Json;
//using System.Linq;
//using TesteTarget;

//var option = ShowMenu();

//do
//{
//    switch (option)
//    {
//        case "1":
//            CalcularFaturamento();
//            break;
//        case "2":
//            CalcularFibonacci();
//            break;
//        case "3":
//            InverterString();
//            break;
//        default:
//            Console.WriteLine("Opção inválida.");
//            break;
//    }

//    // Exibe o menu novamente
//    option = ShowMenu();

//} while (option != "4"); // O loop continua até o usuário escolher a opção "4" para sair

//static string ShowMenu()
//{
//    // Exibe o menu de opções
//    Console.Clear(); // Limpa a tela a cada exibição do menu
//    Console.WriteLine("Escolha uma opção:");
//    Console.WriteLine("1 - Calcular Faturamento");
//    Console.WriteLine("2 - Verificar Fibonacci");
//    Console.WriteLine("3 - Inverter String");
//    Console.WriteLine("4 - Sair");
//    Console.Write("Digite o número da opção: ");
//    return Console.ReadLine() ?? string.Empty;
//}

//// Método para calcular e exibir as métricas do faturamento
//static void CalcularFaturamento()
//{
//    // Lê o arquivo JSON
//    string json = File.ReadAllText(@"Resources\faturamento.json");

//    // Desserializa os dados do JSON
//    var faturamentoMensal = JsonConvert.DeserializeObject<List<FaturamentoModel>>(json);

//    // Filtra os dias com faturamento
//    var diasComFaturamento = faturamentoMensal.Where(f => f.Valor > 0).ToList();

//    // Menor valor de faturamento
//    var menorFaturamento = diasComFaturamento.Min(f => f.Valor);
//    Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");

//    // Maior valor de faturamento
//    var maiorFaturamento = diasComFaturamento.Max(f => f.Valor);
//    Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");

//    // Média de faturamento diário
//    var mediaFaturamento = diasComFaturamento.Average(f => f.Valor);
//    Console.WriteLine($"Média de faturamento diário: {mediaFaturamento}");

//    // Número de dias com faturamento superior à média
//    var diasAcimaMedia = diasComFaturamento.Count(f => f.Valor > mediaFaturamento);
//    Console.WriteLine($"Número de dias com faturamento superior à média: {diasAcimaMedia}");

//    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
//    Console.ReadKey();
//}

//// Método para verificar se um número pertence à sequência de Fibonacci
//static void CalcularFibonacci()
//{
//    Console.Write("Digite um número: ");
//    int numero = int.Parse(Console.ReadLine());

//    if (numero < 0)
//    {
//        Console.WriteLine("Número inválido. Digite um número não negativo.");
//        return;
//    }

//    // Variáveis para a sequência de Fibonacci
//    int a = 0, b = 1, proximo = 0;

//    // Verificando se o número informado é 0 ou 1 (casos especiais)
//    if (numero == 0 || numero == 1)
//    {
//        Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
//        return;
//    }

//    // Calculando a sequência de Fibonacci
//    while (proximo < numero)
//    {
//        proximo = a + b;
//        a = b;
//        b = proximo;
//    }

//    // Verificando se o número informado pertence à sequência
//    if (proximo == numero)
//    {
//        Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
//    }
//    else
//    {
//        Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
//    }

//    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
//    Console.ReadKey();
//}

//// Método para inverter a string
//static void InverterString()
//{
//    // Opção de string a ser invertida (pode ser entrada do usuário ou uma string definida no código)
//    Console.Write("Digite a string para inverter: ");
//    string input = Console.ReadLine();

//    if (string.IsNullOrEmpty(input))
//    {
//        Console.WriteLine("A string fornecida está vazia.");
//        return;
//    }

//    // Variável para armazenar a string invertida
//    string invertedString = string.Empty;

//    // Invertendo a string manualmente, iterando do final para o início
//    for (int i = input.Length - 1; i >= 0; i--)
//    {
//        invertedString += input[i]; // Adiciona o caractere na posição 'i' à nova string
//    }

//    // Exibe a string invertida
//    Console.WriteLine($"String invertida: {invertedString}");

//    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
//    Console.ReadKey();
//}
using System;
using TesteTarget;

var continuar = true;

while (continuar)
{
    var option = ShowMenu();

    switch (option)
    {
        case "1":
            var faturamento = new Faturamento();
            faturamento.CalcularFaturamento();
            break;
        case "2":
            var fibonacci = new Fibonacci();
            fibonacci.CalcularFibonacci();
            break;
        case "3":
            var stringInverter = new StringInverter();
            stringInverter.InverterString();
            break;
        case "0":
            continuar = false; // Sai do loop e encerra o programa
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    // Pausa para o usuário ler a saída antes de voltar ao menu
    if (continuar)
    {
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey(); // Aguarda o usuário pressionar uma tecla
    }
}

static string ShowMenu()
{
    // Exibe o menu de opções
    Console.Clear();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Calcular Faturamento");
    Console.WriteLine("2 - Verificar Fibonacci");
    Console.WriteLine("3 - Inverter String");
    Console.WriteLine("0 - Sair");
    Console.Write("Digite o número da opção: ");
    return Console.ReadLine() ?? string.Empty;
}
