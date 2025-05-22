using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using PokeBusca.Pokemon;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static readonly HttpClient client = new HttpClient();

    static async Task<string> Requisicao(string endpoint)
    {
        // Definindo a URL da API
        string apiUrl = "https://pokeapi.co/api/v2/";

        // Fazendo a requisição GET
        HttpResponseMessage response = await client.GetAsync(apiUrl + endpoint);

        // Verificando se a requisição foi bem-sucedida
        response.EnsureSuccessStatusCode();

        // Lendo o conteúdo da resposta
        string responseBody = await response.Content.ReadAsStringAsync();

        return responseBody;
    }

    static async Task Main(string[] args)
    {
        try
        {
            Console.WriteLine("* ---------------------------------------------- *");
            Console.WriteLine("|            Bem vindos ao PokéBusca!            |");
            Console.WriteLine("* ---------------------------------------------- *");

            Console.WriteLine("Selecione uma das opções disponíveis digitando apenas o número respectivo da opção.");
            Console.WriteLine("1. Berry\n" +
                              "2. Berry Firmness\n" +
                              "3. Berry Flavor\n" +
                              "4. Contest Type\n" +
                              "5. Contest Effect\n" +
                              "6. Super Contest Effect\n");

            int opcao = Convert.ToInt32(Console.ReadLine());
            string endpoint = "";
            string resposta = "";

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    endpoint += "berry/";

                    Console.WriteLine("Digite o nome ou o número da Berry desejada:");
                    string opcaoBerry = Console.ReadLine();
                    Console.Clear();

                    endpoint += opcaoBerry;

                    resposta = await Requisicao(endpoint);

                    Berries berry = new Berries();

                    Console.WriteLine(Berries.MostrarResultado(resposta));

                    break;

                case 2:
                    endpoint += "berry-firmness/";

                    Console.WriteLine("Digite o nome ou o número da Berry Firmness desejada:");
                    string opcaoBerryFirmness = Console.ReadLine();
                    Console.Clear();

                    endpoint += opcaoBerryFirmness;

                    resposta = await Requisicao(endpoint);

                    BerryFirmness berryfirmness = new BerryFirmness();

                    Console.WriteLine(BerryFirmness.MostrarResultado(resposta));

                    break;

                case 3:
                    endpoint += "berry-flavor/";

                    Console.WriteLine("Digite o nome ou o número da Berry Flavor desejada:");
                    string opcaoBerryFlavor = Console.ReadLine();
                    Console.Clear();

                    endpoint += opcaoBerryFlavor;

                    resposta = await Requisicao(endpoint);

                    BerryFlavor berryflavor = new BerryFlavor();

                    Console.WriteLine(BerryFlavor.MostrarResultado(resposta));

                    break;

                case 4:
                    endpoint += "contest-type/";

                    Console.WriteLine("Digite o nome ou o número do Contest Type desejada:");
                    string opcaoContestType = Console.ReadLine();
                    Console.Clear();

                    endpoint += opcaoContestType;

                    resposta = await Requisicao(endpoint);

                    ContestType contesttype = new ContestType();

                    Console.WriteLine(ContestType.MostrarResultado(resposta));

                    break;

                case 5:
                    endpoint += "contest-effect/";

                    Console.WriteLine("Digite o nome ou o número do Contest Effect desejada:");
                    string opcaoContestEffect = Console.ReadLine();
                    Console.Clear();

                    endpoint += opcaoContestEffect;

                    resposta = await Requisicao(endpoint);

                    ContestEffect contesteffect = new ContestEffect();

                    Console.WriteLine(ContestEffect.MostrarResultado(resposta));

                    break;

                case 6:
                    endpoint += "super-contest-effect/";

                    Console.WriteLine("Digite o nome ou o número do Contest Effect desejada:");
                    string opcaoSuperContestEffect = Console.ReadLine();
                    Console.Clear();

                    endpoint += opcaoSuperContestEffect;

                    resposta = await Requisicao(endpoint);

                    SuperContestEffect supercontesteffect = new SuperContestEffect();

                    Console.WriteLine(SuperContestEffect.MostrarResultado(resposta));

                    break;

                case 99:
                    endpoint += "language/";

                    Console.WriteLine("Digite o nome ou o número da Language desejada:");
                    string opcaoLanguage = Console.ReadLine();
                    Console.Clear();

                    endpoint += opcaoLanguage;

                    resposta = await Requisicao(endpoint);

                    Language language = new Language();

                    Console.WriteLine(Language.MostrarResultado(resposta));
                    break;
            }


        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Erro na requisição: {e.Message}");
        }
        catch (JsonException e)
        {
            Console.WriteLine($"Erro ao desserializar JSON: {e.Message}");
        }
    }
}