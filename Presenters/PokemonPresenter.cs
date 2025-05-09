using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

using PokeBusca.Models;
using PokeBusca.Views;

namespace PokeBusca.Presenters
{
    public class PokemonPresenter
    {
        private readonly PokemonView view;

        public PokemonPresenter(PokemonView _view)
        {
            view = _view;
            view.Show();
        }

        private static HttpClient clienteHttp = new()
        {
            BaseAddress = new Uri("https://pokeapi.co"),
        };

        public async Task<PokemonModel> BuscarPokemon(string textBoxBuscar)
        {
            try
            {
                // Faz a requisição GET
                HttpResponseMessage resposta = await clienteHttp.GetAsync($"/api/v2/pokemon/{textBoxBuscar}/");
                // Lança exceção se falhar
                resposta.EnsureSuccessStatusCode(); 

                // Lê o JSON como string
                
                string json = await resposta.Content.ReadAsStringAsync();
                JsonNode jsonSeparado = JsonNode.Parse(json);
                /*
                var opcoes = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true, // Ignora maiúsculas/minúsculas
                };

                PokemonModel Pokemon = JsonSerializer.Deserialize<PokemonModel>(respostaJson, opcoes);
                */
                PokemonModel Pokemon = new PokemonModel();

                Pokemon.id = ((int)jsonSeparado["id"]);
                Pokemon.name = jsonSeparado["name"].ToString();
                Pokemon.front_default = jsonSeparado["sprites"]?["front_default"]?.ToString();

                return Pokemon;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Erro na Requisição: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Erro no JSON: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
