namespace DogTests
{
    public class DogUnitTests
    {
        //Fact means no parameters
        //always what you want for defaults
        [Fact]
        public void DefaultValuesUnitTest()
        {
            //Legs, Age
            Dog d = new();
            Assert.Equal(4u, d.Legs);

            Assert.Equal(0u, d.Age);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 15)]
        [InlineData(2, 24)]
        [InlineData(5, 39)]
        public void PeopleYearsUnitTest(uint age, uint people)
        {
            Dog d = new() { Age = age };
            Assert.Equal(people, d.PeopleYears);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        [InlineData(5, 4)]
        [InlineData(1, 4)]
        [InlineData(0, 4)]
        [InlineData(100, 4)]
        public void LegsBoundUnitTest(uint newLegs, uint legsVal)
        {
            Dog d = new() { Legs = newLegs };
            Assert.Equal(legsVal, d.Legs);
        }
    }
}