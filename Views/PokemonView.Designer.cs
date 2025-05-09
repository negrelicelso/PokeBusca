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
        buttonBusca = new Button();
        textBoxBusca = new TextBox();
        panelResultado = new Panel();
        pictureBoxSprite = new PictureBox();
        panelHeader = new Panel();
        labelTela = new Label();
        buttonFechar = new Button();
        panelResultado.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxSprite).BeginInit();
        panelHeader.SuspendLayout();
        SuspendLayout();
        // 
        // buttonBusca
        // 
        buttonBusca.FlatStyle = FlatStyle.Flat;
        buttonBusca.Location = new Point(370, 10);
        buttonBusca.Margin = new Padding(0);
        buttonBusca.Name = "buttonBusca";
        buttonBusca.Size = new Size(30, 30);
        buttonBusca.TabIndex = 2;
        buttonBusca.UseVisualStyleBackColor = true;
        buttonBusca.Click += buttonBusca_Click;
        // 
        // textBoxBusca
        // 
        textBoxBusca.BorderStyle = BorderStyle.FixedSingle;
        textBoxBusca.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBoxBusca.Location = new Point(110, 10);
        textBoxBusca.Margin = new Padding(0);
        textBoxBusca.Multiline = true;
        textBoxBusca.Name = "textBoxBusca";
        textBoxBusca.PlaceholderText = "Procurar";
        textBoxBusca.Size = new Size(250, 30);
        textBoxBusca.TabIndex = 1;
        // 
        // panelResultado
        // 
        panelResultado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panelResultado.Controls.Add(pictureBoxSprite);
        panelResultado.Location = new Point(0, 0);
        panelResultado.Margin = new Padding(0);
        panelResultado.Name = "panelResultado";
        panelResultado.Size = new Size(984, 411);
        panelResultado.TabIndex = 0;
        // 
        // pictureBoxSprite
        // 
        pictureBoxSprite.BorderStyle = BorderStyle.FixedSingle;
        pictureBoxSprite.Location = new Point(10, 10);
        pictureBoxSprite.Margin = new Padding(0);
        pictureBoxSprite.Name = "pictureBoxSprite";
        pictureBoxSprite.Size = new Size(100, 100);
        pictureBoxSprite.TabIndex = 0;
        pictureBoxSprite.TabStop = false;
        // 
        // panelHeader
        // 
        panelHeader.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panelHeader.Controls.Add(labelTela);
        panelHeader.Controls.Add(buttonFechar);
        panelHeader.Controls.Add(textBoxBusca);
        panelHeader.Controls.Add(buttonBusca);
        panelHeader.Location = new Point(0, 411);
        panelHeader.Margin = new Padding(0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(984, 50);
        panelHeader.TabIndex = 3;
        // 
        // labelTela
        // 
        labelTela.AutoSize = true;
        labelTela.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelTela.Location = new Point(10, 10);
        labelTela.Margin = new Padding(0);
        labelTela.Name = "labelTela";
        labelTela.Size = new Size(90, 30);
        labelTela.TabIndex = 0;
        labelTela.Text = "Pokédex";
        // 
        // buttonFechar
        // 
        buttonFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonFechar.FlatStyle = FlatStyle.Flat;
        buttonFechar.Location = new Point(944, 10);
        buttonFechar.Margin = new Padding(0);
        buttonFechar.Name = "buttonFechar";
        buttonFechar.Size = new Size(30, 30);
        buttonFechar.TabIndex = 3;
        buttonFechar.UseVisualStyleBackColor = true;
        buttonFechar.Click += buttonFechar_Click;
        // 
        // PokemonView
        // 
        AcceptButton = buttonBusca;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = buttonFechar;
        ClientSize = new Size(984, 461);
        Controls.Add(panelHeader);
        Controls.Add(panelResultado);
        Name = "PokemonView";
        panelResultado.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBoxSprite).EndInit();
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Button buttonBusca;
    private TextBox textBoxBusca;
    private Panel panelResultado;
    private Panel panelHeader;
    private Button buttonFechar;
    private Label labelTela;
    private PictureBox pictureBoxSprite;
}
