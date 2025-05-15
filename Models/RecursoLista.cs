using System.Collections.Generic;

namespace PokeBusca.Models
{
    /*
     * Descrição:
     * A classe base para todos os recursos que são listas
     */
    public abstract class RecursoLista<T> where T : RecursoBase
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
    public class Lista<T> : RecursoLista<T> where T : Recurso
    {
        /*
         * Descrição:
         * Uma lista dos recursos não nomeados.
         */
        public List<Recurso/*<T>*/> results { get; set; }
    }

    /*
     * Descrição:
     * Um objeto de paginação para recursos nomeados.
     */
    public class ListaNomeada<T> : RecursoLista<T> where T : RecursoNomeado
    {
        /*
         * Descrição:
         * Uma lista dos recursos nomeados.
         */
        public List<RecursoNomeado/*<T>*/> results { get; set; }
    }
}
