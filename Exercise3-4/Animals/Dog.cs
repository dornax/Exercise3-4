using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_4.Animals
{
    internal class Dog : Animal
    {
        public bool MansBestFriend { get; set; } = true;

        public override string DoSound()
        {
            return "bark";
        }

        public override string Stats()
        {
            return $"{base.Stats()} MansBestFriend: {MansBestFriend}";
        }

    }
}
