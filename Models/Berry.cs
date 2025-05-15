using System.Collections.Generic;

namespace PokeBusca.Models
{
    /*
     * Descrição:
     * Berries são pequenas frutas que provem HP e curam condições de status (Envenenamento, Congelamento, etc),
     * Melhorias de status e até mesmo negação de dano quando consumida por um Pokémon.
     */
    public class Berry : NamedApiResource<Berry>
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
         * Campo 'firmness' do registro.
         * O quanto uma berry é firme. 
         * Usado para fazer Pokéblocks ou Poffins.
         */
        public NamedApiResource<BerryFirmness> firmness { get; set; }

        /*
        * Descrição:
        * Campo 'flavors' do registro.
        * Uma lista de referência para cada sabor que uma berry pode ter e a potência que cada sabor para a berry.
        */
        public List<BerryFlavorMap> flavors { get; set; }

        /*
         * Descrição:
         * Campo 'item' do registro.
         * Berries são itens, essa é a referencia para o dado do item especifico para essa berry.
         */
        public NamedApiResource<Item> item { get; set; }

        /*
         * Descrição:
         * Campo 'natural_gift_type' do registro.
         * O tipo herdado do 'Natural Gift' quando usado com essa berry;
         */
        public NamedApiResource<Tipo> natural_gift_type { get; set; }

    }

    public class BerryFirmness : NamedApiResource<BerryFirmness>
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
        public List<NamedApiResourceList<Berry>> berries { get; set; }

        /*
         * Descrição:
         * O nome desse registro em idiomas diferentes.
         */
        public List<Names> Names { get; set; }
    }

    public class BerryFlavorMap
    {
        /*
         * Descrição:
         * O quão forte é o sabor referenciado para essa berry.
         */
        public int potency { get; set; }

        /*
         * Descrição:
         * O sabor referenciado da berry.
         */
        public NamedApiResource<BerryFlavor> flavor { get; set; }
    }

    public class FlavorBerryMap
    {
        /*
         * Descrição:
         * O quão forte é o sabor referenciado para essa berry.
         */
        public int potency { get; set; }

        /*
         * Descrição:
         * A berry referenciada para o sabor.
         */
        public NamedApiResource<Berry> berry { get; set; }
    }

    public class BerryFlavor : NamedApiResource<BerryFlavor>
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
         * Uma lista com as berries com esse sabor.
         */
        public List<FlavorBerryMap> berries { get; set; }

        /*
         * Descrição:
         * O tipo de Contest que se correlaciona com esse sabor.
         */
        public NamedApiResource<ContestType> contest_type { get; set; }

        /*
         * Descrição:
         * O nome desse registro em idiomas diferentes.
         */
        public List<Names> Names { get; set; }
    }
}
