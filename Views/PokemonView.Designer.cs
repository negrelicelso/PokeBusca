namespace PokeBusca.Views;

partial class PokemonView
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textBoxResultado = new TextBox();
        buttonBusca = new Button();
        textBoxBusca = new TextBox();
        SuspendLayout();
        // 
        // textBoxResultado
        // 
        textBoxResultado.Dock = DockStyle.Bottom;
        textBoxResultado.Location = new Point(0, 56);
        textBoxResultado.Margin = new Padding(0);
        textBoxResultado.Multiline = true;
        textBoxResultado.Name = "textBoxResultado";
        textBoxResultado.ReadOnly = true;
        textBoxResultado.ScrollBars = ScrollBars.Both;
        textBoxResultado.Size = new Size(984, 405);
        textBoxResultado.TabIndex = 0;
        textBoxResultado.TabStop = false;
        // 
        // buttonBusca
        // 
        buttonBusca.Location = new Point(220, 11);
        buttonBusca.Margin = new Padding(0);
        buttonBusca.Name = "buttonBusca";
        buttonBusca.Size = new Size(100, 23);
        buttonBusca.TabIndex = 2;
        buttonBusca.Text = "Busca";
        buttonBusca.UseVisualStyleBackColor = true;
        buttonBusca.Click += buttonBusca_Click;
        // 
        // textBoxBusca
        // 
        textBoxBusca.Location = new Point(10, 11);
        textBoxBusca.Margin = new Padding(0);
        textBoxBusca.Name = "textBoxBusca";
        textBoxBusca.PlaceholderText = "Número ou Nome do Pokémon";
        textBoxBusca.Size = new Size(200, 23);
        textBoxBusca.TabIndex = 1;
        // 
        // PokemonView
        // 
        AcceptButton = buttonBusca;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(984, 461);
        Controls.Add(textBoxBusca);
        Controls.Add(buttonBusca);
        Controls.Add(textBoxResultado);
        Name = "PokemonView";
        Text = "PokeBusca";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBoxResultado;
    private Button buttonBusca;
    private TextBox textBoxBusca;
}
