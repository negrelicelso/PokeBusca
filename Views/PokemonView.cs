using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

using PokeBusca.Models;
using PokeBusca.Presenters;

namespace PokeBusca.Views
{
    public partial class PokemonView : Form
    {
        private PokemonPresenter presenter;
        public PokemonView()
        {
            InitializeComponent();
            presenter = new PokemonPresenter(this);
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            InicioView.FecharAba("Pokémon");
            this.Close();
        }

        private async void buttonBusca_Click(object sender, EventArgs e)
        {
            PokemonModel PokemonRetornado = new PokemonModel();
            PokemonRetornado = await presenter.BuscarPokemon(textBoxBusca.Text);
            pictureBoxSprite.ImageLocation = PokemonRetornado.front_default;
        }
    }
}
