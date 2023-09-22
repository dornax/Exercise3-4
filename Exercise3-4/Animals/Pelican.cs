using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_4.Animals
{

    internal class Pelican : Bird
    {
        public bool LongBeak { get; set; } = true;

        public override string Stats()
        {
            return $"{base.Stats()} Long Beak: {LongBeak}";
        }
    }
}
