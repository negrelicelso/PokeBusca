using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace PokeBusca.Models
{
    public class PokemonModel
    {
        [DisplayName("Número")]
        public int id { get; set; }

        [DisplayName("Nome")]
        public string name { get; set; }
    }
}
