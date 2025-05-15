namespace PokeBusca.Models
{
    /*
     * Descrição:
     * Berries são pequenas frutas que provem HP e curam condições de status (Envenenamento, Congelamento, etc),
     * Melhorias de status e até mesmo negação de dano quando consumida por um Pokémon.
     */
    public class Berry : RecursoNomeado
    {
        internal new static string ApiEndpoint { get; } = "berry";

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
         * Campo 'growth_time' do registro. 
         * Tempo em horas que leva para uma arvore crescer um estágio.
         * As arvores de berries precisam passar por quatro desses estágios para poderem ser coletadas.
         */
        public int growth_time { get; set; }

        /*
         * Descrição:
         * Campo 'max_harvest' do registro.
         * Quantidade máxima de berries que pode ser coletada de uma arvore na Geração IV.
         */

        public int max_harvest { get; set; }

        /*
         * Descrição:
         * Campo 'natural_gift_power' do registro.
         * O dano do ataque 'Natural Gift' quando é utilizado com essa berry.
         */
        public int natural_gift_power { get; set; }

        /*
         * Descrição:
         * Campo 'size' do registro.
         * O tamanho em milimetros da berry.
         */
        public int size { get; set; }

        /*
         * Descrição:
         * Campo 'smoothness' do registro.
         * O quanto uma berry é macia. 
         * Usado para fazer Pokéblocks ou Poffins.
         */
        public int smoothness { get; set; }

        /*
         * Descrição:
         * Campo 'soil_dryness' do registro.
         * A velocidade que a berry seca o solo quando cresce.
         * Uma taxa maior significa que o solo seca mais rapidamente.
         */
        public int soil_dryness { get; set; }

        /*
         * Descrição:
         * Campo 'smoothness' do registro.
         * O quanto uma berry é firme. 
         * Usado para fazer Pokéblocks ou Poffins.
         */
        public RecursoNomeado<BerryFirmness> firmness { get; set; }
    }

    public class BerryFirmness : RecursoNomeado
    {
        internal new static string ApiEndpoint { get; } = "berry-firmness";

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
         * Lista de berries com a firmeza.
         */
        public List<RecursoNomeado<Berry>> berries { get; set; }

        /*
         * Descrição:
         * O nome desse registro em idiomas diferentes.
         */
        public List<Names> Names { get; set; }
    }
}
