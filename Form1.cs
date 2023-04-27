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
        public enum SymbolD�my { Kole�ko, K��ek, Obd�ln�k }
        private int kolik = 0;
        private �e�itel �e�itel = null;
        private bool nalezeno = false;
        private int[] �e�en�;
        private BackgroundWorker pracant;
        private (bool, bool, bool, bool) stav;
        int celkov�Po�et�e�en�;
        private readonly �asova� �asova�;
        private DialogNastaven� dialogNastaven� = new DialogNastaven�();
        public Okno()
        {
            InitializeComponent();
            Pou�ijProst�edky();
            P�iprav�e�itele();
            �asova� = new �asova�(400)
            {
                Povolen = false
            };
            �asova�.Tik += menuDal��_Click;
        }
        private void Tiknut�(object odes�latel, EventArgs ea)
        {
            nalezeno = �e�itel.NajdiDal���e�en�(out �e�en�);
            if (nalezeno)
            {
                panel.Invalidate();
            }
            else
            {
                �asova�.Povolen = false;
            }
        }
        private void Pou�ijProst�edky()
        {
            Icon = NPR.D�ma;
            menuHra.Text = NPR.Hra;
            menuNov�.Text = NPR.Nov�;
            menuOProgramu.Text = NPR.OProgramuText1;
            menuOProgramu.Text = NPR.OProgramuText2;
            menuOProgramu.Text = NPR.OProgramuTitulek;
            menuN�pov�da.Text = NPR.N�pov�da;
            menuV�echna.Text = NPR.Celkov�;
            menuUlo�it.Text = NPR.Ulo�;
            menuKonec.Text = NPR.Konec;
            menuDal��.Text = NPR.Dal��;
            tla��tkoDal��.Text = NPR.Dal��;
            ��seln�kPo�etDam.Maximum = NPS.Default.Maximum;
            ��seln�kPo�etDam.Minimum = NPS.Default.Minimum;
            menuAnimace.Text = NPR.Animace;
            menuSpustitAnimaci.Text = NPR.Spustit;
            menuP�eru�itAnimaci.Text = NPR.P�eru�it;

        }
        private void P�iprav�e�itele()
        {
            kolik = (int)��seln�kPo�etDam.Value;
            �e�itel = new �e�itel(kolik);
        }
        private void NastavTitulek(int kolik, int po�et�e�en�)
        {
            Text = string.Format(NPR.TitulekOkna, kolik, po�et�e�en�);
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
            if (MessageBox.Show("Opravdu chce� skon�it?", "Dotaz",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void menuNov�_Click(object sender, EventArgs e)
        {
            P�iprav�e�itele();
            NastavTitulek(kolik, �e�itel.Po�et�e�en�);
            (menuDal��.Enabled, tla��tkoDal��.Enabled, nalezeno, menuSpustitAnimaci.Enabled) = (true, true, false, true);
            nalezeno = false;
            panel.Invalidate();
        }
        private void Z�kaz()
        {
            (menuDal��.Enabled, tla��tkoDal��.Enabled, menuSpustitAnimaci.Enabled, �asova�.Povolen) = (false, false, false, false);
        }
        private void menuDal��_Click(object sender, EventArgs e)
        {
            nalezeno = �e�itel.NajdiDal���e�en�(out �e�en�);
            if (!nalezeno)
            {
                MessageBox.Show("Dal�� �e�en� neexistuj�.", "To je v�e",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Invoke(new Action(Z�kaz));
            }
            panel.Invalidate();
            Invoke(new Action<int, int>(NastavTitulek), kolik, �e�itel.Po�et�e�en�);
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
                Nakresli�achovnici(grafika, pero, out int deltax, out int deltay);
                NakresliD�my(grafika, pero, deltax, deltay);
            }
            else
            {
                grafika.Clear(Color.White);
            }
        }
        private void NakresliD�my(Graphics grafika, Pen pero, int deltax, int deltay)
        {
            pero.Width = 6;
            pero.Color = Color.Red;
            for (int i = 0; i < kolik; i++)
            {
                grafika.DrawEllipse(pero, i * deltax + deltax / 6, �e�en�[i] * deltay + deltay / 6, 2 * deltax / 3, 2 * deltay / 3);
            }
        }
        private void Nakresli�achovnici(Graphics grafika, Pen pero, out int deltax, out int deltay)
        {
            deltax = panel.Width / kolik;
            deltay = panel.Height / kolik;
            for (int i = 1; i < kolik; i++)
            {
                grafika.DrawLine(pero, 0, i * deltay, panel.Width, i * deltay);
                grafika.DrawLine(pero, i * deltax, 0, i * deltax, panel.Height);
            }
        }
        private void menuV�echna_Click(object sender, EventArgs e)
        {
            stav = (menuNov�.Enabled, menuDal��.Enabled, menuV�echna.Enabled, tla��tkoDal��.Enabled);
            (menuNov�.Enabled, menuDal��.Enabled, menuV�echna.Enabled, tla��tkoDal��.Enabled) = (false, false, false, false);
            P�iprav�e�itele();
            pracant = new BackgroundWorker
            {
                WorkerReportsProgress = true
            };
            pracant.DoWork += Vlastn�V�po�et;
            pracant.RunWorkerCompleted += PoSkon�en�V�po�tu;
            pracant.RunWorkerAsync();
            pracant.ProgressChanged += (obj, ud�lost) => { ukazatelPostupu.Value = ud�lost.ProgressPercentage; };
        }
        private void Vlastn�V�po�et(object odes�latel, DoWorkEventArgs ud�lost)
        {
            int prvn�Pole = 0;
            celkov�Po�et�e�en� = 0;
            foreach (var pole in �e�itel.�e�en�)
            {
                celkov�Po�et�e�en�++;
                if (pole[0] != prvn�Pole)
                {
                    prvn�Pole = pole[0];
                    pracant.ReportProgress(prvn�Pole * 100 / kolik);
                }
            }
            pracant.ReportProgress(100);
        }
        private void PoSkon�en�V�po�tu(object odes�latel, RunWorkerCompletedEventArgs ud�lost)
        {
            MessageBox.Show($"�loha {kolik} dam m� celkem {�e�itel.�e�en�.Count()} �e�en�", "V�sledek");
            (menuNov�.Enabled, menuDal��.Enabled, menuV�echna.Enabled, tla��tkoDal��.Enabled) = stav;
            ukazatelPostupu.Value = 0;
        }
        private void Okno_Resize(object sender, EventArgs e)
        {
            panel.Invalidate();
        }
        private void menuUlo�it_Click(object sender, EventArgs e)
        {
            if (dialogUlo�en�.ShowDialog() == DialogResult.OK)
            {
                P�iprav�e�itele();
                using (var v�stup = new StreamWriter(dialogUlo�en�.FileName))
                {
                    foreach (var ��dka in �e�itel.�e�en�)
                    {
                        foreach (var i in ��dka)
                        {
                            v�stup.Write($"{i} ");
                        }
                        v�stup.WriteLine();
                    }
                }
            }
        }
        private void menuUlo�itNastaven�_Click(object sender, EventArgs e)
        {
            NPS.Default.Save();
        }
        private void menuUpravit_Click(object sender, EventArgs e)
        {
            var stisk1 = dialogNastaven�.ShowDialog();
            if (stisk1 == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
        }
        private void menuP�eru�itAnimaci_Click(object sender, EventArgs e) => �asova�.Povolen = false;
        private void menuSpustitAnimaci_Click(object sender, EventArgs e) => �asova�.Povolen = true;
    }
}