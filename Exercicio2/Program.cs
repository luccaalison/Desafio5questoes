using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main()
    {
        string apiUrl = "https://jsonmock.hackerrank.com/api/football_matches";
        int year = 2015;
        string teamName = "Galatasaray";

        using (HttpClient client = new HttpClient())
        {
            // Construa a URL da API com os parâmetros desejados
            string apiUrlWithParams = $"{apiUrl}?year={year}&team1={teamName}";

            // Faça a solicitação GET à API
            HttpResponseMessage response = await client.GetAsync(apiUrlWithParams);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject data = JsonConvert.DeserializeObject<JObject>(responseBody);

                // Extraia os dados relevantes da resposta da API
                JArray matches = data["data"] as JArray;

                if (matches != null)
                {
                    int totalGoals = 0;

                    foreach (var match in matches)
                    {
                        int team1Goals = (int)match["team1goals"];
                        int team2Goals = (int)match["team2goals"];

                        // Verifique se o time Galatasaray estava jogando
                        if ((string)match["team1"] == teamName)
                        {
                            totalGoals += team1Goals;
                        }
                        else if ((string)match["team2"] == teamName)
                        {
                            totalGoals += team2Goals;
                        }
                    }

                    Console.WriteLine($"Time {teamName} scored {totalGoals} goals in {year}");
                }
                else
                {
                    Console.WriteLine("Nenhuma partida encontrada para o ano e time especificados.");
                }
            }
            else
            {
                Console.WriteLine("Falha ao acessar a API.");
            }
        }
    }
}
