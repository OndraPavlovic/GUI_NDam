using System;

namespace Podprocesy2
{
    public delegate void Načasováno(object sender, EventArgs arg);
    class Časovač
    {
        private bool povolen = false;
        private Thread podproces;
        private readonly object zámek = new object();
        public int Interval { get; set; } = 10;
        public event Načasováno Tik;
        public Časovač(int interval)
        {
            Interval = interval;
            podproces = new Thread(Běh)
            {
                IsBackground = true
            };
            podproces.Start();
        }
        public bool Povolen
        {
            get => povolen;
            set
            {
                lock (zámek)
                {
                    povolen = value;
                    if (povolen)
                    {
                        Monitor.Pulse(zámek);
                    }
                }
            }
        }
        protected virtual void OnTik(EventArgs ea) => Tik?.Invoke(this, ea);
        private void Běh()
        {
            for (; ; )
            {
                if (Tik != null)
                {
                    OnTik(new EventArgs());
                }
                Thread.Sleep(Interval);
                lock (zámek)
                {
                    while (!Povolen)
                    {
                        Monitor.Wait(zámek);
                    }
                }
            }
        }
    }
}

