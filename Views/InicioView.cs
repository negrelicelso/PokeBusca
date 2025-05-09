using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeBusca.Views
{
    public partial class InicioView : Form
    {
        public InicioView()
        {
            InitializeComponent();
            instancia = this;
        }

        public static InicioView instancia;

        public static InicioView FecharAba(string titulo)
        {
            instancia.tabControlTelas.TabPages.Remove(instancia.tabControlTelas.SelectedTab);
            return instancia;
        }

        private void AbrirAba(Form formulario, string titulo)
        {
            TabPage novaAba = new TabPage(titulo);

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.Visible = true;

            novaAba.Controls.Add(formulario);

            tabControlTelas.TabPages.Add(novaAba);
            tabControlTelas.SelectedTab = novaAba;
        }

        private bool AbaExistente(string titulo)
        {
            foreach (TabPage aba in tabControlTelas.TabPages)
            {
                if (aba.Text == titulo)
                {
                    tabControlTelas.SelectedTab = aba;
                    return true;
                }
            }
            return false;
        }

        private void toolStripMenuPokemonPokemon_Click(object sender, EventArgs e)
        {
            if (AbaExistente("Pokémon") == false)
            {
                PokemonView form = new PokemonView();
                AbrirAba(form, "Pokémon");
            }
        }
    }
}
