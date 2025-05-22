using PokeBusca.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeBusca.Pokemon
{
    public class Language
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("official")]
        public bool Official { get; set; }

        [JsonPropertyName("iso639")]
        public string Iso639 { get; set; }

        [JsonPropertyName("iso3166")]
        public string Iso3166 { get; set; }

        [JsonPropertyName("names")]
        public List<Names> Names { get; set; }

        public static string MostrarResultado(string json)
        {
            UtilitariosPoke utilitarios = new UtilitariosPoke();

            Language language = JsonSerializer.Deserialize<Language>(json);

            string resultado = $"Id: {language.Id}\n" +
                               $"Name: {utilitarios.CapitalizarPrimeiraLetra(language.Name)}\n" +
                               $"Official: {utilitarios.CapitalizarPrimeiraLetra(language.Official.ToString())}\n" +
                               $"Iso639: {utilitarios.CapitalizarPrimeiraLetra(language.Iso639)}\n" +
                               $"Iso3166: {utilitarios.CapitalizarPrimeiraLetra(language.Iso3166)}\n" +
                               $"Names:\n";
            for (int i = 0; i < language.Names.Count; i++)
            {
                resultado +=   $"   [{i}]\n" +
                               $"       Name: {language.Names[i].Name}\n" +
                               $"       Language:\n" +
                               $"           Name: {utilitarios.CapitalizarPrimeiraLetra(language.Names[i].Language.Name)}\n";
            }
            return resultado;
        }
    }
}
