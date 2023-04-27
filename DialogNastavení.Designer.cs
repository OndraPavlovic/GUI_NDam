namespace GUI_NDam
{
    partial class DialogNastavení
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
            zaškrtniZdaPočetPokusů = new CheckBox();
            skupina = new GroupBox();
            přepínačObdélník = new RadioButton();
            přepínačKřížek = new RadioButton();
            přepínačKolečko = new RadioButton();
            textNázev = new TextBox();
            nápis = new Label();
            barva = new Label();
            panelBarva = new Panel();
            tlačítkoZměnaBarvy = new Button();
            button1 = new Button();
            button2 = new Button();
            skupina.SuspendLayout();
            SuspendLayout();
            // 
            // zaškrtniZdaPočetPokusů
            // 
            zaškrtniZdaPočetPokusů.AutoSize = true;
            zaškrtniZdaPočetPokusů.Location = new Point(44, 30);
            zaškrtniZdaPočetPokusů.Name = "zaškrtniZdaPočetPokusů";
            zaškrtniZdaPočetPokusů.Size = new Size(421, 29);
            zaškrtniZdaPočetPokusů.TabIndex = 0;
            zaškrtniZdaPočetPokusů.Text = "Zobrazovat počet pokusů o umístění další dámy";
            zaškrtniZdaPočetPokusů.UseVisualStyleBackColor = true;
            // 
            // skupina
            // 
            skupina.Controls.Add(přepínačObdélník);
            skupina.Controls.Add(přepínačKřížek);
            skupina.Controls.Add(přepínačKolečko);
            skupina.Location = new Point(44, 93);
            skupina.Name = "skupina";
            skupina.Size = new Size(172, 150);
            skupina.TabIndex = 1;
            skupina.TabStop = false;
            skupina.Text = "Zobrazení dámy";
            // 
            // přepínačObdélník
            // 
            přepínačObdélník.AutoSize = true;
            přepínačObdélník.Location = new Point(21, 108);
            přepínačObdélník.Name = "přepínačObdélník";
            přepínačObdélník.Size = new Size(109, 29);
            přepínačObdélník.TabIndex = 2;
            přepínačObdélník.TabStop = true;
            přepínačObdélník.Text = "Obdélník";
            přepínačObdélník.UseVisualStyleBackColor = true;
            // 
            // přepínačKřížek
            // 
            přepínačKřížek.AutoSize = true;
            přepínačKřížek.Location = new Point(21, 73);
            přepínačKřížek.Name = "přepínačKřížek";
            přepínačKřížek.Size = new Size(83, 29);
            přepínačKřížek.TabIndex = 1;
            přepínačKřížek.TabStop = true;
            přepínačKřížek.Text = "Křížek";
            přepínačKřížek.UseVisualStyleBackColor = true;
            // 
            // přepínačKolečko
            // 
            přepínačKolečko.AutoSize = true;
            přepínačKolečko.Location = new Point(21, 38);
            přepínačKolečko.Name = "přepínačKolečko";
            přepínačKolečko.Size = new Size(99, 29);
            přepínačKolečko.TabIndex = 0;
            přepínačKolečko.TabStop = true;
            přepínačKolečko.Text = "Kolečko";
            přepínačKolečko.UseVisualStyleBackColor = true;
            // 
            // textNázev
            // 
            textNázev.Location = new Point(44, 290);
            textNázev.Name = "textNázev";
            textNázev.Size = new Size(329, 31);
            textNázev.TabIndex = 2;
            // 
            // nápis
            // 
            nápis.AutoSize = true;
            nápis.Location = new Point(44, 262);
            nápis.Name = "nápis";
            nápis.Size = new Size(145, 25);
            nápis.TabIndex = 3;
            nápis.Text = "Název programu";
            // 
            // barva
            // 
            barva.AutoSize = true;
            barva.Location = new Point(360, 93);
            barva.Name = "barva";
            barva.Size = new Size(105, 25);
            barva.TabIndex = 4;
            barva.Text = "Barva dámy";
            // 
            // panelBarva
            // 
            panelBarva.Location = new Point(487, 93);
            panelBarva.Name = "panelBarva";
            panelBarva.Size = new Size(60, 32);
            panelBarva.TabIndex = 5;
            // 
            // tlačítkoZměnaBarvy
            // 
            tlačítkoZměnaBarvy.Location = new Point(593, 91);
            tlačítkoZměnaBarvy.Name = "tlačítkoZměnaBarvy";
            tlačítkoZměnaBarvy.Size = new Size(112, 34);
            tlačítkoZměnaBarvy.TabIndex = 6;
            tlačítkoZměnaBarvy.Text = "Změnit ...";
            tlačítkoZměnaBarvy.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(460, 355);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(593, 355);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "Storno";
            button2.UseVisualStyleBackColor = true;
            // 
            // DialogNastavení
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tlačítkoZměnaBarvy);
            Controls.Add(panelBarva);
            Controls.Add(barva);
            Controls.Add(nápis);
            Controls.Add(textNázev);
            Controls.Add(skupina);
            Controls.Add(zaškrtniZdaPočetPokusů);
            Name = "DialogNastavení";
            Text = "DialogNastavení";
            skupina.ResumeLayout(false);
            skupina.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox zaškrtniZdaPočetPokusů;
        private GroupBox skupina;
        private RadioButton přepínačObdélník;
        private RadioButton přepínačKřížek;
        private RadioButton přepínačKolečko;
        private TextBox textNázev;
        private Label nápis;
        private Label barva;
        private Panel panelBarva;
        private Button tlačítkoZměnaBarvy;
        private Button button1;
        private Button button2;
    }
}