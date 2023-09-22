using Exercise3_4.Animals;

namespace Exercise3_4
{
    internal class Program
    {
        //  9. Häst är en annan typ än hundar.
        // 10. Listan måste vara av typ Animal.
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog());
            animals.Add(new Horse());
            animals.Add(new Wolf());

            foreach (var animal in animals)
                if (animal is IPerson castedToIPerson)
                {
                    Console.WriteLine($"{animal,-10} talk: {castedToIPerson.Talk()}");
                }
                else
                {
                    Console.WriteLine($"{animal,-10} Sound: {animal.DoSound()}");
                }
        }
    }
}
