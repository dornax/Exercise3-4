namespace Tests
{
    public class UnitTest
    {
        [Fact]
        public void StatsTest()
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Horse() { Name = "Hero", Age = 5, Weight = 500 });

            string expected = "Horse Name: Hero Age: 5 Weight: 500kg Breed: Appaloosa";

            Assert.Equal(expected, animals[0].Stats());
        }
    }
}