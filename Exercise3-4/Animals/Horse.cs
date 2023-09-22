using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_4.Animals
{
    internal class Horse : Animal
    {

        public string Breed { get; set; } = "Appaloosa";
        public override string DoSound()
        {
            return "neigh";
        }

        public override string Stats()
        {
            return $"{base.Stats()} Breed: {Breed}";
        }
    }
}
