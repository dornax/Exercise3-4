using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_4.Animals
{
    internal class Hedgehog : Animal
    {
        public bool Hibernation { get; set; } = true;
        public override string DoSound()
        {
            return "squeal, hiss";
        }
        public override string Stats()
        {
            return $"{base.Stats()} Hibernation: {Hibernation}";
        }

    }
}
