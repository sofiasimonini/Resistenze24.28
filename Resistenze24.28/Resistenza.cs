using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistenze24._28
{
    internal class Resistenza
    {
        public double Valore { get; set; }
        public Resistenza(double Valore)
        { Valore = Valore; }
        public static Resistenza operator &(Resistenza r1, Resistenza r2)
        {
            double valoreSerie = r1.Valore + r2.Valore;
            return new Resistenza(valoreSerie);
        }
        public static Resistenza operator |(Resistenza r1, Resistenza r2)
        {
            double valoreParallelo = 1 / ((1 / r1.Valore) + (1 / r2.Valore));
            return new Resistenza(valoreParallelo);
        }
        public static bool operator ==(Resistenza r1, Resistenza r2)
        {
            return r1.Valore == r2.Valore;
        }
        public static bool operator !=(Resistenza r1, Resistenza r2)
        {
            return r1.Valore != r2.Valore;
        }
        public static bool operator >(Resistenza r1, Resistenza r2)
        {
            return r1.Valore > r2.Valore;
        }
        public static bool operator <(Resistenza r1, Resistenza r2)
        {
            return r1.Valore < r2.Valore;
        }
        public static Resistenza Parse(string valore)
        {
            if (double.TryParse(valore, out double Valore))
                return new Resistenza(Valore);
            else
                return null;
        }
    }
}
