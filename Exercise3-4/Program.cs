using Exercise3_4.Animals;

namespace Exercise3_4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog());
            animals.Add(new Horse());
            animals.Add(new Wolf());

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal,-10} Sound: {animal.DoSound()}");

            }
        }
    }
}