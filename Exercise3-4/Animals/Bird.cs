using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_4.Animals
{
    internal class Bird : Animal
    {
        public float WingSpan { get; set; }

        public override string DoSound()
        {
            return "chirp, whistle";
        }
        public override string Stats()
        {
            return $"{base.Stats()} Wingspan: {WingSpan}m";
        }
    }
}
