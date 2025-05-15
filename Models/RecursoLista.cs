using System.Collections.Generic;

namespace PokeBusca
{
    /*
     * Descrição:
     * A classe base para todos os recursos que são listas
     */
    public abstract class ResourceList<T> where T : ResourceBase
    { 
        /*
         * Descrição:
         * O total de recursos disponiveis nessa API.
         */
        public int count { get; set; }

        /*
         * Descrição:
         * A URL para a próxima página na lista.
         */
        public string? next { get; set; }

        /*
         * Descrição:
         * A URL para a página anterior na lista.
         */
        public string? previous { get; set; }
    }

    /*
     * Descrição:
     * Um objeto de paginação para recursos não nomeados.
     */
    public class ApiResourceList<T> : ResourceList<T> where T : ApiResource<T>
    {
        /*
         * Descrição:
         * Uma lista dos recursos não nomeados.
         */
        public List<ApiResource<T>> results { get; set; }
    }

    /*
     * Descrição:
     * Um objeto de paginação para recursos nomeados.
     */
    public class NamedApiResourceList<T> : ResourceList<T> where T : NamedApiResource<T>
    {
        /*
         * Descrição:
         * Uma lista dos recursos nomeados.
         */
        public List<NamedApiResource<T>> results { get; set; }
    }
}
