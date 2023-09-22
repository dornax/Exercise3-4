using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise3_4.Animals;

namespace Exercise3_4
{
    internal class Wolfman : Wolf, IPerson
    {
        public string Talk()
        {
            return base.DoSound();
        }
    }
}

