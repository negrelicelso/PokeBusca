using PokeBusca.Models;
using PokeBusca.Utils;
using System.Text.Json.Nodes;

namespace PokeBusca.Controllers
{
    public class PokemonController
    {
        public PokemonController() { }

        private static HttpClient clienteHttp = new()
        {
            BaseAddress = new Uri("https://pokeapi.co"),
        };

        public async Task<PokemonModel> BuscarPokemon(string inputPokemon)
        {
            try
            {
                // Faz a requisição GET
                HttpResponseMessage resposta = await clienteHttp.GetAsync($"/api/v2/pokemon/{inputPokemon}/");
                // Lança exceção se falhar
                resposta.EnsureSuccessStatusCode();

                // Lê o JSON como string

                string json = await resposta.Content.ReadAsStringAsync();
                JsonNode jsonSeparado = JsonNode.Parse(json);

                PokemonModel Pokemon = new PokemonModel();

                Pokemon.id = ((int)jsonSeparado["id"]);
                Pokemon.name = MetodosUteis.PrimeiraMaiuscula(jsonSeparado["name"].ToString());
                Pokemon.front_default = jsonSeparado["sprites"]?["front_default"]?.ToString();
                Pokemon.back_default = jsonSeparado["sprites"]?["back_default"]?.ToString();
                Pokemon.front_shiny = jsonSeparado["sprites"]?["front_shiny"]?.ToString();
                Pokemon.back_shiny = jsonSeparado["sprites"]?["back_shiny"]?.ToString();

                return Pokemon;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
