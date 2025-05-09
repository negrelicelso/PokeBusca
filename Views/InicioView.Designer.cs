namespace PokeBusca.Views
{
    partial class InicioView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripHeader = new MenuStrip();
            toolStripMenuPokemon = new ToolStripMenuItem();
            toolStripMenuPokemonPokemon = new ToolStripMenuItem();
            tabControlTelas = new TabControl();
            menuStripHeader.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripHeader
            // 
            menuStripHeader.BackColor = SystemColors.ControlDark;
            menuStripHeader.GripMargin = new Padding(0);
            menuStripHeader.Items.AddRange(new ToolStripItem[] { toolStripMenuPokemon });
            menuStripHeader.Location = new Point(0, 0);
            menuStripHeader.Name = "menuStripHeader";
            menuStripHeader.Size = new Size(784, 24);
            menuStripHeader.TabIndex = 0;
            menuStripHeader.Text = "menuStrip1";
            // 
            // toolStripMenuPokemon
            // 
            toolStripMenuPokemon.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuPokemonPokemon });
            toolStripMenuPokemon.Name = "toolStripMenuPokemon";
            toolStripMenuPokemon.Padding = new Padding(0);
            toolStripMenuPokemon.Size = new Size(62, 20);
            toolStripMenuPokemon.Text = "Pokémon";
            // 
            // toolStripMenuPokemonPokemon
            // 
            toolStripMenuPokemonPokemon.Name = "toolStripMenuPokemonPokemon";
            toolStripMenuPokemonPokemon.Size = new Size(180, 22);
            toolStripMenuPokemonPokemon.Text = "Pokémon";
            toolStripMenuPokemonPokemon.Click += toolStripMenuPokemonPokemon_Click;
            // 
            // tabControlTelas
            // 
            tabControlTelas.Dock = DockStyle.Fill;
            tabControlTelas.Location = new Point(0, 24);
            tabControlTelas.Margin = new Padding(0);
            tabControlTelas.Name = "tabControlTelas";
            tabControlTelas.SelectedIndex = 0;
            tabControlTelas.Size = new Size(784, 537);
            tabControlTelas.TabIndex = 1;
            // 
            // InicioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(tabControlTelas);
            Controls.Add(menuStripHeader);
            MainMenuStrip = menuStripHeader;
            Name = "InicioView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PokeBusca | Versão: 1.0";
            WindowState = FormWindowState.Maximized;
            menuStripHeader.ResumeLayout(false);
            menuStripHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripHeader;
        private ToolStripMenuItem toolStripMenuPokemon;
        private TabControl tabControlTelas;
        private ToolStripMenuItem toolStripMenuPokemonPokemon;
    }
}