using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTarget
{
    public class Faturamento
    {
        // Método para calcular e exibir as métricas do faturamento
        public void CalcularFaturamento()
        {
            // Lê o arquivo JSON
            string json = File.ReadAllText(@"Resources\faturamento.json");

            // Desserializa os dados do JSON
            var faturamentoMensal = JsonConvert.DeserializeObject<List<FaturamentoModel>>(json);

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
    }
}