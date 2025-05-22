using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeBusca.Pokemon
{
    public class ApiResource
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Descriptions
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("language")]
        public Language Language { get; set; }
    }

    public class Effects
    {
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("language")]
        public Language Language { get; set; }
    }

    public class Encounter
    {
        [JsonPropertyName("min_level")]
        public int MinLevel { get; set; }

        [JsonPropertyName("max_level")]
        public int MaxLevel { get; set; }

        //[JsonPropertyName("condition_values")]
        //public List<EncounterConditionValue> ConditionValues { get; set; }

        [JsonPropertyName("chance")]
        public int Chance { get; set; }

        //[JsonPropertyName("method")]
        //public EncounterMethod Method { get; set; }
    }

    public class FlavorTexts
    {
        [JsonPropertyName("flavor_text")]
        public string FlavorText { get; set; }

        [JsonPropertyName("language")]
        public Language Language { get; set; }

        //[JsonPropertyName("version")]
        //public Versions Version { get; set; }
    }

    public class GenerationGameIndex
    {
        [JsonPropertyName("game_index")]
        public int GameIndex { get; set; }

        //[JsonPropertyName("generation")]
        //public Generation Generation { get; set; }
    }

    public class MachineVersionDetail
    {
        //[JsonPropertyName("machine")]
        //public Machine Machine { get; set; }

        //[JsonPropertyName("version_group")]
        //public VersionGroup VersionGroup { get; set; }
    }

    public class Names
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("language")]
        public Language Language { get; set; }
    }

    public class NamedApiResources
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class VerboseEffect
    {
        [JsonPropertyName("effect")]
        public string Effect { get; set; }

        [JsonPropertyName("short_effect")]
        public string ShortEffect { get; set; }

        [JsonPropertyName("language")]
        public Language Language { get; set; }
    }

    public class VersionEncounterDetail
    {
        //[JsonPropertyName("version")]
        //public Versions Version { get; set; }

        [JsonPropertyName("max_chance")]
        public int MaxChance { get; set; }

        //[JsonPropertyName("encounter_details")]
        //public List<Encounters> EncounterDetails { get; set; }
    }

    public class VersionGameIndex
    {
        [JsonPropertyName("game_index")]
        public int GameIndex { get; set; }

        //[JsonPropertyName("version")]
        //public Versions Version { get; set; }
    }

    public class VersionGroupFlavorText
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("language")]
        public Language Language { get; set; }

        //[JsonPropertyName("version_group")]
        //public VersionGroup VersionGroup { get; set; }
    }
}
