using Microsoft.AspNetCore.Mvc.Razor;

namespace PokeBusca.Models
{
    public class ContestType : NamedApiResource<ContestType>
    {
        internal new static string ApiEndpoint { get; } = "contest-type";

        /* 
         * Descrição:
         * Campo 'id' do registro. 
         */
        public override int id { get; set; }

        /* 
         * Descrição:
         * Campo 'name' do registro. 
         */
        public override string name { get; set; }

        /*
         * Descrição:
         * O sabor de berry que se correlaciona com esse tipo de Contest.
         */
        public NamedApiResource<BerryFlavor> berry_flavor { get; set; }

        /*
         * Descrição:
         * O nome desse registro em idiomas diferentes.
         */
        public List<Names> names { get; set; }
    }

    public class ContestName
    {
        /*
         * Descrição:
         * O nome do contest.
         */
        public string name { get; set; }

        /*
         * Descrição:
         * A cor associada ao nome do contest.
         */
        public string color { get; set; }

        /*
         * Descrição:
         * O idioma que o nome do contest está.
         */
        public NamedApiResource<Language> language { get; set; }
    }

    public class ContestEffect : ApiResource<ContestEffect>
    {
        internal new static string ApiEndpoint { get; } = "contest-effect";

        /* 
         * Descrição:
         * O identificador do registro. 
         */
        public override int id { get; set; }

        /*
         * Descrição:
         * O número base de corações que o usuário do move ganha.
         */
        public int appeal { get; set; }

        /*
         * Descrição:
         * O número base de corações que o oponente do usuário perde.
         */
        public int jam { get; set; }



    }

}
