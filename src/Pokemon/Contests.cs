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
    public class ContestType
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("berry_flavor")]
        public BerryFlavor BerryFlavor { get; set; }

        [JsonPropertyName("names")]
        public List<ContestName> Names { get; set; }

        public static string MostrarResultado(string json)
        {
            UtilitariosPoke utilitarios = new UtilitariosPoke();

            ContestType contesttype = JsonSerializer.Deserialize<ContestType>(json);

            string resultado = $"Id: {contesttype.Id}\n" +
                               $"Name: {utilitarios.CapitalizarPrimeiraLetra(contesttype.Name)}\n" +
                               $"Berry Flavor:\n" +
                               $"   Name: {utilitarios.CapitalizarPrimeiraLetra(contesttype.BerryFlavor.Name)}\n" +
                               $"Names:\n";

            for (int i = 0; i < contesttype.Names.Count; i++)
            {
                resultado += $"   [{i}]\n" +
                               $"       Name: {contesttype.Names[i].Name}\n" +
                               $"       Language:\n" +
                               $"           Name: {utilitarios.CapitalizarPrimeiraLetra(contesttype.Names[i].Language.Name)}\n";
            }

            return resultado;
        }
    }

    public class ContestName
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("language")]
        public Language Language { get; set; }
    }

    public class ContestEffect
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("appeal")]
        public int Appeal { get; set; }

        [JsonPropertyName("jam")]
        public int Jam { get; set; }

        [JsonPropertyName("effect_entries")]
        public List<Effects> EffectEntries { get; set; }

        [JsonPropertyName("flavor_text_entries")]
        public List<FlavorTexts> FlavorTextEntries { get; set; }

        public static string MostrarResultado(string json)
        {
            UtilitariosPoke utilitarios = new UtilitariosPoke();

            ContestEffect contesteffect = JsonSerializer.Deserialize<ContestEffect>(json);

            string resultado = $"Id: {contesteffect.Id}\n" +
                               $"Appeal: {contesteffect.Appeal}\n" +
                               $"Jam: {contesteffect.Jam}\n" +
                               $"Effect Entries:\n";

            for (int i = 0; i < contesteffect.EffectEntries.Count; i++)
            {
                resultado +=   $"   [{i}]\n" +
                               $"       Effect: {contesteffect.EffectEntries[i].Effect}\n" +
                               $"       Language:\n" +
                               $"           Name: {utilitarios.CapitalizarPrimeiraLetra(contesteffect.EffectEntries[i].Language.Name)}\n";
            }

            resultado +=       $"Flavor Text Entries:\n";

            for (int i = 0; i < contesteffect.FlavorTextEntries.Count; i++)
            {
                resultado +=   $"   [{i}]\n" +
                               $"       Flavor Text: {contesteffect.FlavorTextEntries[i].FlavorText}\n" +
                               $"       Language:\n" +
                               $"           Name: {utilitarios.CapitalizarPrimeiraLetra(contesteffect.FlavorTextEntries[i].Language.Name)}\n";
            }
            return resultado;
        }
    }

    public class SuperContestEffect
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("appeal")]
        public int Appeal { get; set; }

        [JsonPropertyName("flavor_text_entries")]
        public List<FlavorTexts> FlavorTextEntries { get; set; }

        //[JsonPropertyName("moves")]
        //public List<Move> Moves { get; set; }

        public static string MostrarResultado(string json)
        {
            UtilitariosPoke utilitarios = new UtilitariosPoke();

            SuperContestEffect supercontesteffect = JsonSerializer.Deserialize<SuperContestEffect>(json);

            string resultado = $"Id: {supercontesteffect.Id}\n" +
                               $"Appeal: {supercontesteffect.Appeal}\n" +
                               $"Flavor Text Entries:\n";

            for (int i = 0; i < supercontesteffect.FlavorTextEntries.Count; i++)
            {
                resultado +=   $"   [{i}]\n" +
                               $"       Flavor Text: {supercontesteffect.FlavorTextEntries[i].FlavorText}\n" +
                               $"       Language:\n" +
                               $"           Name: {utilitarios.CapitalizarPrimeiraLetra(supercontesteffect.FlavorTextEntries[i].Language.Name)}\n";
            }

            resultado +=       $"Moves:\n";

            /*
            for (int i = 0; i < supercontesteffect.Moves.Count; i++)
            {
                resultado += $"   [{i}]\n" +
                               $"       Name: {supercontesteffect.Moves[i].Name}\n";
            }
            */

            return resultado;
        }
    }
}
