using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI_NDam
{
    public class Řešitel
    {
        private readonly int n;
        private readonly int[] řešení;
        public int PočetŘešení { get; private set; } = 0;
        int[] p = null;
        public IEnumerable<int[]> Řešení
        {
            get
            {
                while (NajdiDalšíŘešení(out p))
                {
                    yield return p;
                }
            }
        }
        public bool NajdiDalšíŘešení(out int[] výsledek)
        {
            výsledek = PočetŘešení == 0 ? ŘešOdSloupce(0) : ŘešOdSloupce(n - 1);
            if (výsledek != null)
            {
                PočetŘešení++;
            }

            return výsledek != null;
        }
        public void NajdiVšechnaŘešení()
        {
            //NajdiŘešení(0);
            int[] p = null;
            while (NajdiDalšíŘešení(out p))
                ;
        }
        private bool Bezpečné(int k, int m)// k-tá řádka, m-tý sloupec
        {
            // Application.DoEvents();
            if (m == 0) return true;    // V prvním sloupci lze umístit kamkoli
            var (výsledek, j) = (true, 0);
            while (výsledek && (j < m))         // Projdi všechny předchozí sloupce
            {
                výsledek = (řešení[j] != k) &&      // stejná řádka?
                    (řešení[m - j - 1] != k - j - 1) && // stejná diagonála?
                    (řešení[m - j - 1] != k + j + 1);
                if (!výsledek) return false;
                j++;
            }
            return true;
        }
        public void Výpis()
        {
            Console.Write("(");
            for (int i = 0; i < n; i++)
            {
                Console.Write(řešení[i] + (i < n - 1 ? ", " : ""));
            }
            Console.WriteLine(")");
        }
        private int NajdiDalšíBezpečnouŘádku(int k, int m)   // Najde další možné umístění v m-tém sloupci, začne za k-tou řádkou
        {
            while (++k < n)
            {
                if (Bezpečné(k, m))
                {
                    break;
                }
            }
            return k;                           // Neuspěje-li, vrátí n
        }
        private int[] ŘešOdSloupce(int m)            // Začne hledat další řešení, počínaje m-tým sloupcem
        {
            int k;
            while (m > -1)
            {
                k = NajdiDalšíBezpečnouŘádku(řešení[m], m);
                if (k < n)
                {
                    řešení[m++] = k;
                    if (m == n) return řešení;
                }
                else
                {
                    řešení[m--] = -1;
                }
            }
            return null;
        }
        public void NajdiŘešení(int m)
        {
            if (m == n)
            {
                //Výpis();
                PočetŘešení++;
            }
            else
            {
                for (int k = 0; k < n; k++)
                {
                    if (Bezpečné(k, m))
                    {
                        řešení[m] = k;
                        NajdiŘešení(m + 1);
                    }
                }
            }
            if (m < n)
            {
                řešení[m] = -1;
            }
        }
        public Řešitel(int n)           // Konstruktor řešitele pro úlohu n dam
        {
            this.n = n;
            řešení = new int[n];
            for (int i = 0; i < n; i++)
            {
                řešení[i] = -1;
            }
        }
    }
}

