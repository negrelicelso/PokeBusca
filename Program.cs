using PokeBusca.Views;

namespace PokeBusca
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new PokemonView());
        }
    }
}