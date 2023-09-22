using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_4.Animals
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public float Age { get; set; }
        public float Weight { get; set; }

        public abstract string DoSound();

        public virtual string Stats()
        {
            return $"{GetType().Name} Name: {Name}  Age: {Age} Weight: {Weight}kg";
        }
        //public abstract string Stats();

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
