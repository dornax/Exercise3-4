using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_4.Animals
{
    internal class Swan : Bird
    {
        public bool MateForLife { get; set; } = true;

        public override string Stats()
        {
            return $"{base.Stats()} Mate for Life: {MateForLife}";
        }
    }
}
