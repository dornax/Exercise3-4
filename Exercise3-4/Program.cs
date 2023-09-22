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

            Dog dog1 = new Dog
            {
                Name = "Fido",
                Age = 2,
                Weight = 4
            };
            Dog dog2 = new Dog
            {
                Name = "Bob",
                Age = 3,
                Weight = 5
            };

            animals.Add(dog1);
            animals.Add(dog2);
            animals.Add(new Horse() { Name = "Hero", Age = 5, Weight = 500 }); ;
            animals.Add(new Wolf());
            animals.Add(new Pelican() { Age = 2, Weight = 1.2f, WingSpan = 2.75f });

            Console.WriteLine(animals[2].Stats()); 
            //foreach (var animal in animals)
            //{
            //    Console.WriteLine($"{animal.Stats()}");
            //}
        }
    }
}