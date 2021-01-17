using System;

namespace GraModel
{
    public class Gra
    {
        private readonly int liczbaOdgadywana;
        public int Min { get; private set; }
        public int Max { get; private set; }
        // historia ruchów

        // ctor's

        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <exception cref="ArgumentException">jeśli min > max</exception>
        public Gra(int min, int max)
        {
            this.Min = min;
            Max = max;
            liczbaOdgadywana = (new Random()).Next(min, max + 1);
            // historia
        }

        public Gra(): this(1,100) {  }

        // inne metody

    }
}
