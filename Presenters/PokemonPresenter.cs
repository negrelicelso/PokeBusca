using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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
                string respostaJson = await resposta.Content.ReadAsStringAsync();

                var opcoes = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true, // Ignora maiúsculas/minúsculas
                    WriteIndented = true // Habilita indentação
                };

                PokemonModel Pokemon = JsonSerializer.Deserialize<PokemonModel>(respostaJson, opcoes);

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
