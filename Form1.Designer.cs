namespace GUI_NDam
{
    partial class Okno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno));
            nabídka = new MenuStrip();
            menuHra = new ToolStripMenuItem();
            menuNová = new ToolStripMenuItem();
            menuDalší = new ToolStripMenuItem();
            menuVšechna = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            menuUložit = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            menuKonec = new ToolStripMenuItem();
            menuAnimace = new ToolStripMenuItem();
            menuSpustitAnimaci = new ToolStripMenuItem();
            menuPřerušitAnimaci = new ToolStripMenuItem();
            menuNastavení = new ToolStripMenuItem();
            menuUpravit = new ToolStripMenuItem();
            menuObnovitVýchozí = new ToolStripMenuItem();
            menuUložitNastavení = new ToolStripMenuItem();
            menuNápověda = new ToolStripMenuItem();
            menuOProgramu = new ToolStripMenuItem();
            panel = new Panel();
            číselníkPočetDam = new NumericUpDown();
            tlačítkoDalší = new Button();
            Nápis = new Label();
            dialogUložení = new SaveFileDialog();
            statusStrip1 = new StatusStrip();
            ukazatelPostupu = new ToolStripProgressBar();
            nabídka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)číselníkPočetDam).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nabídka
            // 
            nabídka.ImageScalingSize = new Size(24, 24);
            nabídka.Items.AddRange(new ToolStripItem[] { menuHra, menuAnimace, menuNastavení, menuNápověda });
            nabídka.Location = new Point(0, 0);
            nabídka.Name = "nabídka";
            nabídka.Size = new Size(703, 33);
            nabídka.TabIndex = 0;
            nabídka.Text = "menuStrip1";
            // 
            // menuHra
            // 
            menuHra.DropDownItems.AddRange(new ToolStripItem[] { menuNová, menuDalší, menuVšechna, toolStripMenuItem2, menuUložit, toolStripMenuItem1, menuKonec });
            menuHra.Name = "menuHra";
            menuHra.Size = new Size(56, 29);
            menuHra.Text = "Hra";
            menuHra.Click += menuHra_Click;
            // 
            // menuNová
            // 
            menuNová.Name = "menuNová";
            menuNová.Size = new Size(309, 34);
            menuNová.Text = "Nová úloha";
            menuNová.Click += menuNová_Click;
            // 
            // menuDalší
            // 
            menuDalší.Enabled = false;
            menuDalší.Name = "menuDalší";
            menuDalší.Size = new Size(309, 34);
            menuDalší.Text = "Další řešení";
            menuDalší.Click += menuDalší_Click;
            // 
            // menuVšechna
            // 
            menuVšechna.Name = "menuVšechna";
            menuVšechna.Size = new Size(309, 34);
            menuVšechna.Text = "Celkový počet řešení";
            menuVšechna.Click += menuVšechna_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(306, 6);
            // 
            // menuUložit
            // 
            menuUložit.Name = "menuUložit";
            menuUložit.Size = new Size(309, 34);
            menuUložit.Text = "Uložit řešení do souboru";
            menuUložit.Click += menuUložit_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(306, 6);
            // 
            // menuKonec
            // 
            menuKonec.Name = "menuKonec";
            menuKonec.Size = new Size(309, 34);
            menuKonec.Text = "Konec";
            menuKonec.Click += menuKonec_Click;
            // 
            // menuAnimace
            // 
            menuAnimace.DropDownItems.AddRange(new ToolStripItem[] { menuSpustitAnimaci, menuPřerušitAnimaci });
            menuAnimace.Name = "menuAnimace";
            menuAnimace.Size = new Size(96, 29);
            menuAnimace.Text = "Animace";
            // 
            // menuSpustitAnimaci
            // 
            menuSpustitAnimaci.Enabled = false;
            menuSpustitAnimaci.Name = "menuSpustitAnimaci";
            menuSpustitAnimaci.Size = new Size(238, 34);
            menuSpustitAnimaci.Text = "Spustit animaci";
            menuSpustitAnimaci.Click += menuSpustitAnimaci_Click;
            // 
            // menuPřerušitAnimaci
            // 
            menuPřerušitAnimaci.Name = "menuPřerušitAnimaci";
            menuPřerušitAnimaci.Size = new Size(238, 34);
            menuPřerušitAnimaci.Text = "Přerušit animaci";
            menuPřerušitAnimaci.Click += menuPřerušitAnimaci_Click;
            // 
            // menuNastavení
            // 
            menuNastavení.DropDownItems.AddRange(new ToolStripItem[] { menuUpravit, menuObnovitVýchozí, menuUložitNastavení });
            menuNastavení.Name = "menuNastavení";
            menuNastavení.Size = new Size(105, 29);
            menuNastavení.Text = "Nastavení";
            // 
            // menuUpravit
            // 
            menuUpravit.Name = "menuUpravit";
            menuUpravit.Size = new Size(243, 34);
            menuUpravit.Text = "Upravit...";
            menuUpravit.Click += menuUpravit_Click;
            // 
            // menuObnovitVýchozí
            // 
            menuObnovitVýchozí.Name = "menuObnovitVýchozí";
            menuObnovitVýchozí.Size = new Size(243, 34);
            menuObnovitVýchozí.Text = "Obnovit výchozí";
            // 
            // menuUložitNastavení
            // 
            menuUložitNastavení.Name = "menuUložitNastavení";
            menuUložitNastavení.Size = new Size(243, 34);
            menuUložitNastavení.Text = "Uložit";
            menuUložitNastavení.Click += menuUložitNastavení_Click;
            // 
            // menuNápověda
            // 
            menuNápověda.DropDownItems.AddRange(new ToolStripItem[] { menuOProgramu });
            menuNápověda.Name = "menuNápověda";
            menuNápověda.Size = new Size(110, 29);
            menuNápověda.Text = "Nápověda";
            // 
            // menuOProgramu
            // 
            menuOProgramu.Name = "menuOProgramu";
            menuOProgramu.Size = new Size(213, 34);
            menuOProgramu.Text = "O programu";
            menuOProgramu.Click += menuOProgramu_Click;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Location = new Point(12, 49);
            panel.Name = "panel";
            panel.Size = new Size(480, 488);
            panel.TabIndex = 1;
            panel.Paint += panel_Paint;
            // 
            // číselníkPočetDam
            // 
            číselníkPočetDam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            číselníkPočetDam.Location = new Point(624, 65);
            číselníkPočetDam.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            číselníkPočetDam.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            číselníkPočetDam.Name = "číselníkPočetDam";
            číselníkPočetDam.Size = new Size(67, 31);
            číselníkPočetDam.TabIndex = 2;
            číselníkPočetDam.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // tlačítkoDalší
            // 
            tlačítkoDalší.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tlačítkoDalší.Enabled = false;
            tlačítkoDalší.Location = new Point(508, 129);
            tlačítkoDalší.Name = "tlačítkoDalší";
            tlačítkoDalší.Size = new Size(183, 34);
            tlačítkoDalší.TabIndex = 3;
            tlačítkoDalší.Text = "Najdi další řešení";
            tlačítkoDalší.UseVisualStyleBackColor = true;
            tlačítkoDalší.Click += menuDalší_Click;
            // 
            // Nápis
            // 
            Nápis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Nápis.AutoSize = true;
            Nápis.Location = new Point(508, 67);
            Nápis.Name = "Nápis";
            Nápis.Size = new Size(100, 25);
            Nápis.TabIndex = 4;
            Nápis.Text = "Počet dam:";
            // 
            // dialogUložení
            // 
            dialogUložení.Filter = "Textové soubory (*.txt)|*.txt|Všechny soubory (*.*)|*.*";
            dialogUložení.Title = "Uložit řešení jako";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ukazatelPostupu });
            statusStrip1.Location = new Point(0, 521);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(703, 28);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // ukazatelPostupu
            // 
            ukazatelPostupu.Margin = new Padding(15, 4, 2, 4);
            ukazatelPostupu.Name = "ukazatelPostupu";
            ukazatelPostupu.Size = new Size(250, 20);
            // 
            // Okno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 549);
            Controls.Add(statusStrip1);
            Controls.Add(Nápis);
            Controls.Add(tlačítkoDalší);
            Controls.Add(číselníkPočetDam);
            Controls.Add(panel);
            Controls.Add(nabídka);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = nabídka;
            Name = "Okno";
            Text = "Úloha N Dam";
            FormClosing += Okno_FormClosing;
            Load += Form1_Load;
            Resize += Okno_Resize;
            nabídka.ResumeLayout(false);
            nabídka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)číselníkPočetDam).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip nabídka;
        private ToolStripMenuItem menuHra;
        private ToolStripMenuItem menuNová;
        private ToolStripMenuItem menuDalší;
        private ToolStripMenuItem menuVšechna;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menuKonec;
        private ToolStripMenuItem menuNápověda;
        private ToolStripMenuItem menuOProgramu;
        private Panel panel;
        private NumericUpDown číselníkPočetDam;
        private Button tlačítkoDalší;
        private Label Nápis;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem menuUložit;
        private SaveFileDialog dialogUložení;
        private ToolStripMenuItem menuNastavení;
        private ToolStripMenuItem menuUpravit;
        private ToolStripMenuItem menuObnovitVýchozí;
        private ToolStripMenuItem menuUložitNastavení;
        private ToolStripMenuItem menuAnimace;
        private ToolStripMenuItem menuSpustitAnimaci;
        private ToolStripMenuItem menuPřerušitAnimaci;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar ukazatelPostupu;
    }
}