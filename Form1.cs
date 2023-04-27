using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podprocesy2;

namespace GUI_NDam
{
    using NPR = GUI_NDam.Properties.Resources;
    using NPS = GUI_NDam.Properties.Settings;
    public partial class Okno : Form
    {
        public enum SymbolDámy { Koleèko, Køížek, Obdélník }
        private int kolik = 0;
        private Øešitel øešitel = null;
        private bool nalezeno = false;
        private int[] øešení;
        private BackgroundWorker pracant;
        private (bool, bool, bool, bool) stav;
        int celkovýPoèetØešení;
        private readonly Èasovaè èasovaè;
        private DialogNastavení dialogNastavení = new DialogNastavení();
        public Okno()
        {
            InitializeComponent();
            PoužijProstøedky();
            PøipravØešitele();
            èasovaè = new Èasovaè(400)
            {
                Povolen = false
            };
            èasovaè.Tik += menuDalší_Click;
        }
        private void Tiknutí(object odesílatel, EventArgs ea)
        {
            nalezeno = øešitel.NajdiDalšíØešení(out øešení);
            if (nalezeno)
            {
                panel.Invalidate();
            }
            else
            {
                èasovaè.Povolen = false;
            }
        }
        private void PoužijProstøedky()
        {
            Icon = NPR.Dáma;
            menuHra.Text = NPR.Hra;
            menuNová.Text = NPR.Nová;
            menuOProgramu.Text = NPR.OProgramuText1;
            menuOProgramu.Text = NPR.OProgramuText2;
            menuOProgramu.Text = NPR.OProgramuTitulek;
            menuNápovìda.Text = NPR.Nápovìda;
            menuVšechna.Text = NPR.Celkový;
            menuUložit.Text = NPR.Ulož;
            menuKonec.Text = NPR.Konec;
            menuDalší.Text = NPR.Další;
            tlaèítkoDalší.Text = NPR.Další;
            èíselníkPoèetDam.Maximum = NPS.Default.Maximum;
            èíselníkPoèetDam.Minimum = NPS.Default.Minimum;
            menuAnimace.Text = NPR.Animace;
            menuSpustitAnimaci.Text = NPR.Spustit;
            menuPøerušitAnimaci.Text = NPR.Pøerušit;

        }
        private void PøipravØešitele()
        {
            kolik = (int)èíselníkPoèetDam.Value;
            øešitel = new Øešitel(kolik);
        }
        private void NastavTitulek(int kolik, int poèetØešení)
        {
            Text = string.Format(NPR.TitulekOkna, kolik, poèetØešení);
        }
        private void menuHra_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void menuOProgramu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NPR.OProgramuText1 + "\n" + NPR.OProgramuText2, NPR.OProgramuTitulek);
        }
        private void menuKonec_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Okno_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Opravdu chceš skonèit?", "Dotaz",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void menuNová_Click(object sender, EventArgs e)
        {
            PøipravØešitele();
            NastavTitulek(kolik, øešitel.PoèetØešení);
            (menuDalší.Enabled, tlaèítkoDalší.Enabled, nalezeno, menuSpustitAnimaci.Enabled) = (true, true, false, true);
            nalezeno = false;
            panel.Invalidate();
        }
        private void Zákaz()
        {
            (menuDalší.Enabled, tlaèítkoDalší.Enabled, menuSpustitAnimaci.Enabled, èasovaè.Povolen) = (false, false, false, false);
        }
        private void menuDalší_Click(object sender, EventArgs e)
        {
            nalezeno = øešitel.NajdiDalšíØešení(out øešení);
            if (!nalezeno)
            {
                MessageBox.Show("Další øešení neexistují.", "To je vše",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Invoke(new Action(Zákaz));
            }
            panel.Invalidate();
            Invoke(new Action<int, int>(NastavTitulek), kolik, øešitel.PoèetØešení);
        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafika = e.Graphics;
            if (nalezeno)
            {
                Pen pero = new Pen(Color.Black)
                {
                    Width = 1
                };
                NakresliŠachovnici(grafika, pero, out int deltax, out int deltay);
                NakresliDámy(grafika, pero, deltax, deltay);
            }
            else
            {
                grafika.Clear(Color.White);
            }
        }
        private void NakresliDámy(Graphics grafika, Pen pero, int deltax, int deltay)
        {
            pero.Width = 6;
            pero.Color = Color.Red;
            for (int i = 0; i < kolik; i++)
            {
                grafika.DrawEllipse(pero, i * deltax + deltax / 6, øešení[i] * deltay + deltay / 6, 2 * deltax / 3, 2 * deltay / 3);
            }
        }
        private void NakresliŠachovnici(Graphics grafika, Pen pero, out int deltax, out int deltay)
        {
            deltax = panel.Width / kolik;
            deltay = panel.Height / kolik;
            for (int i = 1; i < kolik; i++)
            {
                grafika.DrawLine(pero, 0, i * deltay, panel.Width, i * deltay);
                grafika.DrawLine(pero, i * deltax, 0, i * deltax, panel.Height);
            }
        }
        private void menuVšechna_Click(object sender, EventArgs e)
        {
            stav = (menuNová.Enabled, menuDalší.Enabled, menuVšechna.Enabled, tlaèítkoDalší.Enabled);
            (menuNová.Enabled, menuDalší.Enabled, menuVšechna.Enabled, tlaèítkoDalší.Enabled) = (false, false, false, false);
            PøipravØešitele();
            pracant = new BackgroundWorker
            {
                WorkerReportsProgress = true
            };
            pracant.DoWork += VlastníVýpoèet;
            pracant.RunWorkerCompleted += PoSkonèeníVýpoètu;
            pracant.RunWorkerAsync();
            pracant.ProgressChanged += (obj, událost) => { ukazatelPostupu.Value = událost.ProgressPercentage; };
        }
        private void VlastníVýpoèet(object odesílatel, DoWorkEventArgs událost)
        {
            int prvníPole = 0;
            celkovýPoèetØešení = 0;
            foreach (var pole in øešitel.Øešení)
            {
                celkovýPoèetØešení++;
                if (pole[0] != prvníPole)
                {
                    prvníPole = pole[0];
                    pracant.ReportProgress(prvníPole * 100 / kolik);
                }
            }
            pracant.ReportProgress(100);
        }
        private void PoSkonèeníVýpoètu(object odesílatel, RunWorkerCompletedEventArgs událost)
        {
            MessageBox.Show($"Úloha {kolik} dam má celkem {øešitel.Øešení.Count()} øešení", "Výsledek");
            (menuNová.Enabled, menuDalší.Enabled, menuVšechna.Enabled, tlaèítkoDalší.Enabled) = stav;
            ukazatelPostupu.Value = 0;
        }
        private void Okno_Resize(object sender, EventArgs e)
        {
            panel.Invalidate();
        }
        private void menuUložit_Click(object sender, EventArgs e)
        {
            if (dialogUložení.ShowDialog() == DialogResult.OK)
            {
                PøipravØešitele();
                using (var výstup = new StreamWriter(dialogUložení.FileName))
                {
                    foreach (var øádka in øešitel.Øešení)
                    {
                        foreach (var i in øádka)
                        {
                            výstup.Write($"{i} ");
                        }
                        výstup.WriteLine();
                    }
                }
            }
        }
        private void menuUložitNastavení_Click(object sender, EventArgs e)
        {
            NPS.Default.Save();
        }
        private void menuUpravit_Click(object sender, EventArgs e)
        {
            var stisk1 = dialogNastavení.ShowDialog();
            if (stisk1 == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
        }
        private void menuPøerušitAnimaci_Click(object sender, EventArgs e) => èasovaè.Povolen = false;
        private void menuSpustitAnimaci_Click(object sender, EventArgs e) => èasovaè.Povolen = true;
    }
}