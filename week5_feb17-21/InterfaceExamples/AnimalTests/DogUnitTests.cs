namespace AnimalTests
{
    public class DogUnitTests
    {
        [Fact]
        public void DefaultsUnitTest()
        {
            //legs, age

            Dog d = new();
            Assert.Equal(4u, d.Legs);

            Assert.Equal(0u, d.Age);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 15)]
        [InlineData(2, 24)]
        [InlineData(5, 39)]
        public void PeopleYearsUnitTest(uint age, uint expPeopleYears)
        {
            Dog d = new() { Age = age };

            Assert.Equal(expPeopleYears, d.PeopleYears);
        }

        [Theory]
        [InlineData(5, 4)]
        [InlineData(1, 4)]
        [InlineData(0, 4)]
        [InlineData(15, 4)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        public void LegsBoundsUnitTest(uint legs, uint expectedLegs)
        {
            Dog d = new() { Legs = legs };
            Assert.Equal(expectedLegs, d.Legs);
        }
    }   

}