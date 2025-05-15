namespace PokeBusca
{
    /*
     * Descrição:
     * A classe base para as classes que tem um Endpoint definido na API.
     */
    public abstract class ResourceBase
    {
        /*
         * Descrição:
         * O Endpoint do registro.
         */
        public static string ApiEndpoint { get; }

        /*
         * Descrição:
         * Campo que define se o Endpoint da API é case sensitive
         */
        public static bool ApiEndpointCaseSensitive { get; }

        /* 
         * Descrição:
         * Campo 'id' do registro. 
         */
        public abstract int id { get; set; }
    }

    /*
     * Descrição:
     * A classe base para os recursos que tem um nome.
     */
    public abstract class NamedApiResource<T> : ResourceBase
    {

        public T attributes { get; set; }

        /* 
         * Descrição:
         * Campo 'name' do registro. 
         */
        public abstract string name { get; set; }
    }

    /*
     * Descrição:
     * A classe base para os recursos que não tem um nome.
     */
    public abstract class ApiResource<T> : ResourceBase
    {
        public T attributes { get; set; }
    }
}
