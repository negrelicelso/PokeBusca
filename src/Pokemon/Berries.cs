using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using PokeBusca.Utilitarios;

namespace PokeBusca.Pokemon
{
    public class Berries
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("growth_time")]
        public int GrowthTime { get; set; }

        [JsonPropertyName("max_harvest")]
        public int MaxHarvest { get; set; }

        [JsonPropertyName("natural_gift_power")]
        public int NaturalGiftPower { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("smoothness")]
        public int Smoothness { get; set; }

        [JsonPropertyName("soil_dryness")]
        public int SoilDryness { get; set; }

        [JsonPropertyName("firmness")]
        public BerryFirmness Firmness { get; set; }

        [JsonPropertyName("flavors")]
        public List<BerryFlavorMap> Flavors { get; set; }

        //[JsonPropertyName("item")]
        //public Item Item { get; set; }

        //[JsonPropertyName("natural_gift_type")]
        //public Type NaturalGiftType { get; set; }

        public static string MostrarResultado(string json)
        {
            UtilitariosPoke utilitarios = new UtilitariosPoke();

            Berries berry = JsonSerializer.Deserialize<Berries>(json);

            string resultado = $"Id: {berry.Id}\n" +
                               $"Name: {utilitarios.CapitalizarPrimeiraLetra(berry.Name)}\n" +
                               $"Growth Time: {berry.GrowthTime}\n" +
                               $"Max Harvest: {berry.MaxHarvest}\n" +
                               $"Natural Gift Power: {berry.NaturalGiftPower}\n" +
                               $"Size: {berry.Size}\n" +
                               $"Smoothness: {berry.Smoothness}\n" +
                               $"Soil Dryness: {berry.SoilDryness}\n" +
                               $"Firmness:\n" +
                               $"   Name: {utilitarios.CapitalizarPrimeiraLetra(berry.Firmness.Name)}\n" +
                               $"Flavors:\n";

            for (int i = 0; i < berry.Flavors.Count; i++)
            {
                resultado +=   $"   [{i}]\n" +
                               $"       Potency: {berry.Flavors[i].Potency}\n" +
                               $"       Flavor: {berry.Flavors[i].Flavor.Name}\n";
            }
            return resultado;
        }
    }

    public class BerryFirmness
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("berries")]
        public List<Berries> Berries { get; set; }

        [JsonPropertyName("names")]
        public List<Names> Names { get; set; }

        public static string MostrarResultado(string json)
        {
            UtilitariosPoke utilitarios = new UtilitariosPoke();

            BerryFirmness berryfirmness = JsonSerializer.Deserialize<BerryFirmness>(json);

            string resultado = $"Id: {berryfirmness.Id}\n" +
                               $"Name: {utilitarios.CapitalizarPrimeiraLetra(berryfirmness.Name)}\n" +
                               $"Berries:\n";

            for (int i = 0; i < berryfirmness.Berries.Count; i++)
            {
                resultado +=   $"   [{i}]\n" +
                               $"       Name: {utilitarios.CapitalizarPrimeiraLetra(berryfirmness.Berries[i].Name)}\n";
            }

            for (int i = 0; i < berryfirmness.Names.Count; i++)
            {
                resultado += $"   [{i}]\n" +
                               $"       Name: {berryfirmness.Names[i].Name}\n" +
                               $"       Language:\n" +
                               $"           Name: {utilitarios.CapitalizarPrimeiraLetra(berryfirmness.Names[i].Language.Name)}\n";
            }
            return resultado;
        }
    }

    public class BerryFlavor
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("berries")]
        public List<FlavorBerryMap> Berries { get; set; }

        [JsonPropertyName("contest_type")]
        public ContestType ContestType { get; set; }

        [JsonPropertyName("names")]
        public List<Names> Names { get; set; }

        public static string MostrarResultado(string json)
        {
            UtilitariosPoke utilitarios = new UtilitariosPoke();

            BerryFlavor berryflavor = JsonSerializer.Deserialize<BerryFlavor>(json);

            string resultado = $"Id: {berryflavor.Id}\n" +
                               $"Name: {utilitarios.CapitalizarPrimeiraLetra(berryflavor.Name)}\n" +
                               $"Berries:\n";

            for (int i = 0; i < berryflavor.Berries.Count; i++)
            {
                resultado +=   $"   [{i}]\n" +
                               $"       Potency: {berryflavor.Berries[i].Potency}\n" +
                               $"       Berry: {utilitarios.CapitalizarPrimeiraLetra(berryflavor.Berries[i].Berry.Name)}\n";
            }

            resultado +=       $"Contest Type:\n" +
                               $"   Name: {utilitarios.CapitalizarPrimeiraLetra(berryflavor.ContestType.Name)}\n";

            for (int i = 0; i < berryflavor.Names.Count; i++)
            {
                resultado +=   $"   [{i}]\n" +
                               $"       Name: {berryflavor.Names[i].Name}\n" +
                               $"       Language:\n" +
                               $"           Name: {utilitarios.CapitalizarPrimeiraLetra(berryflavor.Names[i].Language.Name)}\n";
            }
            return resultado;
        }
    }

    public class BerryFlavorMap
    {
        [JsonPropertyName("potency")]
        public int Potency { get; set; }

        [JsonPropertyName("flavor")]
        public BerryFlavor Flavor { get; set; }
    }

    public class FlavorBerryMap
    {
        [JsonPropertyName("potency")]
        public int Potency { get; set; }

        [JsonPropertyName("berry")]
        public Berries Berry { get; set; }
    }
}
