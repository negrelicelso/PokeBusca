using System.ComponentModel;

namespace PokeBusca.Models
{
    public class Pokemon
    {
        [DisplayName("Número")]
        public int id { get; set; }

        [DisplayName("Nome")]
        public string name { get; set; }

        [DisplayName("Sprite Frontal Padrão")]
        public string front_default { get; set; }

        [DisplayName("Sprite Traseiro Padrão")]
        public string back_default { get; set; }

        [DisplayName("Sprite Frontal Shiny")]
        public string front_shiny { get; set; }

        [DisplayName("Sprite Traseiro Shiny")]
        public string back_shiny { get; set; }
    }
}
