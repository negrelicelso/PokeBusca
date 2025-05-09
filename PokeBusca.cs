using System.Net;
using System.Net.Http;
using System.Text.Json;

namespace PokeBusca
{
    public partial class PokeBusca : Form
    {
        public PokeBusca()
        {
            InitializeComponent();
        }

        private static HttpClient testeConsumo = new()
        {
            BaseAddress = new Uri("https://pokeapi.co"),
        };

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Faz a requisição GET
                HttpResponseMessage resposta = await testeConsumo.GetAsync("/api/v2/pokemon/35/");
                resposta.EnsureSuccessStatusCode(); // Lança exceção se falhar

                // Lê o JSON como string
                string respostaJson = await resposta.Content.ReadAsStringAsync();

                // Exibe no RichTextBox
                textBox1.Text = respostaJson;

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true // Habilita indentação
                };

                // Desserializa e depois serializa novamente com formatação
                var objeto = JsonSerializer.Deserialize<object>(respostaJson);
                string jsonFormatado = JsonSerializer.Serialize(objeto, options);

                // (Opcional) Formata o JSON com indentação
                textBox1.Text = jsonFormatado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }



    /*     
    public static async Task Main(string[] args)
    {
        await GetAsync(testeConsumo);
    }

    static async Task GetAsync(HttpClient clienteHttp)
    {
        using HttpResponseMessage resposta = await clienteHttp.GetAsync("/api/v2/pokemon/35/");

        //resposta.EnsureSuccessStatusCode();

        if (resposta.StatusCode == HttpStatusCode.NotFound)
        {
            Console.WriteLine("Deu ruim! (Not Found)");
        }
        var respostaJson = await resposta.Content.ReadAsStringAsync();
        var options = new JsonSerializerOptions
        {
            WriteIndented = true // Habilita indentação
        };

        // Desserializa e depois serializa novamente com formatação
        var objeto = JsonSerializer.Deserialize<object>(respostaJson);
        string jsonFormatado = JsonSerializer.Serialize(objeto, options);
    }
    */
}
