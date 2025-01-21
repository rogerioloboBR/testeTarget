using System;

public class StringInverter
{
    // Método para inverter a string
    public void InverterString()
    {
        Console.Write("Digite a string para inverter: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("A string fornecida está vazia.");
            return;
        }

        // Variável para armazenar a string invertida
        string invertedString = string.Empty;

        // Invertendo a string manualmente, iterando do final para o início
        for (int i = input.Length - 1; i >= 0; i--)
        {
            invertedString += input[i]; // Adiciona o caractere na posição 'i' à nova string
        }

        // Exibe a string invertida
        Console.WriteLine($"String invertida: {invertedString}");
    }
}
