using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_4.Animals
{
    internal class Wolf : Animal
    {
        public bool PackAnimal { get; set; } = true;
        public override string DoSound()
        {
            return "howl";
        }

        public override string Stats()
        {
            return $"{base.Stats()} Pack Animal: {PackAnimal}";
        }
    }
}
