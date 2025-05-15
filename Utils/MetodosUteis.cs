namespace PokeBusca.Utils
{
    public static class MetodosUteis
    {
        public static string PrimeiraMaiuscula(string texto)
        {
            if (String.IsNullOrEmpty(texto))
                return "";

            texto = texto.ToLower();
            return Char.ToUpper(texto[0]) + texto.Substring(1);

        }
    }
}
